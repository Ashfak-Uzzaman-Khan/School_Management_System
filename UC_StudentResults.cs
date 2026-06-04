using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_StudentResults : UserControl
    {
        public int StudentUserId { get; set; }
        private int studentId = 0;

        public UC_StudentResults()
        {
            InitializeComponent();
        }

        private void UC_StudentResults_Load(object sender, EventArgs e)
        {
            if (StudentUserId > 0)
            {
                LoadStudentId();
                ConfigureGrid();
                LoadResults();
            }
            else
            {
                MessageBox.Show("Student user ID not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudentId()
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = "SELECT StudentId FROM StudentInfo WHERE UserId = @UserId";
                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@UserId", StudentUserId) });
                if (dt.Rows.Count > 0)
                    studentId = Convert.ToInt32(dt.Rows[0]["StudentId"]);
                else
                    MessageBox.Show("Student record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGrid()
        {
            dgv_Results.Columns.Clear();
            dgv_Results.Columns.Add("CourseName", "Course Name");
            dgv_Results.Columns.Add("Grade", "Grade");
            dgv_Results.Columns.Add("GradePoint", "Grade Point");

            dgv_Results.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Results.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Results.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Results.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Results.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Results.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Results.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_Results.Columns["CourseName"].Width = 300;
            dgv_Results.Columns["Grade"].Width = 150;
            dgv_Results.Columns["GradePoint"].Width = 150;
        }

        private void LoadResults(string searchTerm = "")
        {
            if (studentId == 0) return;

            try
            {
                DataAccess da = new DataAccess();
                string sql = @"
                    SELECT c.CourseName, g.Grade, g.GradePoint
                    FROM Grade g
                    INNER JOIN CourseInfo c ON g.CourseId = c.CourseId
                    WHERE g.StudentId = @StudentId";

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    sql += " AND c.CourseName LIKE @Search";
                }

                sql += " ORDER BY c.CourseName";

                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@StudentId", studentId));
                if (!string.IsNullOrWhiteSpace(searchTerm))
                    paramList.Add(new SqlParameter("@Search", "%" + searchTerm + "%"));

                DataTable dt = da.ExecuteQueryTable(sql, paramList.ToArray());
                dgv_Results.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgv_Results.Rows.Add(
                        row["CourseName"],
                        row["Grade"],
                        row["GradePoint"]
                    );
                }

                UpdateCGPA();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading results: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCGPA()
        {
            if (studentId == 0)
            {
                lbl_cgpa.Text = "0.00";
                return;
            }

            try
            {
                DataAccess da = new DataAccess();
                // CGPA = Average of grade points (each course is 3 credits)
                string sql = @"
                    SELECT ISNULL(AVG(CAST(GradePoint AS decimal(5,2))), 0) AS CGPA
                    FROM Grade
                    WHERE StudentId = @StudentId";

                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@StudentId", studentId) });

                if (dt.Rows.Count > 0)
                {
                    decimal cgpa = Convert.ToDecimal(dt.Rows[0]["CGPA"]);
                    lbl_cgpa.Text = cgpa.ToString("0.00");
                }
            }
            catch { lbl_cgpa.Text = "Err"; }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadResults(txt_Search.Text.Trim());
        }
    }
}