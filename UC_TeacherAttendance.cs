using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_TeacherAttendance : UserControl
    {
        // Set this from TeacherDashboard before showing the control
        public int TeacherUserId { get; set; }
        private int teacherId = 0;
        private int selectedStudentId = 0;
        private int selectedCourseId = 0;
        private int selectedAttendanceId = 0;

        public UC_TeacherAttendance()
        {
            InitializeComponent();
        }

        private void UC_TeacherAttendance_Load(object sender, EventArgs e)
        {
            cmb_Status.Items.Clear();
            cmb_Status.Items.Add("Present");
            cmb_Status.Items.Add("Absent");
            cmb_Status.Items.Add("Late");
            cmb_Status.SelectedIndex = 0;

            dtp_Date.Value = DateTime.Today;

            if (TeacherUserId > 0)
            {
                LoadTeacherId();
                ConfigureGrid();
                LoadAttendance();
            }
            else
            {
                MessageBox.Show("Teacher user ID not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTeacherId()
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = "SELECT TeacherId FROM TeacherInfo WHERE UserId = @UserId";
                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@UserId", TeacherUserId) });
                if (dt.Rows.Count > 0)
                    teacherId = Convert.ToInt32(dt.Rows[0]["TeacherId"]);
                else
                    MessageBox.Show("Teacher record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGrid()
        {
            dgv_Attendance.Columns.Clear();
            dgv_Attendance.Columns.Add("AttendanceId", "AttendanceId");
            dgv_Attendance.Columns.Add("StudentId", "StudentId");
            dgv_Attendance.Columns.Add("CourseId", "CourseId");
            dgv_Attendance.Columns.Add("CourseName", "Course Name");
            dgv_Attendance.Columns.Add("StudentName", "Student Name");
            dgv_Attendance.Columns.Add("Date", "Date");
            dgv_Attendance.Columns.Add("Status", "Status");

            // Style
            dgv_Attendance.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_Attendance.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Attendance.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_Attendance.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_Attendance.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_Attendance.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_Attendance.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_Attendance.Columns["AttendanceId"].Visible = false;
            dgv_Attendance.Columns["StudentId"].Visible = false;
            dgv_Attendance.Columns["CourseId"].Visible = false;
            dgv_Attendance.Columns["CourseName"].Width = 180;
            dgv_Attendance.Columns["StudentName"].Width = 180;
            dgv_Attendance.Columns["Date"].Width = 120;
            dgv_Attendance.Columns["Status"].Width = 100;
        }

        private void LoadAttendance(string searchTerm = "")
        {
            if (teacherId == 0) return;

            try
            {
                DataAccess da = new DataAccess();
                string sql = @"
                    SELECT a.AttendanceId, a.StudentId, a.CourseId,
                           c.CourseName, au.UserName AS StudentName,
                           CONVERT(varchar(10), a.AttendanceDate, 120) AS Date,
                           a.Status
                    FROM Attendance a
                    INNER JOIN StudentInfo s ON a.StudentId = s.StudentId
                    INNER JOIN AuthenticationInfo au ON s.UserId = au.UserId
                    INNER JOIN CourseInfo c ON a.CourseId = c.CourseId
                    WHERE c.TeacherId = @TeacherId";

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    sql += @" AND (c.CourseName LIKE @Search OR au.UserName LIKE @Search)";
                }

                sql += " ORDER BY a.AttendanceDate DESC, c.CourseName, au.UserName";

                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@TeacherId", teacherId));
                if (!string.IsNullOrWhiteSpace(searchTerm))
                    paramList.Add(new SqlParameter("@Search", "%" + searchTerm + "%"));

                DataTable dt = da.ExecuteQueryTable(sql, paramList.ToArray());
                dgv_Attendance.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgv_Attendance.Rows.Add(
                        row["AttendanceId"],
                        row["StudentId"],
                        row["CourseId"],
                        row["CourseName"],
                        row["StudentName"],
                        row["Date"],
                        row["Status"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearEditPanel()
        {
            selectedAttendanceId = 0;
            selectedStudentId = 0;
            selectedCourseId = 0;
            dtp_Date.Value = DateTime.Today;
            cmb_Status.SelectedIndex = 0;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadAttendance(txt_Search.Text.Trim());
        }

        private void dgv_Attendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Attendance.Rows[e.RowIndex];
                selectedAttendanceId = Convert.ToInt32(row.Cells["AttendanceId"].Value);
                selectedStudentId = Convert.ToInt32(row.Cells["StudentId"].Value);
                selectedCourseId = Convert.ToInt32(row.Cells["CourseId"].Value);
                dtp_Date.Value = DateTime.Parse(row.Cells["Date"].Value.ToString());
                cmb_Status.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0 || selectedCourseId == 0)
            {
                MessageBox.Show("Please select a student from the grid first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = cmb_Status.SelectedItem.ToString();
            DateTime date = dtp_Date.Value.Date;

            try
            {
                DataAccess da = new DataAccess();

                // Check if a record already exists for this student, course, date
                string checkSql = @"SELECT AttendanceId FROM Attendance
                                    WHERE StudentId = @StudentId
                                      AND CourseId = @CourseId
                                      AND AttendanceDate = @Date";
                SqlParameter[] checkParams = {
                    new SqlParameter("@StudentId", selectedStudentId),
                    new SqlParameter("@CourseId", selectedCourseId),
                    new SqlParameter("@Date", date)
                };
                DataTable dtCheck = da.ExecuteQueryTable(checkSql, checkParams);

                if (dtCheck.Rows.Count > 0)
                {
                    // Update existing
                    int attId = Convert.ToInt32(dtCheck.Rows[0]["AttendanceId"]);
                    string updateSql = "UPDATE Attendance SET Status = @Status WHERE AttendanceId = @Id";
                    da.ExecuteDMLQuery(updateSql, new SqlParameter[]
                    {
                        new SqlParameter("@Status", status),
                        new SqlParameter("@Id", attId)
                    });
                }
                else
                {
                    // Insert new
                    string insertSql = @"INSERT INTO Attendance (StudentId, CourseId, AttendanceDate, Status)
                                         VALUES (@StudentId, @CourseId, @Date, @Status)";
                    da.ExecuteDMLQuery(insertSql, new SqlParameter[]
                    {
                        new SqlParameter("@StudentId", selectedStudentId),
                        new SqlParameter("@CourseId", selectedCourseId),
                        new SqlParameter("@Date", date),
                        new SqlParameter("@Status", status)
                    });
                }

                MessageBox.Show("Attendance saved.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearEditPanel();
                LoadAttendance(txt_Search.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearEditPanel();
            LoadAttendance(txt_Search.Text.Trim());
        }
    }
}