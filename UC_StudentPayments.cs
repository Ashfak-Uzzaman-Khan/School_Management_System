using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_StudentPayments : UserControl
    {
        public int StudentUserId { get; set; }
        private int currentStudentId = 0;

        public UC_StudentPayments()
        {
            InitializeComponent();
        }

        private void UC_StudentPayments_Load(object sender, EventArgs e)
        {
            if (StudentUserId <= 0)
            {
                MessageBox.Show("Student user ID not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get StudentId
            try
            {
                DataAccess da = new DataAccess();
                string sql = "SELECT StudentId FROM StudentInfo WHERE UserId = @UserId";
                DataTable dt = da.ExecuteQueryTable(sql, new SqlParameter[] { new SqlParameter("@UserId", StudentUserId) });
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Student record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                currentStudentId = Convert.ToInt32(dt.Rows[0]["StudentId"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConfigureGrid();
            LoadMyCourses();
        }

        private void ConfigureGrid()
        {
            dgv_MyCourses.Columns.Clear();
            dgv_MyCourses.Columns.Add("PaymentId", "ID");
            dgv_MyCourses.Columns.Add("CourseName", "Course");
            dgv_MyCourses.Columns.Add("Amount", "Fee");
            dgv_MyCourses.Columns.Add("PaymentStatus", "Status");

            // Add a Pay button column
            DataGridViewButtonColumn btnPay = new DataGridViewButtonColumn();
            btnPay.Name = "Pay";
            btnPay.HeaderText = "Action";
            btnPay.Text = "Pay";
            btnPay.UseColumnTextForButtonValue = true;
            dgv_MyCourses.Columns.Add(btnPay);

            dgv_MyCourses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_MyCourses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_MyCourses.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_MyCourses.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_MyCourses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_MyCourses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_MyCourses.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_MyCourses.Columns["PaymentId"].Visible = false;
            dgv_MyCourses.Columns["CourseName"].Width = 300;
            dgv_MyCourses.Columns["Amount"].Width = 100;
            dgv_MyCourses.Columns["Amount"].DefaultCellStyle.Format = "N2";
            dgv_MyCourses.Columns["PaymentStatus"].Width = 90;
            dgv_MyCourses.Columns["Pay"].Width = 80;
        }

        private void LoadMyCourses()
        {
            LoadMyCoursesFiltered("");
        }

        private void LoadMyCoursesFiltered(string courseNameFilter)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT p.PaymentId, c.CourseName, p.Amount,
                               CASE WHEN p.PaymentStatus = 1 THEN 'Paid' ELSE 'Unpaid' END AS PaymentStatus
                               FROM PaymentInfo p
                               INNER JOIN CourseInfo c ON p.CourseId = c.CourseId
                               WHERE p.StudentId = @StudentId";

                if (!string.IsNullOrWhiteSpace(courseNameFilter))
                {
                    sql += " AND c.CourseName LIKE @CourseFilter";
                }

                sql += " ORDER BY c.CourseName";

                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@StudentId", currentStudentId));
                if (!string.IsNullOrWhiteSpace(courseNameFilter))
                {
                    paramList.Add(new SqlParameter("@CourseFilter", "%" + courseNameFilter + "%"));
                }

                DataTable dt = da.ExecuteQueryTable(sql, paramList.ToArray());
                dgv_MyCourses.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    int rowIndex = dgv_MyCourses.Rows.Add(
                        row["PaymentId"],
                        row["CourseName"],
                        row["Amount"],
                        row["PaymentStatus"]
                    );

                    // Disable Pay button if already paid
                    string status = row["PaymentStatus"].ToString();
                    DataGridViewButtonCell btnCell = (DataGridViewButtonCell)dgv_MyCourses.Rows[rowIndex].Cells["Pay"];
                    if (status == "Paid")
                    {
                        btnCell.Value = "Paid";
                        btnCell.FlatStyle = FlatStyle.Flat;
                        btnCell.Style.BackColor = Color.FromArgb(220, 220, 220);
                        btnCell.Style.ForeColor = Color.Gray;
                        dgv_MyCourses.Rows[rowIndex].Cells["Pay"].ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_MyCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if Pay button was clicked
            if (e.ColumnIndex == dgv_MyCourses.Columns["Pay"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_MyCourses.Rows[e.RowIndex];
                string status = row.Cells["PaymentStatus"].Value.ToString();
                if (status == "Paid")
                {
                    MessageBox.Show("This course is already paid.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int paymentId = Convert.ToInt32(row.Cells["PaymentId"].Value);
                decimal amount = Convert.ToDecimal(row.Cells["Amount"].Value);
                string courseName = row.Cells["CourseName"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to pay {amount:N2} for course '{courseName}'?\n\nThis amount will be deducted from your student balance.",
                    "Confirm Payment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataAccess da = new DataAccess();
                        string updateSql = "UPDATE PaymentInfo SET PaymentStatus = 1 WHERE PaymentId = @PaymentId";
                        da.ExecuteDMLQuery(updateSql, new SqlParameter[] { new SqlParameter("@PaymentId", paymentId) });

                        MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMyCoursesFiltered(txt_Search.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Payment failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadMyCoursesFiltered(txt_Search.Text.Trim());
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            LoadMyCourses();
        }
    }
}