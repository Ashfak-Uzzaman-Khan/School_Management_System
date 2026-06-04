using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_DepartmentManager : UserControl
    {
        private int selectedDepartmentId = 0;

        public UC_DepartmentManager()
        {
            InitializeComponent();
        }

        private void UC_DepartmentManager_Load(object sender, EventArgs e)
        {
            ConfigureGrids();
            LoadAllDepartments();
        }

        private void ConfigureGrids()
        {
            // Departments grid
            dgv_Departments.Columns.Clear();
            dgv_Departments.Columns.Add("DepartmentId", "Department ID");
            dgv_Departments.Columns.Add("DepartmentName", "Department Name");

            dgv_Departments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Departments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Departments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Departments.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Departments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Departments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Departments.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_Departments.Columns["DepartmentId"].Width = 120;
            dgv_Departments.Columns["DepartmentId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Departments.Columns["DepartmentName"].Width = 580;

            // Students grid
            dgv_Students.Columns.Clear();
            dgv_Students.Columns.Add("StudentId", "Student ID");
            dgv_Students.Columns.Add("UserName", "Student Name");
            dgv_Students.Columns.Add("Email", "Email");
            dgv_Students.Columns.Add("Phone", "Phone");
            dgv_Students.Columns.Add("Gender", "Gender");
            dgv_Students.Columns.Add("Status", "Status");

            dgv_Students.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Students.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Students.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Students.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Students.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Students.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Students.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_Students.Columns["StudentId"].Width = 80;
            dgv_Students.Columns["StudentId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Students.Columns["UserName"].Width = 160;
            dgv_Students.Columns["Email"].Width = 200;
            dgv_Students.Columns["Phone"].Width = 120;
            dgv_Students.Columns["Gender"].Width = 80;
            dgv_Students.Columns["Status"].Width = 80;
        }

        private void LoadAllDepartments()
        {
            LoadDepartments("");
        }
        private void LoadDepartments(string searchTerm)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = "SELECT DepartmentId, DepartmentName FROM Departments";

                if (!string.IsNullOrWhiteSpace(searchTerm))
                    sql += " WHERE DepartmentName LIKE @Search";
                sql += " ORDER BY DepartmentName";

                SqlParameter[] parameters = new SqlParameter[0];   // ← empty array instead of null
                if (!string.IsNullOrWhiteSpace(searchTerm))
                    parameters = new SqlParameter[] { new SqlParameter("@Search", "%" + searchTerm + "%") };

                DataTable dt = da.ExecuteQueryTable(sql, parameters);
                dgv_Departments.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgv_Departments.Rows.Add(row["DepartmentId"], row["DepartmentName"]);
                }

                // Clear students grid
                dgv_Students.Rows.Clear();
                selectedDepartmentId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudentsByDepartment(int departmentId)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT s.StudentId, a.UserName, a.Email, s.Phone, s.Gender, s.Status
                               FROM StudentInfo s
                               INNER JOIN AuthenticationInfo a ON s.UserId = a.UserId
                               WHERE s.DepartmentId = @DepartmentId
                               ORDER BY a.UserName";

                SqlParameter[] parameters = { new SqlParameter("@DepartmentId", departmentId) };
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadDepartments(txt_Search.Text.Trim());
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            LoadAllDepartments();
        }

        private void dgv_Departments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Departments.Rows[e.RowIndex];
                selectedDepartmentId = Convert.ToInt32(row.Cells["DepartmentId"].Value);

                // Update the title label with the department name
                lbl_studentsTitle.Text = $"Students in {row.Cells["DepartmentName"].Value}:";

                LoadStudentsByDepartment(selectedDepartmentId);
            }
        }
    }
}