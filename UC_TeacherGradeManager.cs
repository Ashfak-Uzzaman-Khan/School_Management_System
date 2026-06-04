using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_TeacherGradeManager : UserControl
    {
        public int TeacherUserId { get; set; }
        private int teacherId = 0;
        private int selectedStudentId = 0;
        private int selectedCourseId = 0;
        private int selectedGradeId = 0;   // 0 = new grade

        private class GradeItem
        {
            public string Letter { get; set; }
            public decimal Point { get; set; }
            public string Display => $"{Letter} ({Point:0.00})";
            public override string ToString() => Display;
        }

        public UC_TeacherGradeManager()
        {
            InitializeComponent();
        }

        private void UC_TeacherGradeManager_Load(object sender, EventArgs e)
        {
            LoadGradeCombo();
            if (TeacherUserId > 0)
            {
                LoadTeacherId();
                ConfigureGrid();
                LoadGrades();
            }
            else
            {
                MessageBox.Show("Teacher user ID not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGradeCombo()
        {
            var grades = new List<GradeItem>
            {
                new GradeItem { Letter = "A+", Point = 4.00m },
                new GradeItem { Letter = "A",  Point = 3.75m },
                new GradeItem { Letter = "A-", Point = 3.50m },
                new GradeItem { Letter = "B+", Point = 3.25m },
                new GradeItem { Letter = "B",  Point = 3.00m },
                new GradeItem { Letter = "B-", Point = 2.75m },
                new GradeItem { Letter = "C+", Point = 2.50m },
                new GradeItem { Letter = "C",  Point = 2.25m },
                new GradeItem { Letter = "C-", Point = 2.00m },
                new GradeItem { Letter = "D",  Point = 1.75m },
                new GradeItem { Letter = "F",  Point = 0.00m }
            };
            cmb_Grade.DataSource = grades;
            cmb_Grade.DisplayMember = "Display";
            cmb_Grade.ValueMember = "Point";
        }

        private void LoadTeacherId()
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = "SELECT TeacherId FROM TeacherInfo WHERE UserId = @UserId";
                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@UserId", TeacherUserId) });
                if (dt.Rows.Count > 0)
                    teacherId = Convert.ToInt32(dt.Rows[0]["TeacherId"]);
                else
                    MessageBox.Show("Teacher record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGrid()
        {
            dgv_Grades.Columns.Clear();
            dgv_Grades.Columns.Add("GradeId", "GradeId");
            dgv_Grades.Columns.Add("StudentId", "StudentId");
            dgv_Grades.Columns.Add("CourseId", "CourseId");
            dgv_Grades.Columns.Add("CourseName", "Course Name");
            dgv_Grades.Columns.Add("StudentName", "Student Name");
            dgv_Grades.Columns.Add("Grade", "Grade");
            dgv_Grades.Columns.Add("GradePoint", "Grade Point");

            dgv_Grades.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Grades.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Grades.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Grades.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Grades.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Grades.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Grades.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_Grades.Columns["GradeId"].Visible = false;
            dgv_Grades.Columns["StudentId"].Visible = false;
            dgv_Grades.Columns["CourseId"].Visible = false;
            dgv_Grades.Columns["CourseName"].Width = 180;
            dgv_Grades.Columns["StudentName"].Width = 180;
            dgv_Grades.Columns["Grade"].Width = 100;
            dgv_Grades.Columns["GradePoint"].Width = 100;
        }

        private void LoadGrades(string searchTerm = "")
        {
            if (teacherId == 0) return;

            try
            {
                DataAccess da = new DataAccess();
                string sql = @"
                    SELECT g.GradeId, g.StudentId, g.CourseId,
                           c.CourseName, au.UserName AS StudentName,
                           g.Grade, g.GradePoint
                    FROM Grade g
                    INNER JOIN StudentInfo s ON g.StudentId = s.StudentId
                    INNER JOIN AuthenticationInfo au ON s.UserId = au.UserId
                    INNER JOIN CourseInfo c ON g.CourseId = c.CourseId
                    WHERE g.TeacherId = @TeacherId";

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    sql += @" AND (c.CourseName LIKE @Search OR au.UserName LIKE @Search)";
                }

                sql += " ORDER BY c.CourseName, au.UserName";

                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@TeacherId", teacherId));
                if (!string.IsNullOrWhiteSpace(searchTerm))
                    paramList.Add(new SqlParameter("@Search", "%" + searchTerm + "%"));

                DataTable dt = da.ExecuteQueryTable(sql, paramList.ToArray());
                dgv_Grades.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgv_Grades.Rows.Add(
                        row["GradeId"],
                        row["StudentId"],
                        row["CourseId"],
                        row["CourseName"],
                        row["StudentName"],
                        row["Grade"],
                        row["GradePoint"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grades: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearEditPanel()
        {
            selectedGradeId = 0;
            selectedStudentId = 0;
            selectedCourseId = 0;
            cmb_Grade.SelectedIndex = 0;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadGrades(txt_Search.Text.Trim());
        }

        private void dgv_Grades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Grades.Rows[e.RowIndex];
                selectedGradeId = Convert.ToInt32(row.Cells["GradeId"].Value);
                selectedStudentId = Convert.ToInt32(row.Cells["StudentId"].Value);
                selectedCourseId = Convert.ToInt32(row.Cells["CourseId"].Value);
                // Set grade combo
                string gradeLetter = row.Cells["Grade"].Value.ToString();
                foreach (GradeItem item in cmb_Grade.Items)
                {
                    if (item.Letter == gradeLetter)
                    {
                        cmb_Grade.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0 || selectedCourseId == 0)
            {
                MessageBox.Show("Please select a student from the grid first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GradeItem gradeItem = cmb_Grade.SelectedItem as GradeItem;
            if (gradeItem == null) return;

            try
            {
                DataAccess da = new DataAccess();

                if (selectedGradeId > 0)
                {
                    // Update existing
                    string sql = "UPDATE Grade SET Grade = @Grade, GradePoint = @Point WHERE GradeId = @Id";
                    da.ExecuteDMLQuery(sql, new SqlParameter[]
                    {
                        new SqlParameter("@Grade", gradeItem.Letter),
                        new SqlParameter("@Point", gradeItem.Point),
                        new SqlParameter("@Id", selectedGradeId)
                    });
                }
                else
                {
                    // Insert new – student/course pair not yet graded
                    string sql = @"INSERT INTO Grade (StudentId, TeacherId, CourseId, Grade, GradePoint)
                                   VALUES (@StudentId, @TeacherId, @CourseId, @Grade, @Point)";
                    da.ExecuteDMLQuery(sql, new SqlParameter[]
                    {
                        new SqlParameter("@StudentId", selectedStudentId),
                        new SqlParameter("@TeacherId", teacherId),
                        new SqlParameter("@CourseId", selectedCourseId),
                        new SqlParameter("@Grade", gradeItem.Letter),
                        new SqlParameter("@Point", gradeItem.Point)
                    });
                }

                MessageBox.Show("Grade saved.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearEditPanel();
                LoadGrades(txt_Search.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearEditPanel();
            LoadGrades(txt_Search.Text.Trim());
        }
    }
}