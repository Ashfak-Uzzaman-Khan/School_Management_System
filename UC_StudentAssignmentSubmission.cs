using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_StudentAssignmentSubmission : UserControl
    {
        public int StudentUserId { get; set; }
        private int currentStudentId = 0;
        private int selectedAssignmentId = 0;

        public UC_StudentAssignmentSubmission()
        {
            InitializeComponent();
        }

        private void UC_StudentAssignmentSubmission_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            if (StudentUserId <= 0) { MessageBox.Show("Student ID not set."); return; }

            // Get StudentId
            try
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(
                    "SELECT StudentId FROM StudentInfo WHERE UserId=@UserId",
                    new SqlParameter[] { new SqlParameter("@UserId", StudentUserId) });
                if (dt.Rows.Count == 0) { MessageBox.Show("Student record not found."); return; }
                currentStudentId = Convert.ToInt32(dt.Rows[0]["StudentId"]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }

            ConfigureGrid();
            LoadAllAssignments();
        }

        private void ConfigureGrid()
        {
            dgv_Assignments.Columns.Clear();
            dgv_Assignments.Columns.Add("AssignmentId", "ID");
            dgv_Assignments.Columns.Add("CourseName", "Course");
            dgv_Assignments.Columns.Add("AssignmentDetails", "Assignment");
            dgv_Assignments.Columns.Add("Deadline", "Deadline");
            dgv_Assignments.Columns.Add("Status", "Status");
            dgv_Assignments.Columns["AssignmentId"].Visible = false;

            dgv_Assignments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Assignments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Assignments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Assignments.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Assignments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Assignments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Assignments.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
        }

        private void LoadAllAssignments()
        {
            LoadAssignments("");
        }

        private void LoadAssignments(string courseFilter)
        {
            try
            {
                DataAccess da = new DataAccess();

                // Use a subquery to get the latest submission status per assignment,
                // ensuring each assignment appears only once.
                string sql = @"
                    SELECT a.AssignmentId, 
                           c.CourseName, 
                           a.AssignmentDetails,
                           CONVERT(varchar, a.Deadline, 23) AS Deadline,
                           ISNULL(latest.Status, 'Pending') AS Status
                    FROM Assignments a
                    INNER JOIN CourseInfo c ON a.CourseId = c.CourseId
                    INNER JOIN StudentCourseRegistration r ON c.CourseId = r.CourseId
                    LEFT JOIN (
                        SELECT AssignmentId, StudentId, SubmissionStatus AS Status
                        FROM AssignmentSubmissions
                        WHERE StudentId = @StudentId
                          AND SubmissionId = (
                              SELECT MAX(SubmissionId)
                              FROM AssignmentSubmissions sub2
                              WHERE sub2.AssignmentId = AssignmentSubmissions.AssignmentId
                                AND sub2.StudentId = AssignmentSubmissions.StudentId
                          )
                    ) latest ON a.AssignmentId = latest.AssignmentId AND latest.StudentId = @StudentId
                    WHERE r.StudentId = @StudentId";

                if (!string.IsNullOrWhiteSpace(courseFilter))
                    sql += " AND c.CourseName LIKE @CourseFilter";

                sql += " ORDER BY c.CourseName, a.Deadline";

                // Build parameter list safely – no null entries
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@StudentId", currentStudentId));
                if (!string.IsNullOrWhiteSpace(courseFilter))
                    paramList.Add(new SqlParameter("@CourseFilter", "%" + courseFilter + "%"));

                DataTable dt = da.ExecuteQueryTable(sql, paramList.ToArray());
                dgv_Assignments.Rows.Clear();

                int totalAssignments = dt.Rows.Count;
                int submittedCount = 0;

                foreach (DataRow row in dt.Rows)
                {
                    string status = row["Status"] != DBNull.Value ? row["Status"].ToString() : "Pending";
                    dgv_Assignments.Rows.Add(
                        row["AssignmentId"],
                        row["CourseName"],
                        row["AssignmentDetails"],
                        row["Deadline"] == DBNull.Value ? "" : row["Deadline"].ToString(),
                        status);

                    if (status == "Submitted")
                        submittedCount++;
                }

                // Update counters safely
                lbl_leftCount.Text = (totalAssignments - submittedCount).ToString();
                lbl_subCount.Text = submittedCount.ToString();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // (UpdateCounters is now integrated directly into LoadAssignments,
        //  so this method can be removed. It's kept empty for backwards compatibility.)
        private void UpdateCounters() { }

        private void dgv_Assignments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedAssignmentId = Convert.ToInt32(dgv_Assignments.Rows[e.RowIndex].Cells["AssignmentId"].Value);
                string details = dgv_Assignments.Rows[e.RowIndex].Cells["AssignmentDetails"].Value.ToString();
                lbl_selectedAssignment.Text = "Selected: " + details;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadAssignments(txt_Search.Text.Trim());
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            LoadAllAssignments();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (selectedAssignmentId <= 0)
            {
                MessageBox.Show("Select an assignment first.");
                return;
            }

            string answer = txt_Answer.Text.Trim();
            if (string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Enter your answer.");
                return;
            }

            // Check if already submitted (using the grid which now has a single row per assignment)
            foreach (DataGridViewRow row in dgv_Assignments.Rows)
            {
                if (Convert.ToInt32(row.Cells["AssignmentId"].Value) == selectedAssignmentId)
                {
                    object val = row.Cells["Status"].Value;
                    string status = val != null ? val.ToString() : "Pending";
                    if (status == "Submitted")
                    {
                        MessageBox.Show("You have already submitted this assignment.");
                        return;
                    }
                    break;
                }
            }

            try
            {
                DataAccess da = new DataAccess();
                string sql = @"INSERT INTO AssignmentSubmissions (AssignmentId, StudentId, AnswerText, SubmissionDate, SubmissionStatus)
                               VALUES (@AssignmentId, @StudentId, @AnswerText, GETDATE(), 'Submitted')";
                SqlParameter[] parameters = {
                    new SqlParameter("@AssignmentId", selectedAssignmentId),
                    new SqlParameter("@StudentId", currentStudentId),
                    new SqlParameter("@AnswerText", answer)
                };
                da.ExecuteDMLQuery(sql, parameters);
                MessageBox.Show("Assignment submitted successfully.");
                txt_Answer.Clear();
                LoadAllAssignments();  // reload to reflect the change
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}