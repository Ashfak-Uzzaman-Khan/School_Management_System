using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_StudentManager : UserControl
    {
        private int selectedStudentId = 0;
        private int selectedUserId = 0;

        public UC_StudentManager()
        {
            InitializeComponent();
        }

        private void UC_StudentManager_Load(object sender, EventArgs e)
        {
            // Gender dropdown
            cmb_Gender.Items.Clear();
            cmb_Gender.Items.Add("-- Select --");
            cmb_Gender.Items.Add("Male");
            cmb_Gender.Items.Add("Female");
            cmb_Gender.Items.Add("Other");
            cmb_Gender.SelectedIndex = 0;

            // Status form combobox
            cmb_Status.Items.Clear();
            cmb_Status.Items.Add("Pending");
            cmb_Status.Items.Add("Active");
            cmb_Status.Items.Add("Inactive");
            cmb_Status.SelectedIndex = 1; // default Active

            // Status filter combobox
            cmb_StatusFilter.Items.Clear();
            cmb_StatusFilter.Items.Add("All");
            cmb_StatusFilter.Items.Add("Active");
            cmb_StatusFilter.Items.Add("Inactive");
            cmb_StatusFilter.Items.Add("Pending");
            cmb_StatusFilter.SelectedIndex = 0;

            // Load departments from DB
            LoadDepartments();

            ConfigureGrid();
            LoadStudents("", "All");
        }

        private void LoadDepartments()
        {
            try
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable("SELECT DepartmentId, DepartmentName FROM Departments ORDER BY DepartmentName");
                cmb_Department.Items.Clear();
                cmb_Department.Items.Add("-- Select --");
                foreach (DataRow row in dt.Rows)
                {
                    cmb_Department.Items.Add(new ComboBoxItem(
                        row["DepartmentName"].ToString(),
                        Convert.ToInt32(row["DepartmentId"])
                    ));
                }
                cmb_Department.SelectedIndex = 0;
            }
            catch { }
        }

        // Helper class for department combo
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public ComboBoxItem(string text, int value) { Text = text; Value = value; }
            public override string ToString() { return Text; }
        }

        private int GetSelectedDepartmentId()
        {
            if (cmb_Department.SelectedIndex > 0 && cmb_Department.SelectedItem is ComboBoxItem item)
                return item.Value;
            return -1;
        }

        private void SetSelectedDepartment(int deptId)
        {
            for (int i = 1; i < cmb_Department.Items.Count; i++)
            {
                if (cmb_Department.Items[i] is ComboBoxItem item && item.Value == deptId)
                {
                    cmb_Department.SelectedIndex = i;
                    return;
                }
            }
            cmb_Department.SelectedIndex = 0;
        }

        private void ConfigureGrid()
        {
            dgv_Students.Columns.Clear();
            dgv_Students.Columns.Add("StudentId", "StudentId");
            dgv_Students.Columns.Add("UserName", "User Name");
            dgv_Students.Columns.Add("Email", "Email");
            dgv_Students.Columns.Add("Phone", "Phone");
            dgv_Students.Columns.Add("Gender", "Gender");
            dgv_Students.Columns.Add("Department", "Department");
            dgv_Students.Columns.Add("Status", "Status");

            // Style
            dgv_Students.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Students.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Students.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Students.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Students.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Students.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Students.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_Students.Columns["StudentId"].Visible = false;
        }

        private void LoadStudents(string searchTerm, string statusFilter)
        {
            try
            {
                DataAccess da = new DataAccess();

                string sql = @"SELECT s.StudentId, a.UserName, a.Email, s.Phone, s.Gender,
                               d.DepartmentName, s.Status
                               FROM StudentInfo s
                               INNER JOIN AuthenticationInfo a ON s.UserId = a.UserId
                               INNER JOIN Departments d ON s.DepartmentId = d.DepartmentId
                               WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    sql += @" AND (a.UserName LIKE @Search OR a.Email LIKE @Search)";
                }

                if (statusFilter != "All")
                {
                    sql += " AND s.Status = @Status";
                }

                sql += " ORDER BY a.UserName";


                // New (safe):
                System.Collections.Generic.List<SqlParameter> paramList = new System.Collections.Generic.List<SqlParameter>();
                if (!string.IsNullOrWhiteSpace(searchTerm))
                    paramList.Add(new SqlParameter("@Search", "%" + searchTerm + "%"));
                if (statusFilter != "All")
                    paramList.Add(new SqlParameter("@Status", statusFilter));
                SqlParameter[] parameters = paramList.ToArray();

                DataTable dt = da.ExecuteQueryTable(sql, parameters);
                dgv_Students.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgv_Students.Rows.Add(
                        row["StudentId"],
                        row["UserName"],
                        row["Email"],
                        row["Phone"],
                        row["Gender"],
                        row["DepartmentName"],
                        row["Status"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            selectedStudentId = 0;
            selectedUserId = 0;
            txt_UserName.Clear();
            txt_Email.Clear();
            txt_Password.Clear();
            txt_Phone.Clear();
            cmb_Gender.SelectedIndex = 0;
            txt_Address.Clear();
            cmb_Department.SelectedIndex = 0;
            cmb_Status.SelectedIndex = 1; // Active
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_UserName.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_Password.Text) ||
                cmb_Gender.SelectedIndex <= 0)
            {
                MessageBox.Show("Please fill all required fields (UserName, Email, Password, Gender).",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int deptId = GetSelectedDepartmentId();
            if (deptId == -1)
            {
                MessageBox.Show("Please select a department.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataAccess da = new DataAccess();

                string checkSql = "SELECT COUNT(*) FROM AuthenticationInfo WHERE Email = @Email";
                SqlParameter[] checkParams = { new SqlParameter("@Email", txt_Email.Text.Trim()) };
                DataTable dtCheck = da.ExecuteQueryTable(checkSql, checkParams);
                if (Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
                {
                    MessageBox.Show("This email is already registered.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int authStatus = cmb_Status.SelectedItem.ToString() == "Active" ? 1 : 0;

                string authSql = @"INSERT INTO AuthenticationInfo
                           (UserName, Email, PasswordHash, RoleId, Status)
                           VALUES (@UserName, @Email, @Pass, 3, @Status);
                           SELECT SCOPE_IDENTITY();";
                SqlParameter[] authParams = {
            new SqlParameter("@UserName", txt_UserName.Text.Trim()),
            new SqlParameter("@Email",    txt_Email.Text.Trim()),
            new SqlParameter("@Pass",     txt_Password.Text),
            new SqlParameter("@Status",   authStatus)
        };
                DataTable dtAuth = da.ExecuteQueryTable(authSql, authParams);
                int newUserId = Convert.ToInt32(dtAuth.Rows[0][0]);

                string studentSql = @"INSERT INTO StudentInfo
                              (UserId, Gender, Phone, Address, DepartmentId, Status)
                              VALUES (@UserId, @Gender, @Phone, @Address, @DeptId, @Status)";
                SqlParameter[] studentParams = {
            new SqlParameter("@UserId",  newUserId),
            new SqlParameter("@Gender",  cmb_Gender.SelectedItem.ToString()),
            new SqlParameter("@Phone",   txt_Phone.Text.Trim()),
            new SqlParameter("@Address", string.IsNullOrWhiteSpace(txt_Address.Text)
                               ? (object)DBNull.Value : txt_Address.Text.Trim()),
            new SqlParameter("@DeptId",  deptId),
            new SqlParameter("@Status",  cmb_Status.SelectedItem.ToString())
        };
                da.ExecuteDMLQuery(studentSql, studentParams);

                MessageBox.Show("Student added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadStudents("", "All");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Please select a student from the grid first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_UserName.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text))
            {
                MessageBox.Show("UserName and Email are required.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int deptId = GetSelectedDepartmentId();
            if (deptId == -1)
            {
                MessageBox.Show("Please select a department.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataAccess da = new DataAccess();

                int authStatus = cmb_Status.SelectedItem.ToString() == "Active" ? 1 : 0;

                string authSql = "UPDATE AuthenticationInfo SET UserName = @UserName, Email = @Email, Status = @Status";
                if (!string.IsNullOrWhiteSpace(txt_Password.Text))
                    authSql += ", PasswordHash = @Pass";
                authSql += " WHERE UserId = @UserId";

                List<SqlParameter> authParams = new List<SqlParameter>();
                authParams.Add(new SqlParameter("@UserName", txt_UserName.Text.Trim()));
                authParams.Add(new SqlParameter("@Email", txt_Email.Text.Trim()));
                authParams.Add(new SqlParameter("@Status", authStatus));
                authParams.Add(new SqlParameter("@UserId", selectedUserId));
                if (!string.IsNullOrWhiteSpace(txt_Password.Text))
                    authParams.Add(new SqlParameter("@Pass", txt_Password.Text));

                da.ExecuteDMLQuery(authSql, authParams.ToArray());

                string studentSql = @"UPDATE StudentInfo SET
                              Gender = @Gender, Phone = @Phone, Address = @Address,
                              DepartmentId = @DeptId, Status = @Status
                              WHERE StudentId = @StudentId";
                SqlParameter[] studentParams = {
            new SqlParameter("@Gender",    cmb_Gender.SelectedItem.ToString()),
            new SqlParameter("@Phone",     txt_Phone.Text.Trim()),
            new SqlParameter("@Address",   string.IsNullOrWhiteSpace(txt_Address.Text)
                               ? (object)DBNull.Value : txt_Address.Text.Trim()),
            new SqlParameter("@DeptId",    deptId),
            new SqlParameter("@Status",    cmb_Status.SelectedItem.ToString()),
            new SqlParameter("@StudentId", selectedStudentId)
        };
                da.ExecuteDMLQuery(studentSql, studentParams);

                MessageBox.Show("Student updated successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadStudents("", cmb_StatusFilter.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Please select a student from the grid first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                DataAccess da = new DataAccess();

                // Delete from StudentInfo first
                string deleteStudent = "DELETE FROM StudentInfo WHERE StudentId = @StudentId";
                da.ExecuteDMLQuery(deleteStudent,
                    new SqlParameter[] { new SqlParameter("@StudentId", selectedStudentId) });

                // Delete from AuthenticationInfo
                string deleteAuth = "DELETE FROM AuthenticationInfo WHERE UserId = @UserId";
                da.ExecuteDMLQuery(deleteAuth,
                    new SqlParameter[] { new SqlParameter("@UserId", selectedUserId) });

                MessageBox.Show("Student deleted successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadStudents("", cmb_StatusFilter.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadStudents("", cmb_StatusFilter.SelectedItem.ToString());
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadStudents(txt_Search.Text.Trim(), "All");
        }

        private void btn_FilterStatus_Click(object sender, EventArgs e)
        {
            LoadStudents("", cmb_StatusFilter.SelectedItem.ToString());
        }

        private void dgv_Students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Students.Rows[e.RowIndex];
                selectedStudentId = Convert.ToInt32(row.Cells["StudentId"].Value);

                txt_UserName.Text = row.Cells["UserName"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_Phone.Text = row.Cells["Phone"].Value.ToString();
                cmb_Gender.SelectedItem = row.Cells["Gender"].Value.ToString();
                cmb_Status.SelectedItem = row.Cells["Status"].Value.ToString();

                // Set department (from DB we need departmentId)
                // We'll load full details
                LoadStudentDetails(selectedStudentId);
            }
        }

        private void LoadStudentDetails(int studentId)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT a.UserId, a.PasswordHash, s.Address, s.DepartmentId
                               FROM StudentInfo s
                               INNER JOIN AuthenticationInfo a ON s.UserId = a.UserId
                               WHERE s.StudentId = @StudentId";
                SqlParameter[] param = { new SqlParameter("@StudentId", studentId) };
                DataTable dt = da.ExecuteQueryTable(sql, param);
                if (dt.Rows.Count > 0)
                {
                    selectedUserId = Convert.ToInt32(dt.Rows[0]["UserId"]);
                    txt_Password.Text = dt.Rows[0]["PasswordHash"].ToString();
                    txt_Address.Text = dt.Rows[0]["Address"] != DBNull.Value
                                       ? dt.Rows[0]["Address"].ToString()
                                       : "";
                    int deptId = Convert.ToInt32(dt.Rows[0]["DepartmentId"]);
                    SetSelectedDepartment(deptId);
                }
            }
            catch { }
        }
    }
}