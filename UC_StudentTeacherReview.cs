using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_StudentTeacherReview : UserControl
    {
        public int StudentUserId { get; set; }
        private int selectedTeacherId = 0;

        public UC_StudentTeacherReview()
        {
            InitializeComponent();
        }

        private void UC_StudentTeacherReview_Load(object sender, EventArgs e)
        {
            if (StudentUserId <= 0)
            {
                MessageBox.Show("Student user ID not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ConfigureGrid();
            LoadMyReviews();
        }

        private void ConfigureGrid()
        {
            dgv_MyReviews.Columns.Clear();
            dgv_MyReviews.Columns.Add("ReviewId", "ID");
            dgv_MyReviews.Columns.Add("TeacherName", "Teacher");
            dgv_MyReviews.Columns.Add("Rating", "Rating");
            dgv_MyReviews.Columns.Add("ReviewText", "Review");

            dgv_MyReviews.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_MyReviews.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_MyReviews.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_MyReviews.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_MyReviews.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_MyReviews.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_MyReviews.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_MyReviews.Columns["ReviewId"].Visible = false;
            dgv_MyReviews.Columns["TeacherName"].Width = 150;
            dgv_MyReviews.Columns["Rating"].Width = 70;
            dgv_MyReviews.Columns["ReviewText"].Width = 470;
        }

        private void LoadMyReviews()
        {
            try
            {
                DataAccess da = new DataAccess();
                // Get StudentId from UserId
                string getStudentSql = "SELECT StudentId FROM StudentInfo WHERE UserId = @UserId";
                DataTable dtStudent = da.ExecuteQueryTable(getStudentSql,
                    new SqlParameter[] { new SqlParameter("@UserId", StudentUserId) });
                if (dtStudent.Rows.Count == 0)
                {
                    MessageBox.Show("Student record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int studentId = Convert.ToInt32(dtStudent.Rows[0]["StudentId"]);

                string sql = @"SELECT r.ReviewId, a.UserName AS TeacherName, r.Rating, r.ReviewText
                               FROM TeacherReview r
                               INNER JOIN TeacherInfo t ON r.TeacherId = t.TeacherId
                               INNER JOIN AuthenticationInfo a ON t.UserId = a.UserId
                               WHERE r.StudentId = @StudentId
                               ORDER BY r.ReviewId DESC";
                DataTable dt = da.ExecuteQueryTable(sql, new SqlParameter[] { new SqlParameter("@StudentId", studentId) });

                dgv_MyReviews.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dgv_MyReviews.Rows.Add(row["ReviewId"], row["TeacherName"], row["Rating"], row["ReviewText"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reviews: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SearchTeacher_Click(object sender, EventArgs e)
        {
            string search = txt_TeacherSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(search))
            {
                MessageBox.Show("Enter a teacher name to search.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT t.TeacherId, a.UserName
                               FROM TeacherInfo t
                               INNER JOIN AuthenticationInfo a ON t.UserId = a.UserId
                               WHERE a.UserName LIKE @Search";
                DataTable dt = da.ExecuteQueryTable(sql, new SqlParameter[] { new SqlParameter("@Search", "%" + search + "%") });

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No teacher found with that name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedTeacherId = 0;
                    lbl_selectedTeacher.Text = "Selected Teacher: None";
                    return;
                }
                // Select the first match (you could add a selection dialog)
                selectedTeacherId = Convert.ToInt32(dt.Rows[0]["TeacherId"]);
                lbl_selectedTeacher.Text = $"Selected Teacher: {dt.Rows[0]["UserName"]}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SubmitReview_Click(object sender, EventArgs e)
        {
            if (selectedTeacherId <= 0)
            {
                MessageBox.Show("Please search and select a teacher first.", "No Teacher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rating = (int)num_Rating.Value;
            string reviewText = txt_ReviewText.Text.Trim();

            try
            {
                DataAccess da = new DataAccess();
                // Get StudentId
                string getStudentSql = "SELECT StudentId FROM StudentInfo WHERE UserId = @UserId";
                DataTable dtStudent = da.ExecuteQueryTable(getStudentSql,
                    new SqlParameter[] { new SqlParameter("@UserId", StudentUserId) });
                if (dtStudent.Rows.Count == 0)
                {
                    MessageBox.Show("Student record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int studentId = Convert.ToInt32(dtStudent.Rows[0]["StudentId"]);

                string insertSql = @"INSERT INTO TeacherReview (StudentId, TeacherId, ReviewText, Rating)
                                     VALUES (@StudentId, @TeacherId, @ReviewText, @Rating)";
                SqlParameter[] parameters = {
                    new SqlParameter("@StudentId", studentId),
                    new SqlParameter("@TeacherId", selectedTeacherId),
                    new SqlParameter("@ReviewText", string.IsNullOrWhiteSpace(reviewText) ? DBNull.Value : (object)reviewText),
                    new SqlParameter("@Rating", rating)
                };
                da.ExecuteDMLQuery(insertSql, parameters);

                MessageBox.Show("Review submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ReviewText.Clear();
                num_Rating.Value = 5;
                selectedTeacherId = 0;
                lbl_selectedTeacher.Text = "Selected Teacher: None";
                LoadMyReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Submission failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}