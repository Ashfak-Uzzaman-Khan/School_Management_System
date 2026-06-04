using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_TeacherAssignmentManager : UserControl
    {
        public int TeacherUserId { get; set; }
        private int selectedCourseId = 0;
        private int selectedAssignmentId = 0;

        public UC_TeacherAssignmentManager()
        {
            InitializeComponent();
        }

        private void UC_TeacherAssignmentManager_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            LoadTeacherCourses();
            ConfigureGrids();
            pnl_addAssignment.Visible = false;
        }

        private void LoadTeacherCourses()
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT c.CourseId, c.CourseName 
                               FROM CourseInfo c
                               INNER JOIN TeacherInfo t ON c.TeacherId = t.TeacherId
                               WHERE t.UserId = @UserId
                               ORDER BY c.CourseName";
                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@UserId", TeacherUserId) });
                cmb_Course.Items.Clear();
                cmb_Course.Items.Add("-- Select Course --");
                foreach (DataRow row in dt.Rows)
                {
                    cmb_Course.Items.Add(new ComboItem(
                        row["CourseName"].ToString(),
                        Convert.ToInt32(row["CourseId"])));
                }
                cmb_Course.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private class ComboItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public ComboItem(string text, int value) { Text = text; Value = value; }
            public override string ToString() => Text;
        }

        private void ConfigureGrids()
        {
            dgv_Assignments.Columns.Clear();
            dgv_Assignments.Columns.Add("AssignmentId", "ID");
            dgv_Assignments.Columns.Add("AssignmentDetails", "Details");
            dgv_Assignments.Columns.Add("Deadline", "Deadline");
            dgv_Assignments.Columns.Add("PostedDate", "Posted");
            dgv_Assignments.Columns["AssignmentId"].Visible = false;
            StyleGrid(dgv_Assignments);

            dgv_Submissions.Columns.Clear();
            dgv_Submissions.Columns.Add("StudentName", "Student");
            dgv_Submissions.Columns.Add("Assignment", "Assignment");
            dgv_Submissions.Columns.Add("AnswerText", "Answer");
            dgv_Submissions.Columns.Add("SubmissionDate", "Date");
            dgv_Submissions.Columns.Add("Status", "Status");
            StyleGrid(dgv_Submissions);
        }

        private void StyleGrid(DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
        }

        private void cmb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Course.SelectedIndex <= 0)
            {
                selectedCourseId = 0;
                dgv_Assignments.Rows.Clear();
                return;
            }

            ComboItem item = (ComboItem)cmb_Course.SelectedItem;
            selectedCourseId = item.Value;
            LoadAssignmentsForCourse(selectedCourseId);
        }

        private void LoadAssignmentsForCourse(int courseId)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT AssignmentId, AssignmentDetails, 
                               CONVERT(varchar, Deadline, 23) AS Deadline,
                               CONVERT(varchar, PostedDate, 23) AS PostedDate
                               FROM Assignments
                               WHERE CourseId = @CourseId
                               ORDER BY PostedDate DESC";
                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@CourseId", courseId) });
                dgv_Assignments.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dgv_Assignments.Rows.Add(
                        row["AssignmentId"],
                        row["AssignmentDetails"],
                        row["Deadline"] == DBNull.Value ? "" : row["Deadline"].ToString(),
                        row["PostedDate"] == DBNull.Value ? "" : row["PostedDate"].ToString());
                }
                dgv_Submissions.Rows.Clear();
                selectedAssignmentId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assignments: " + ex.Message);
            }
        }

        private void dgv_Assignments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                selectedAssignmentId = Convert.ToInt32(dgv_Assignments.Rows[e.RowIndex].Cells["AssignmentId"].Value);
        }

        private void btn_AddAssignment_Click(object sender, EventArgs e)
        {
            if (selectedCourseId <= 0)
            {
                MessageBox.Show("Select a course first.");
                return;
            }
            txt_AssignmentDetails.Clear();
            dtp_Deadline.Value = DateTime.Today.AddDays(7);
            pnl_addAssignment.Visible = true;
        }

        private void btn_SaveAssignment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AssignmentDetails.Text))
            {
                MessageBox.Show("Enter assignment details.");
                return;
            }

            try
            {
                DataAccess da = new DataAccess();
                string sql = @"INSERT INTO Assignments (CourseId, TeacherId, AssignmentDetails, Deadline, PostedDate)
                               VALUES (@CourseId, (SELECT TeacherId FROM TeacherInfo WHERE UserId=@UserId),
                                       @Details, @Deadline, GETDATE())";
                SqlParameter[] parameters = {
                    new SqlParameter("@CourseId", selectedCourseId),
                    new SqlParameter("@UserId", TeacherUserId),
                    new SqlParameter("@Details", txt_AssignmentDetails.Text.Trim()),
                    new SqlParameter("@Deadline", dtp_Deadline.Value.Date)
                };
                da.ExecuteDMLQuery(sql, parameters);
                MessageBox.Show("Assignment posted.");
                pnl_addAssignment.Visible = false;
                LoadAssignmentsForCourse(selectedCourseId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_CancelAdd_Click(object sender, EventArgs e)
        {
            pnl_addAssignment.Visible = false;
        }

        private void btn_DeleteAssignment_Click(object sender, EventArgs e)
        {
            if (selectedAssignmentId <= 0)
            {
                MessageBox.Show("Select an assignment to delete.");
                return;
            }
            if (MessageBox.Show("Delete this assignment?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DataAccess da = new DataAccess();
                    da.ExecuteDMLQuery("DELETE FROM Assignments WHERE AssignmentId=@Id",
                        new SqlParameter[] { new SqlParameter("@Id", selectedAssignmentId) });
                    LoadAssignmentsForCourse(selectedCourseId);
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void btn_SearchStudent_Click(object sender, EventArgs e)
        {
            string term = txt_SearchStudent.Text.Trim();
            if (string.IsNullOrWhiteSpace(term))
            {
                MessageBox.Show("Enter student name or ID.");
                return;
            }

            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT a.UserName, ass.AssignmentDetails, sub.AnswerText,
                               CONVERT(varchar, sub.SubmissionDate, 23) AS SubDate,
                               sub.SubmissionStatus
                               FROM AssignmentSubmissions sub
                               INNER JOIN Assignments ass ON sub.AssignmentId = ass.AssignmentId
                               INNER JOIN StudentInfo s ON sub.StudentId = s.StudentId
                               INNER JOIN AuthenticationInfo a ON s.UserId = a.UserId
                               WHERE (a.UserName LIKE @Term OR CAST(s.StudentId AS varchar) = @Term)
                               ORDER BY sub.SubmissionDate DESC";
                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@Term", term) });
                dgv_Submissions.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dgv_Submissions.Rows.Add(row["UserName"], row["AssignmentDetails"],
                        row["AnswerText"], row["SubDate"], row["SubmissionStatus"]);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}