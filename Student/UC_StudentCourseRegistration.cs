using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_StudentCourseRegistration : UserControl
    {
        // Set by StudentDashboard before loading
        public int StudentUserId { get; set; }

        // Will be resolved on Load
        private int studentId = 0;
        private int selectedCourseId = 0;

        public UC_StudentCourseRegistration()
        {
            InitializeComponent();
        }

        private void UC_StudentCourseRegistration_Load(object sender, EventArgs e)
        {
            if (StudentUserId <= 0)
            {
                MessageBox.Show("Student user ID not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Resolve StudentId from StudentUserId
            try
            {
                DataAccess da = new DataAccess();
                string sql = "SELECT StudentId FROM StudentInfo WHERE UserId = @UserId";
                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@UserId", StudentUserId) });
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Student record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                studentId = Convert.ToInt32(dt.Rows[0]["StudentId"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load student info: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConfigureGrid();
            LoadCourses("");
        }

        private void ConfigureGrid()
        {
            dgv_Courses.Columns.Clear();
            dgv_Courses.Columns.Add("CourseId", "CourseId");
            dgv_Courses.Columns.Add("CourseName", "Course Name");
            dgv_Courses.Columns.Add("DayOfWeek", "Day");
            dgv_Courses.Columns.Add("Time", "Time");
            dgv_Courses.Columns.Add("CourseFee", "Fee");
            dgv_Courses.Columns.Add("TeacherName", "Teacher");

            // Style exactly as all your grids
            dgv_Courses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Courses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Courses.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Courses.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Courses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Courses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Courses.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_Courses.Columns["CourseId"].Visible = false;
            dgv_Courses.Columns["CourseFee"].DefaultCellStyle.Format = "N2";
        }

        private void LoadCourses(string searchTerm)
        {
            try
            {
                DataAccess da = new DataAccess();

                // Exclude courses the student is already registered for
                string sql = @"SELECT c.CourseId, c.CourseName, c.DayOfWeek,
                               CONVERT(varchar(5), c.StartTime, 108) + ' - ' + CONVERT(varchar(5), c.EndTime, 108) AS TimeRange,
                               c.CourseFee, ISNULL(a.UserName, 'N/A') AS TeacherName
                               FROM CourseInfo c
                               LEFT JOIN TeacherInfo t ON c.TeacherId = t.TeacherId
                               LEFT JOIN AuthenticationInfo a ON t.UserId = a.UserId
                               WHERE c.CourseId NOT IN (
                                   SELECT CourseId FROM StudentCourseRegistration WHERE StudentId = @StudentId
                               )";

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    sql += " AND c.CourseName LIKE @Search";
                }

                sql += " ORDER BY c.DayOfWeek, c.StartTime";

                SqlParameter[] parameters;
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@StudentId", studentId),
                        new SqlParameter("@Search", "%" + searchTerm + "%")
                    };
                }
                else
                {
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@StudentId", studentId)
                    };
                }

                DataTable dt = da.ExecuteQueryTable(sql, parameters);
                dgv_Courses.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgv_Courses.Rows.Add(
                        row["CourseId"],
                        row["CourseName"],
                        row["DayOfWeek"],
                        row["TimeRange"],
                        row["CourseFee"],
                        row["TeacherName"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Courses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedCourseId = Convert.ToInt32(dgv_Courses.Rows[e.RowIndex].Cells["CourseId"].Value);
            }
        }

        private bool IsTimeClash(int courseId)
        {
            // Check if this course overlaps with any already registered course
            try
            {
                DataAccess da = new DataAccess();
                // Get day and time of the selected course
                string getCourseSql = "SELECT DayOfWeek, StartTime, EndTime FROM CourseInfo WHERE CourseId = @CourseId";
                DataTable dtCourse = da.ExecuteQueryTable(getCourseSql,
                    new SqlParameter[] { new SqlParameter("@CourseId", courseId) });
                if (dtCourse.Rows.Count == 0) return true; // safety

                string day = dtCourse.Rows[0]["DayOfWeek"].ToString();
                TimeSpan start = (TimeSpan)dtCourse.Rows[0]["StartTime"];
                TimeSpan end = (TimeSpan)dtCourse.Rows[0]["EndTime"];

                // Find if any registered course clashes
                string clashSql = @"SELECT COUNT(*) FROM StudentCourseRegistration r
                                    INNER JOIN CourseInfo c ON r.CourseId = c.CourseId
                                    WHERE r.StudentId = @StudentId
                                    AND c.DayOfWeek = @Day
                                    AND c.StartTime < @EndTime
                                    AND c.EndTime > @StartTime";

                SqlParameter[] parameters = {
                    new SqlParameter("@StudentId", studentId),
                    new SqlParameter("@Day", day),
                    new SqlParameter("@EndTime", end),
                    new SqlParameter("@StartTime", start)   // careful: parameter order: start < endTime check
                };
                // Note: we already exclude already registered courses from the grid, so we are checking only against existing registrations (not the same course).

                DataTable dtClash = da.ExecuteQueryTable(clashSql, parameters);
                return Convert.ToInt32(dtClash.Rows[0][0]) > 0;
            }
            catch
            {
                return true; // fail safe: assume clash
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == 0)
            {
                MessageBox.Show("Please select a course from the list.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if already registered (should not happen because we exclude them, but double-check)
            try
            {
                DataAccess da = new DataAccess();
                string checkSql = "SELECT COUNT(*) FROM StudentCourseRegistration WHERE StudentId = @StudentId AND CourseId = @CourseId";
                DataTable dtCheck = da.ExecuteQueryTable(checkSql,
                    new SqlParameter[] { new SqlParameter("@StudentId", studentId),
                                         new SqlParameter("@CourseId", selectedCourseId) });
                if (Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
                {
                    MessageBox.Show("You are already registered for this course.",
                        "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check time clash with existing registrations
            if (IsTimeClash(selectedCourseId))
            {
                MessageBox.Show("This course overlaps with another course you are already registered for on the same day.\nPlease choose a different time slot.",
                    "Time Clash", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm registration
            DialogResult result = MessageBox.Show("Are you sure you want to register for this course?",
                "Confirm Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                DataAccess da = new DataAccess();
                string insertSql = "INSERT INTO StudentCourseRegistration (StudentId, CourseId) VALUES (@StudentId, @CourseId)";
                SqlParameter[] parameters = {
                    new SqlParameter("@StudentId", studentId),
                    new SqlParameter("@CourseId", selectedCourseId)
                };
                da.ExecuteDMLQuery(insertSql, parameters);

                MessageBox.Show("Registration successful! The course will appear in your schedule.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the list to remove the now-registered course
                selectedCourseId = 0;
                LoadCourses(txt_Search.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            selectedCourseId = 0;
            LoadCourses("");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadCourses(txt_Search.Text.Trim());
        }
    }
}