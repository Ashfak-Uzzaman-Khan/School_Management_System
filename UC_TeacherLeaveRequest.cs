using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_TeacherLeaveRequest : UserControl
    {
        public int TeacherUserId { get; set; }

        public UC_TeacherLeaveRequest()
        {
            InitializeComponent();
        }

        private void UC_TeacherLeaveRequest_Load(object sender, EventArgs e)
        {
            if (TeacherUserId <= 0)
            {
                MessageBox.Show("Teacher user ID not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConfigureGrid();
            LoadMyRequests();
        }

        private void ConfigureGrid()
        {
            dgv_MyRequests.Columns.Clear();
            dgv_MyRequests.Columns.Add("LeaveRequestId", "ID");
            dgv_MyRequests.Columns.Add("RequestMessage", "Message");
            dgv_MyRequests.Columns.Add("Status", "Status");

            dgv_MyRequests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_MyRequests.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_MyRequests.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_MyRequests.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_MyRequests.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_MyRequests.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_MyRequests.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_MyRequests.Columns["LeaveRequestId"].Visible = false;
            dgv_MyRequests.Columns["RequestMessage"].Width = 500;
            dgv_MyRequests.Columns["Status"].Width = 120;
        }

        private void LoadMyRequests()
        {
            try
            {
                DataAccess da = new DataAccess();
                // Get TeacherId from UserId
                string getTeacherIdSql = "SELECT TeacherId FROM TeacherInfo WHERE UserId = @UserId";
                DataTable dtTeacher = da.ExecuteQueryTable(getTeacherIdSql,
                    new SqlParameter[] { new SqlParameter("@UserId", TeacherUserId) });

                if (dtTeacher.Rows.Count == 0)
                {
                    MessageBox.Show("Teacher record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int teacherId = Convert.ToInt32(dtTeacher.Rows[0]["TeacherId"]);

                string sql = @"SELECT LeaveRequestId, RequestMessage, Status
                               FROM TeacherLeaveRequest
                               WHERE TeacherId = @TeacherId
                               ORDER BY LeaveRequestId DESC";

                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@TeacherId", teacherId) });

                dgv_MyRequests.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dgv_MyRequests.Rows.Add(
                        row["LeaveRequestId"],
                        row["RequestMessage"],
                        row["Status"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading your requests: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string message = txt_Message.Text.Trim();
            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please enter a leave message.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataAccess da = new DataAccess();

                // Get TeacherId
                string getTeacherIdSql = "SELECT TeacherId FROM TeacherInfo WHERE UserId = @UserId";
                DataTable dtTeacher = da.ExecuteQueryTable(getTeacherIdSql,
                    new SqlParameter[] { new SqlParameter("@UserId", TeacherUserId) });

                if (dtTeacher.Rows.Count == 0)
                {
                    MessageBox.Show("Teacher record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int teacherId = Convert.ToInt32(dtTeacher.Rows[0]["TeacherId"]);

                string insertSql = @"INSERT INTO TeacherLeaveRequest (TeacherId, RequestMessage, Status)
                                     VALUES (@TeacherId, @Message, 'Pending')";
                SqlParameter[] parameters = {
                    new SqlParameter("@TeacherId", teacherId),
                    new SqlParameter("@Message", message)
                };
                da.ExecuteDMLQuery(insertSql, parameters);

                MessageBox.Show("Leave request submitted successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Message.Clear();
                LoadMyRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Submission failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}