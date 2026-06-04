using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_CourseManager : UserControl
    {
        private int selectedCourseId = 0;

        public UC_CourseManager()
        {
            InitializeComponent();
        }

        private void UC_CourseManager_Load(object sender, EventArgs e)
        {
            // Days of week
            cmb_DayOfWeek.Items.Clear();
            cmb_DayOfWeek.Items.Add("-- Select --");
            cmb_DayOfWeek.Items.Add("Saturday");
            cmb_DayOfWeek.Items.Add("Sunday");
            cmb_DayOfWeek.Items.Add("Monday");
            cmb_DayOfWeek.Items.Add("Tuesday");
            cmb_DayOfWeek.Items.Add("Wednesday");
            cmb_DayOfWeek.Items.Add("Thursday");
            cmb_DayOfWeek.Items.Add("Friday");
            cmb_DayOfWeek.SelectedIndex = 0;

            LoadTeachers();
            ConfigureGrids();
            LoadAllCourses();
        }

        private void LoadTeachers()
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT t.TeacherId, a.UserName 
                               FROM TeacherInfo t
                               INNER JOIN AuthenticationInfo a ON t.UserId = a.UserId
                               WHERE t.Status = 'Active' 
                               ORDER BY a.UserName";
                DataTable dt = da.ExecuteQueryTable(sql);
                cmb_Teacher.Items.Clear();
                cmb_Teacher.Items.Add(new ComboBoxItem("-- None --", -1));
                foreach (DataRow row in dt.Rows)
                {
                    cmb_Teacher.Items.Add(new ComboBoxItem(
                        row["UserName"].ToString(),
                        Convert.ToInt32(row["TeacherId"])
                    ));
                }
                cmb_Teacher.SelectedIndex = 0;
            }
            catch { }
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public ComboBoxItem(string text, int value) { Text = text; Value = value; }
            public override string ToString() { return Text; }
        }

        private int GetSelectedTeacherId()
        {
            if (cmb_Teacher.SelectedIndex > 0 && cmb_Teacher.SelectedItem is ComboBoxItem item)
                return item.Value;
            return -1; // None
        }

        private void SetSelectedTeacher(int teacherId)
        {
            for (int i = 1; i < cmb_Teacher.Items.Count; i++)
            {
                if (cmb_Teacher.Items[i] is ComboBoxItem item && item.Value == teacherId)
                {
                    cmb_Teacher.SelectedIndex = i;
                    return;
                }
            }
            cmb_Teacher.SelectedIndex = 0;
        }

        private void ConfigureGrids()
        {
            // Courses grid
            dgv_Courses.Columns.Clear();
            dgv_Courses.Columns.Add("CourseId", "CourseId");
            dgv_Courses.Columns.Add("CourseName", "Course Name");
            dgv_Courses.Columns.Add("DayOfWeek", "Day");
            dgv_Courses.Columns.Add("StartTime", "Start");
            dgv_Courses.Columns.Add("EndTime", "End");
            dgv_Courses.Columns.Add("CourseFee", "Fee");
            dgv_Courses.Columns.Add("TeacherName", "Teacher");

            dgv_Courses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Courses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Courses.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Courses.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Courses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Courses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Courses.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dgv_Courses.Columns["CourseId"].Visible = false;

            // Students grid
            dgv_Students.Columns.Clear();
            dgv_Students.Columns.Add("StudentName", "Student Name");
            dgv_Students.Columns.Add("Email", "Email");
            dgv_Students.Columns.Add("Phone", "Phone");
            dgv_Students.Columns.Add("Gender", "Gender");
            dgv_Students.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Students.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Students.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Students.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Students.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Students.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Students.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
        }

        private void LoadAllCourses() => LoadCoursesGrid("");

        private void LoadCoursesGrid(string searchTerm)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT c.CourseId, c.CourseName, c.DayOfWeek,
                               CONVERT(varchar(5), c.StartTime, 108) AS StartTime,
                               CONVERT(varchar(5), c.EndTime, 108) AS EndTime,
                               c.CourseFee, ISNULL(a.UserName, 'N/A') AS TeacherName
                               FROM CourseInfo c
                               LEFT JOIN TeacherInfo t ON c.TeacherId = t.TeacherId
                               LEFT JOIN AuthenticationInfo a ON t.UserId = a.UserId
                               WHERE 1=1";

                SqlParameter[] parameters;   // never null
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    sql += " AND (c.CourseName LIKE @Search OR CAST(c.CourseId AS varchar) LIKE @Search)";
                    parameters = new SqlParameter[] { new SqlParameter("@Search", "%" + searchTerm + "%") };
                }
                else
                {
                    parameters = new SqlParameter[0];   // EMPTY array, not null
                }

                sql += " ORDER BY c.CourseName";

                DataTable dt = da.ExecuteQueryTable(sql, parameters);
                dgv_Courses.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgv_Courses.Rows.Add(
                        row["CourseId"],
                        row["CourseName"],
                        row["DayOfWeek"],
                        row["StartTime"],
                        row["EndTime"],
                        row["CourseFee"],
                        row["TeacherName"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            selectedCourseId = 0;
            txt_CourseName.Clear();
            cmb_DayOfWeek.SelectedIndex = 0;
            dtp_StartTime.Value = DateTime.Today.AddHours(8);
            dtp_EndTime.Value = DateTime.Today.AddHours(9);
            txt_CourseFee.Clear();
            cmb_Teacher.SelectedIndex = 0;
            dgv_Students.Rows.Clear();
        }

        private bool IsTimeClash(string day, TimeSpan start, TimeSpan end, int excludeCourseId = 0)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT COUNT(*) FROM CourseInfo
                       WHERE DayOfWeek = @Day
                       AND StartTime IS NOT NULL AND EndTime IS NOT NULL
                       AND StartTime < @End
                       AND EndTime > @Start";

                if (excludeCourseId > 0)
                    sql += " AND CourseId <> @CourseId";

                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@Day", day));
                parameters.Add(new SqlParameter("@Start", start));
                parameters.Add(new SqlParameter("@End", end));
                if (excludeCourseId > 0)
                    parameters.Add(new SqlParameter("@CourseId", excludeCourseId));

                DataTable dt = da.ExecuteQueryTable(sql, parameters.ToArray());
                return Convert.ToInt32(dt.Rows[0][0]) > 0;
            }
            catch
            {
                return false;   // if query fails, allow the operation to avoid false positives
            }
        }

        // ────────────────────────────────────────────────────────
        //  REMOVED: IsTeacherAlreadyAssigned – no longer needed
        //  A teacher can teach multiple courses as long as there
        //  is no time clash on the same day.
        // ────────────────────────────────────────────────────────

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CourseName.Text) || cmb_DayOfWeek.SelectedIndex <= 0)
            {
                MessageBox.Show("Course name and day of week are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string day = cmb_DayOfWeek.SelectedItem.ToString();
            TimeSpan start = dtp_StartTime.Value.TimeOfDay;
            TimeSpan end = dtp_EndTime.Value.TimeOfDay;

            if (start >= end)
            {
                MessageBox.Show("Start time must be before end time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsTimeClash(day, start, end))
            {
                MessageBox.Show("This time slot conflicts with an existing course on the same day.", "Time Clash", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int teacherId = GetSelectedTeacherId();

            try
            {
                DataAccess da = new DataAccess();
                string sql = @"INSERT INTO CourseInfo (CourseName, TeacherId, DayOfWeek, StartTime, EndTime, CourseFee)
                               VALUES (@CourseName, @TeacherId, @DayOfWeek, @StartTime, @EndTime, @CourseFee)";

                SqlParameter[] parameters = {
                    new SqlParameter("@CourseName", txt_CourseName.Text.Trim()),
                    new SqlParameter("@TeacherId", teacherId > 0 ? (object)teacherId : DBNull.Value),
                    new SqlParameter("@DayOfWeek", day),
                    new SqlParameter("@StartTime", start),
                    new SqlParameter("@EndTime", end),
                    new SqlParameter("@CourseFee", string.IsNullOrWhiteSpace(txt_CourseFee.Text) ? 0 : Convert.ToDecimal(txt_CourseFee.Text))
                };

                da.ExecuteDMLQuery(sql, parameters);
                MessageBox.Show("Course added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadAllCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == 0)
            {
                MessageBox.Show("Please select a course from the grid first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_CourseName.Text) || cmb_DayOfWeek.SelectedIndex <= 0)
            {
                MessageBox.Show("Course name and day of week are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string day = cmb_DayOfWeek.SelectedItem.ToString();
            TimeSpan start = dtp_StartTime.Value.TimeOfDay;
            TimeSpan end = dtp_EndTime.Value.TimeOfDay;

            if (start >= end)
            {
                MessageBox.Show("Start time must be before end time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsTimeClash(day, start, end, selectedCourseId))
            {
                MessageBox.Show("This time slot conflicts with another course on the same day.", "Time Clash", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int teacherId = GetSelectedTeacherId();

            try
            {
                DataAccess da = new DataAccess();
                string sql = @"UPDATE CourseInfo SET
                               CourseName = @CourseName,
                               TeacherId = @TeacherId,
                               DayOfWeek = @DayOfWeek,
                               StartTime = @StartTime,
                               EndTime = @EndTime,
                               CourseFee = @CourseFee
                               WHERE CourseId = @CourseId";

                SqlParameter[] parameters = {
                    new SqlParameter("@CourseName", txt_CourseName.Text.Trim()),
                    new SqlParameter("@TeacherId", teacherId > 0 ? (object)teacherId : DBNull.Value),
                    new SqlParameter("@DayOfWeek", day),
                    new SqlParameter("@StartTime", start),
                    new SqlParameter("@EndTime", end),
                    new SqlParameter("@CourseFee", string.IsNullOrWhiteSpace(txt_CourseFee.Text) ? 0 : Convert.ToDecimal(txt_CourseFee.Text)),
                    new SqlParameter("@CourseId", selectedCourseId)
                };

                da.ExecuteDMLQuery(sql, parameters);
                MessageBox.Show("Course updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadAllCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == 0)
            {
                MessageBox.Show("Please select a course from the grid first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                DataAccess da = new DataAccess();
                da.ExecuteDMLQuery("DELETE FROM CourseInfo WHERE CourseId = @CourseId",
                    new SqlParameter[] { new SqlParameter("@CourseId", selectedCourseId) });
                MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadAllCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadAllCourses();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadCoursesGrid(txt_Search.Text.Trim());
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            LoadAllCourses();
        }

        private void dgv_Courses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Courses.Rows[e.RowIndex];
                selectedCourseId = Convert.ToInt32(row.Cells["CourseId"].Value);

                txt_CourseName.Text = row.Cells["CourseName"].Value.ToString();
                cmb_DayOfWeek.SelectedItem = row.Cells["DayOfWeek"].Value.ToString();

                if (TimeSpan.TryParse(row.Cells["StartTime"].Value.ToString(), out TimeSpan start))
                    dtp_StartTime.Value = DateTime.Today.Add(start);
                if (TimeSpan.TryParse(row.Cells["EndTime"].Value.ToString(), out TimeSpan end))
                    dtp_EndTime.Value = DateTime.Today.Add(end);

                txt_CourseFee.Text = row.Cells["CourseFee"].Value.ToString();

                LoadCourseTeacher(selectedCourseId);
                LoadRegisteredStudents(selectedCourseId);
            }
        }

        private void LoadCourseTeacher(int courseId)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = "SELECT TeacherId FROM CourseInfo WHERE CourseId = @CourseId";
                DataTable dt = da.ExecuteQueryTable(sql, new SqlParameter[] { new SqlParameter("@CourseId", courseId) });
                if (dt.Rows.Count > 0 && dt.Rows[0]["TeacherId"] != DBNull.Value)
                {
                    int teacherId = Convert.ToInt32(dt.Rows[0]["TeacherId"]);
                    SetSelectedTeacher(teacherId);
                }
                else
                {
                    cmb_Teacher.SelectedIndex = 0;
                }
            }
            catch { }
        }

        private void LoadRegisteredStudents(int courseId)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT a.UserName AS StudentName, a.Email, s.Phone, s.Gender
                               FROM StudentCourseRegistration r
                               INNER JOIN StudentInfo s ON r.StudentId = s.StudentId
                               INNER JOIN AuthenticationInfo a ON s.UserId = a.UserId
                               WHERE r.CourseId = @CourseId
                               ORDER BY a.UserName";
                DataTable dt = da.ExecuteQueryTable(sql, new SqlParameter[] { new SqlParameter("@CourseId", courseId) });
                dgv_Students.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dgv_Students.Rows.Add(
                        row["StudentName"],
                        row["Email"],
                        row["Phone"],
                        row["Gender"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}