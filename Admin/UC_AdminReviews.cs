using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_AdminReviews : UserControl
    {
        private string currentTeacherFilter = "";

        public UC_AdminReviews()
        {
            InitializeComponent();
        }

        private void UC_AdminReviews_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            LoadAllReviews();
        }

        private void ConfigureGrid()
        {
            dgv_Reviews.Columns.Clear();
            dgv_Reviews.Columns.Add("ReviewId", "ID");
            dgv_Reviews.Columns.Add("StudentName", "Student");
            dgv_Reviews.Columns.Add("TeacherName", "Teacher");
            dgv_Reviews.Columns.Add("ReviewText", "Review");
            dgv_Reviews.Columns.Add("Rating", "Rating");

            dgv_Reviews.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Reviews.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Reviews.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Reviews.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Reviews.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Reviews.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Reviews.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_Reviews.Columns["ReviewId"].Visible = false;
            dgv_Reviews.Columns["StudentName"].Width = 120;
            dgv_Reviews.Columns["TeacherName"].Width = 120;
            dgv_Reviews.Columns["ReviewText"].Width = 350;
            dgv_Reviews.Columns["Rating"].Width = 60;
        }

        private void LoadAllReviews()
        {
            currentTeacherFilter = "";
            LoadReviewsGrid("");
        }

        private void LoadReviewsGrid(string teacherName)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT r.ReviewId,
                               st.UserName AS StudentName,
                               tch.UserName AS TeacherName,
                               r.ReviewText, r.Rating
                               FROM TeacherReview r
                               INNER JOIN StudentInfo s ON r.StudentId = s.StudentId
                               INNER JOIN AuthenticationInfo st ON s.UserId = st.UserId
                               INNER JOIN TeacherInfo t ON r.TeacherId = t.TeacherId
                               INNER JOIN AuthenticationInfo tch ON t.UserId = tch.UserId";

                if (!string.IsNullOrWhiteSpace(teacherName))
                    sql += " WHERE tch.UserName LIKE @Search";

                sql += " ORDER BY r.ReviewId DESC";

                SqlParameter[] parameters = new SqlParameter[0];
                if (!string.IsNullOrWhiteSpace(teacherName))
                    parameters = new SqlParameter[] { new SqlParameter("@Search", "%" + teacherName + "%") };

                DataTable dt = da.ExecuteQueryTable(sql, parameters);
                dgv_Reviews.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dgv_Reviews.Rows.Add(row["ReviewId"], row["StudentName"], row["TeacherName"],
                        row["ReviewText"], row["Rating"]);
                }

                // Update stats if a teacher filter is active
                if (!string.IsNullOrWhiteSpace(teacherName))
                {
                    LoadTeacherStats(teacherName);
                }
                else
                {
                    lbl_avgRating.Text = "Average Rating: --";
                    lbl_totalReviews.Text = "Total Reviews: --";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reviews: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTeacherStats(string teacherName)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT COUNT(*) AS TotalReviews, AVG(CAST(r.Rating AS decimal(3,1))) AS AvgRating
                               FROM TeacherReview r
                               INNER JOIN TeacherInfo t ON r.TeacherId = t.TeacherId
                               INNER JOIN AuthenticationInfo a ON t.UserId = a.UserId
                               WHERE a.UserName = @TeacherName";
                DataTable dt = da.ExecuteQueryTable(sql, new SqlParameter[] { new SqlParameter("@TeacherName", teacherName) });
                if (dt.Rows.Count > 0 && dt.Rows[0]["TotalReviews"] != DBNull.Value)
                {
                    int total = Convert.ToInt32(dt.Rows[0]["TotalReviews"]);
                    decimal avg = dt.Rows[0]["AvgRating"] != DBNull.Value ? Convert.ToDecimal(dt.Rows[0]["AvgRating"]) : 0;
                    lbl_avgRating.Text = $"Average Rating: {avg:0.0}";
                    lbl_totalReviews.Text = $"Total Reviews: {total}";
                }
            }
            catch { }
        }



        private void btn_Search_Click(object sender, EventArgs e)
        {
            string search = txt_Search.Text.Trim();
            currentTeacherFilter = search;
            LoadReviewsGrid(search);
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            LoadAllReviews();
        }
    }
}