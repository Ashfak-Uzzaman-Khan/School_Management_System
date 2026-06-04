using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_StudentAttendance : UserControl
    {
        public int StudentUserId { get; set; }
        private int studentId = 0;

        public UC_StudentAttendance()
        {
            InitializeComponent();
        }

        private void UC_StudentAttendance_Load(object sender, EventArgs e)
        {
            if (StudentUserId > 0)
            {
                LoadStudentId();
                ConfigureGrid();
                LoadAttendance();
                UpdatePercentage();
            }
            else
            {
                MessageBox.Show("Student user ID not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudentId()
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = "SELECT StudentId FROM StudentInfo WHERE UserId = @UserId";
                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@UserId", StudentUserId) });
                if (dt.Rows.Count > 0)
                    studentId = Convert.ToInt32(dt.Rows[0]["StudentId"]);
                else
                    MessageBox.Show("Student record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGrid()
        {
            dgv_Attendance.Columns.Clear();
            dgv_Attendance.Columns.Add("CourseName", "Course Name");
            dgv_Attendance.Columns.Add("Date", "Date");
            dgv_Attendance.Columns.Add("Status", "Status");

            dgv_Attendance.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Attendance.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Attendance.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Attendance.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Attendance.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Attendance.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Attendance.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_Attendance.Columns["CourseName"].Width = 300;
            dgv_Attendance.Columns["Date"].Width = 150;
            dgv_Attendance.Columns["Status"].Width = 150;
        }

        private void LoadAttendance(string searchTerm = "")
        {
            if (studentId == 0) return;

            try
            {
                DataAccess da = new DataAccess();
                string sql = @"
                    SELECT c.CourseName,
                           CONVERT(varchar(10), a.AttendanceDate, 120) AS Date,
                           a.Status
                    FROM Attendance a
                    INNER JOIN CourseInfo c ON a.CourseId = c.CourseId
                    WHERE a.StudentId = @StudentId";

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    sql += " AND c.CourseName LIKE @Search";
                }

                sql += " ORDER BY a.AttendanceDate DESC, c.CourseName";
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@StudentId", studentId));
                if (!string.IsNullOrWhiteSpace(searchTerm))
                    paramList.Add(new SqlParameter("@Search", "%" + searchTerm + "%"));

                DataTable dt = da.ExecuteQueryTable(sql, paramList.ToArray());
                dgv_Attendance.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgv_Attendance.Rows.Add(
                        row["CourseName"],
                        row["Date"],
                        row["Status"]
                    );
                }

                UpdatePercentage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePercentage()
        {
            if (studentId == 0)
            {
                lbl_percentage.Text = "0.00%";
                return;
            }

            try
            {
                DataAccess da = new DataAccess();
                string sql = @"
                    SELECT 
                        COUNT(*) AS Total,
                        SUM(CASE WHEN Status = 'Present' THEN 1 ELSE 0 END) AS PresentCount
                    FROM Attendance
                    WHERE StudentId = @StudentId";

                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@StudentId", studentId) });

                if (dt.Rows.Count > 0)
                {
                    int total = Convert.ToInt32(dt.Rows[0]["Total"]);
                    int present = Convert.ToInt32(dt.Rows[0]["PresentCount"]);
                    double percentage = total > 0 ? (double)present / total * 100.0 : 0.0;
                    lbl_percentage.Text = percentage.ToString("0.00") + "%";
                }
            }
            catch { lbl_percentage.Text = "Err"; }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadAttendance(txt_Search.Text.Trim());
        }
    }
}