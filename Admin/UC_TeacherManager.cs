using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_TeacherManager : UserControl
    {
        private int selectedTeacherId = 0;
        private int selectedUserId = 0;

        public UC_TeacherManager()
        {
            InitializeComponent();
        }

        private void UC_TeacherManager_Load(object sender, EventArgs e)
        {
            cmb_Gender.Items.Clear();
            cmb_Gender.Items.Add("-- Select --");
            cmb_Gender.Items.Add("Male");
            cmb_Gender.Items.Add("Female");
            cmb_Gender.Items.Add("Other");
            cmb_Gender.SelectedIndex = 0;

            cmb_StatusFilter.Items.Clear();
            cmb_StatusFilter.Items.Add("All");
            cmb_StatusFilter.Items.Add("Active");
            cmb_StatusFilter.Items.Add("Inactive");
            cmb_StatusFilter.Items.Add("Pending");
            cmb_StatusFilter.SelectedIndex = 0;

            cmb_Status.Items.Clear();
            cmb_Status.Items.Add("Active");
            cmb_Status.Items.Add("Inactive");
            cmb_Status.Items.Add("Pending");
            cmb_Status.SelectedIndex = 0;

            ConfigureGrid();
            LoadTeachers("", "All");
        }

        private void ConfigureGrid()
        {
            dgv_Teachers.Columns.Clear();
            dgv_Teachers.Columns.Add("TeacherId", "TeacherId");
            dgv_Teachers.Columns.Add("UserName", "User Name");
            dgv_Teachers.Columns.Add("Email", "Email");
            dgv_Teachers.Columns.Add("Phone", "Phone");
            dgv_Teachers.Columns.Add("Gender", "Gender");
            dgv_Teachers.Columns.Add("Experience", "Experience");
            dgv_Teachers.Columns.Add("Salary", "Salary");
            dgv_Teachers.Columns.Add("Status", "Status");

            dgv_Teachers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Teachers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Teachers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Teachers.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Teachers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Teachers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Teachers.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_Teachers.Columns["TeacherId"].Visible = false;
            dgv_Teachers.Columns["Experience"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Teachers.Columns["Salary"].DefaultCellStyle.Format = "N2";
        }

        private void LoadTeachers(string searchTerm, string statusFilter)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT t.TeacherId, a.UserName, a.Email, t.Phone, t.Gender,
                               t.ExperienceYears, t.Salary, t.Status
                               FROM TeacherInfo t
                               INNER JOIN AuthenticationInfo a ON t.UserId = a.UserId
                               WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(searchTerm))
                    sql += " AND (a.UserName LIKE @Search OR a.Email LIKE @Search)";

                if (statusFilter != "All")
                    sql += " AND t.Status = @Status";

                sql += " ORDER BY a.UserName";

                List<SqlParameter> paramList = new List<SqlParameter>();
                if (!string.IsNullOrWhiteSpace(searchTerm))
                    paramList.Add(new SqlParameter("@Search", "%" + searchTerm + "%"));
                if (statusFilter != "All")
                    paramList.Add(new SqlParameter("@Status", statusFilter));

                DataTable dt = da.ExecuteQueryTable(sql, paramList.ToArray());
                dgv_Teachers.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgv_Teachers.Rows.Add(row["TeacherId"], row["UserName"], row["Email"],
                        row["Phone"], row["Gender"], row["ExperienceYears"],
                        row["Salary"], row["Status"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teachers: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            selectedTeacherId = 0;
            selectedUserId = 0;
            txt_UserName.Clear();
            txt_Email.Clear();
            txt_Password.Clear();
            txt_Phone.Clear();
            cmb_Gender.SelectedIndex = 0;
            txt_Address.Clear();
            num_Experience.Value = 0;
            txt_Salary.Clear();
            cmb_Status.SelectedIndex = 0;
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

            string phone = txt_Phone.Text.Trim();
            if (phone.Length != 11 || !phone.StartsWith("01"))
            {
                MessageBox.Show("Phone number must be 11 digits and start with 01.",
                    "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                           VALUES (@UserName, @Email, @Pass, 2, @Status);
                           SELECT SCOPE_IDENTITY();";
                SqlParameter[] authParams = {
            new SqlParameter("@UserName", txt_UserName.Text.Trim()),
            new SqlParameter("@Email",    txt_Email.Text.Trim()),
            new SqlParameter("@Pass",     txt_Password.Text),
            new SqlParameter("@Status",   authStatus)
        };
                DataTable dtAuth = da.ExecuteQueryTable(authSql, authParams);
                int newUserId = Convert.ToInt32(dtAuth.Rows[0][0]);

                string teacherSql = @"INSERT INTO TeacherInfo
                              (UserId, Gender, Phone, Address, ExperienceYears, Salary, Status)
                              VALUES (@UserId, @Gender, @Phone, @Address, @Exp, @Salary, @Status)";
                SqlParameter[] teacherParams = {
            new SqlParameter("@UserId",  newUserId),
            new SqlParameter("@Gender",  cmb_Gender.SelectedItem.ToString()),
            new SqlParameter("@Phone",   phone),
            new SqlParameter("@Address", string.IsNullOrWhiteSpace(txt_Address.Text) ? (object)DBNull.Value : txt_Address.Text.Trim()),
            new SqlParameter("@Exp",     (int)num_Experience.Value),
            new SqlParameter("@Salary",  string.IsNullOrWhiteSpace(txt_Salary.Text) ? 0 : Convert.ToDecimal(txt_Salary.Text)),
            new SqlParameter("@Status",  cmb_Status.SelectedItem.ToString())
        };
                da.ExecuteDMLQuery(teacherSql, teacherParams);

                MessageBox.Show("Teacher added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadTeachers("", "All");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (selectedTeacherId == 0)
            {
                MessageBox.Show("Please select a teacher from the grid first.",
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

                string teacherSql = @"UPDATE TeacherInfo SET
                              Gender = @Gender, Phone = @Phone, Address = @Address,
                              ExperienceYears = @Exp, Salary = @Salary, Status = @Status
                              WHERE TeacherId = @TeacherId";
                SqlParameter[] teacherParams = {
            new SqlParameter("@Gender",    cmb_Gender.SelectedItem.ToString()),
            new SqlParameter("@Phone",     txt_Phone.Text.Trim()),
            new SqlParameter("@Address",   string.IsNullOrWhiteSpace(txt_Address.Text) ? (object)DBNull.Value : txt_Address.Text.Trim()),
            new SqlParameter("@Exp",       (int)num_Experience.Value),
            new SqlParameter("@Salary",    string.IsNullOrWhiteSpace(txt_Salary.Text) ? 0 : Convert.ToDecimal(txt_Salary.Text)),
            new SqlParameter("@Status",    cmb_Status.SelectedItem.ToString()),
            new SqlParameter("@TeacherId", selectedTeacherId)
        };
                da.ExecuteDMLQuery(teacherSql, teacherParams);

                MessageBox.Show("Teacher updated successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadTeachers("", cmb_StatusFilter.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedTeacherId == 0)
            {
                MessageBox.Show("Please select a teacher from the grid first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this teacher?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                DataAccess da = new DataAccess();

                string deleteTeacher = "DELETE FROM TeacherInfo WHERE TeacherId = @TeacherId";
                da.ExecuteDMLQuery(deleteTeacher,
                    new SqlParameter[] { new SqlParameter("@TeacherId", selectedTeacherId) });

                string deleteAuth = "DELETE FROM AuthenticationInfo WHERE UserId = @UserId";
                da.ExecuteDMLQuery(deleteAuth,
                    new SqlParameter[] { new SqlParameter("@UserId", selectedUserId) });

                MessageBox.Show("Teacher deleted successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadTeachers("", cmb_StatusFilter.SelectedItem.ToString());
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
            LoadTeachers("", cmb_StatusFilter.SelectedItem.ToString());
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadTeachers(txt_Search.Text.Trim(), "All");
        }

        private void btn_FilterStatus_Click(object sender, EventArgs e)
        {
            LoadTeachers("", cmb_StatusFilter.SelectedItem.ToString());
        }

        private void dgv_Teachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Teachers.Rows[e.RowIndex];
                selectedTeacherId = Convert.ToInt32(row.Cells["TeacherId"].Value);

                txt_UserName.Text = row.Cells["UserName"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_Phone.Text = row.Cells["Phone"].Value.ToString();
                cmb_Gender.SelectedItem = row.Cells["Gender"].Value.ToString();
                num_Experience.Value = Convert.ToDecimal(row.Cells["Experience"].Value);
                txt_Salary.Text = Convert.ToDecimal(row.Cells["Salary"].Value).ToString("0.00");
                cmb_Status.SelectedItem = row.Cells["Status"].Value.ToString();

                LoadTeacherDetails(selectedTeacherId);
            }
        }

        private void LoadTeacherDetails(int teacherId)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT a.UserId, a.PasswordHash, t.Address
                               FROM TeacherInfo t
                               INNER JOIN AuthenticationInfo a ON t.UserId = a.UserId
                               WHERE t.TeacherId = @TeacherId";
                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@TeacherId", teacherId) });

                if (dt.Rows.Count > 0)
                {
                    selectedUserId = Convert.ToInt32(dt.Rows[0]["UserId"]);
                    txt_Password.Text = dt.Rows[0]["PasswordHash"] != DBNull.Value
                                        ? dt.Rows[0]["PasswordHash"].ToString() : "";
                    txt_Address.Text = dt.Rows[0]["Address"] != DBNull.Value
                                       ? dt.Rows[0]["Address"].ToString() : "";
                }
            }
            catch { }
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

            TextBox txt = (TextBox)sender;
            if (char.IsDigit(e.KeyChar) && txt.Text.Replace("-", "").Length >= 11)
                e.Handled = true;
        }
    }
}