using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_AdminPayments : UserControl
    {
        public UC_AdminPayments()
        {
            InitializeComponent();
        }

        private void UC_AdminPayments_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            LoadAllPayments();
        }

        private void ConfigureGrid()
        {
            dgv_Payments.Columns.Clear();
            dgv_Payments.Columns.Add("PaymentId", "ID");
            dgv_Payments.Columns.Add("StudentName", "Student");
            dgv_Payments.Columns.Add("CourseName", "Course");
            dgv_Payments.Columns.Add("Amount", "Fee");
            dgv_Payments.Columns.Add("PaymentStatus", "Status");

            dgv_Payments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Payments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Payments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Payments.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Payments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Payments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Payments.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_Payments.Columns["PaymentId"].Visible = false;
            dgv_Payments.Columns["StudentName"].Width = 150;
            dgv_Payments.Columns["CourseName"].Width = 250;
            dgv_Payments.Columns["Amount"].Width = 100;
            dgv_Payments.Columns["Amount"].DefaultCellStyle.Format = "N2";
            dgv_Payments.Columns["PaymentStatus"].Width = 80;
        }

        private void LoadAllPayments()
        {
            LoadPayments("");
        }

        private void LoadPayments(string studentNameFilter)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT p.PaymentId,
                               a.UserName AS StudentName,
                               c.CourseName,
                               p.Amount,
                               CASE WHEN p.PaymentStatus = 1 THEN 'Paid' ELSE 'Unpaid' END AS PaymentStatus
                               FROM PaymentInfo p
                               INNER JOIN StudentInfo s ON p.StudentId = s.StudentId
                               INNER JOIN AuthenticationInfo a ON s.UserId = a.UserId
                               INNER JOIN CourseInfo c ON p.CourseId = c.CourseId";

                if (!string.IsNullOrWhiteSpace(studentNameFilter))
                {
                    sql += " WHERE a.UserName LIKE @Search";
                }

                sql += " ORDER BY a.UserName, c.CourseName";

                SqlParameter[] parameters = new SqlParameter[0];
                if (!string.IsNullOrWhiteSpace(studentNameFilter))
                {
                    parameters = new SqlParameter[] { new SqlParameter("@Search", "%" + studentNameFilter + "%") };
                }

                DataTable dt = da.ExecuteQueryTable(sql, parameters);
                dgv_Payments.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgv_Payments.Rows.Add(
                        row["PaymentId"],
                        row["StudentName"],
                        row["CourseName"],
                        row["Amount"],
                        row["PaymentStatus"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadPayments(txt_Search.Text.Trim());
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            LoadAllPayments();
        }
    }
}