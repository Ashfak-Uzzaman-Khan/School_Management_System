using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_AdminLeaveRequests : UserControl
    {
        private int selectedLeaveRequestId = 0;

        public UC_AdminLeaveRequests()
        {
            InitializeComponent();
        }

        private void UC_AdminLeaveRequests_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            LoadAllRequests();
        }

        private void ConfigureGrid()
        {
            dgv_LeaveRequests.Columns.Clear();
            dgv_LeaveRequests.Columns.Add("LeaveRequestId", "Request ID");
            dgv_LeaveRequests.Columns.Add("TeacherName", "Teacher Name");
            dgv_LeaveRequests.Columns.Add("RequestMessage", "Message");
            dgv_LeaveRequests.Columns.Add("Status", "Status");

            dgv_LeaveRequests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_LeaveRequests.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_LeaveRequests.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_LeaveRequests.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_LeaveRequests.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_LeaveRequests.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_LeaveRequests.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_LeaveRequests.Columns["LeaveRequestId"].Visible = false;
            dgv_LeaveRequests.Columns["TeacherName"].Width = 150;
            dgv_LeaveRequests.Columns["RequestMessage"].Width = 400;
            dgv_LeaveRequests.Columns["Status"].Width = 100;
        }

        private void LoadAllRequests()
        {
            LoadRequests("");
        }

        private void LoadRequests(string teacherNameFilter)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT lr.LeaveRequestId, a.UserName AS TeacherName,
                               lr.RequestMessage, lr.Status
                               FROM TeacherLeaveRequest lr
                               INNER JOIN TeacherInfo t ON lr.TeacherId = t.TeacherId
                               INNER JOIN AuthenticationInfo a ON t.UserId = a.UserId";

                if (!string.IsNullOrWhiteSpace(teacherNameFilter))
                    sql += " WHERE a.UserName LIKE @Search";

                sql += " ORDER BY lr.LeaveRequestId DESC";

                SqlParameter[] parameters = new SqlParameter[0];
                if (!string.IsNullOrWhiteSpace(teacherNameFilter))
                    parameters = new SqlParameter[] { new SqlParameter("@Search", "%" + teacherNameFilter + "%") };

                DataTable dt = da.ExecuteQueryTable(sql, parameters);
                dgv_LeaveRequests.Rows.Clear();   // ← FIX: remove old rows before adding new ones

                foreach (DataRow row in dt.Rows)
                {
                    dgv_LeaveRequests.Rows.Add(
                        row["LeaveRequestId"],
                        row["TeacherName"],
                        row["RequestMessage"],
                        row["Status"]
                    );
                }
                selectedLeaveRequestId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requests: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatus(string newStatus)
        {
            if (selectedLeaveRequestId == 0)
            {
                MessageBox.Show("Please select a request first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataAccess da = new DataAccess();
                string sql = "UPDATE TeacherLeaveRequest SET Status = @Status WHERE LeaveRequestId = @Id";
                SqlParameter[] parameters = {
                    new SqlParameter("@Status", newStatus),
                    new SqlParameter("@Id", selectedLeaveRequestId)
                };
                da.ExecuteDMLQuery(sql, parameters);

                MessageBox.Show($"Request status changed to '{newStatus}'.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload with current filter
                LoadRequests(txt_Search.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Approve_Click(object sender, EventArgs e) => UpdateStatus("Approved");
        private void btn_Decline_Click(object sender, EventArgs e) => UpdateStatus("Declined");
        private void btn_Pending_Click(object sender, EventArgs e) => UpdateStatus("Pending");

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadRequests(txt_Search.Text.Trim());
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            LoadAllRequests();
        }

        private void dgv_LeaveRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedLeaveRequestId = Convert.ToInt32(
                    dgv_LeaveRequests.Rows[e.RowIndex].Cells["LeaveRequestId"].Value);
            }
        }
    }
}