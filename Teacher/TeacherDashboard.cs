using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class TeacherDashboard : Form
    {
        public string UserName { get; set; } = "TeacherName";
        public int UserId { get; set; }

        public TeacherDashboard()
        {
            InitializeComponent();
        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = $"Welcome Mr. {UserName}";
            ConfigureScheduleGrid();
            LoadTeacherSchedule();
        }

        private void ConfigureScheduleGrid()
        {
            dgv_schedule.Columns.Clear();
            dgv_schedule.Columns.Add("Day", "Day");
            dgv_schedule.Columns.Add("CourseName", "Course Name");
            dgv_schedule.Columns.Add("Time", "Time");

            dgv_schedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            dgv_schedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_schedule.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgv_schedule.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            dgv_schedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv_schedule.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv_schedule.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            dgv_schedule.Columns["Day"].Width = 150;
            dgv_schedule.Columns["CourseName"].Width = 350;
            dgv_schedule.Columns["Time"].Width = 250;
        }

        private void LoadTeacherSchedule()
        {
            try
            {
                DataAccess da = new DataAccess();

                string teacherIdSql = "SELECT TeacherId FROM TeacherInfo WHERE UserId = @UserId";
                SqlParameter[] paramUserId = { new SqlParameter("@UserId", UserId) };
                DataTable dtTeacher = da.ExecuteQueryTable(teacherIdSql, paramUserId);

                if (dtTeacher.Rows.Count == 0)
                {
                    MessageBox.Show("Teacher record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int teacherId = Convert.ToInt32(dtTeacher.Rows[0]["TeacherId"]);

                string scheduleSql = @"SELECT DayOfWeek, CourseName, 
                                        CONVERT(varchar(5), StartTime, 108) + ' - ' + CONVERT(varchar(5), EndTime, 108) AS TimeRange
                                      FROM CourseInfo
                                      WHERE TeacherId = @TeacherId
                                      ORDER BY 
                                        CASE DayOfWeek
                                            WHEN 'Saturday' THEN 1
                                            WHEN 'Sunday' THEN 2
                                            WHEN 'Monday' THEN 3
                                            WHEN 'Tuesday' THEN 4
                                            WHEN 'Wednesday' THEN 5
                                            WHEN 'Thursday' THEN 6
                                            WHEN 'Friday' THEN 7
                                            ELSE 8
                                        END,
                                        StartTime";

                SqlParameter[] paramTeacher = { new SqlParameter("@TeacherId", teacherId) };
                DataTable dtCourses = da.ExecuteQueryTable(scheduleSql, paramTeacher);

                dgv_schedule.Rows.Clear();
                foreach (DataRow row in dtCourses.Rows)
                {
                    dgv_schedule.Rows.Add(
                        row["DayOfWeek"].ToString(),
                        row["CourseName"].ToString(),
                        row["TimeRange"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading schedule: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // HEADER LOGOUT
        private void btn_logoutHeader_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Home home = new Home();
                home.FormClosed += (s, args) =>
                {
                    Login login = new Login();
                    login.Show();
                    this.Close();
                };
                home.Show();
            }
        }

        // DEFAULT VIEW
        private void ShowDefaultView()
        {
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(lbl_welcome);
            pnl_body.Controls.Add(dgv_schedule);
        }

        // SIDEBAR BUTTONS
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ShowDefaultView();
        }

        private void btn_gradeManager_Click(object sender, EventArgs e)
        {
            pnl_body.Controls.Clear();
            UC_TeacherGradeManager uc = new UC_TeacherGradeManager();
            uc.TeacherUserId = this.UserId;
            uc.Dock = DockStyle.Fill;
            pnl_body.Controls.Add(uc);
        }

        private void btn_uploadAssignment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Upload Assignment page will be added later.",
                "Upload Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_attendanceManagement_Click(object sender, EventArgs e)
        {
            pnl_body.Controls.Clear();
            UC_TeacherAttendance uc = new UC_TeacherAttendance();
            uc.TeacherUserId = this.UserId;
            uc.Dock = DockStyle.Fill;
            pnl_body.Controls.Add(uc);
        }

        private void btn_requestStudyLeave_Click(object sender, EventArgs e)
        {
            pnl_body.Controls.Clear();
            UC_TeacherLeaveRequest uc = new UC_TeacherLeaveRequest();
            uc.TeacherUserId = this.UserId;
            uc.Dock = DockStyle.Fill;
            pnl_body.Controls.Add(uc);
        }

        private void Assignment_manager_Click(object sender, EventArgs e)
        {
            pnl_body.Controls.Clear();
            UC_TeacherAssignmentManager uc = new UC_TeacherAssignmentManager();
            uc.TeacherUserId = this.UserId;
            uc.Dock = DockStyle.Fill;
            pnl_body.Controls.Add(uc);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (UserId <= 0)
            {
                MessageBox.Show("Teacher user ID not set.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UC_TeacherProfile uc = new UC_TeacherProfile();
            uc.TeacherUserId = this.UserId;
            uc.Dock = DockStyle.Fill;
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(uc);
        }

        private void btn_logoutSidebar_Click(object sender, EventArgs e)
        {
            btn_logoutHeader_Click(sender, e);
        }

        // HOVER EFFECTS
        private void SidebarBtn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(30, 41, 59);
            btn.ForeColor = Color.White;
        }

        private void SidebarBtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.FromArgb(203, 213, 225);
        }

        private void btn_logoutSidebar_MouseEnter(object sender, EventArgs e)
        {
            btn_logoutSidebar.BackColor = Color.FromArgb(185, 28, 28);
            btn_logoutSidebar.ForeColor = Color.White;
        }

        private void btn_logoutSidebar_MouseLeave(object sender, EventArgs e)
        {
            btn_logoutSidebar.BackColor = Color.Transparent;
            btn_logoutSidebar.ForeColor = Color.FromArgb(248, 113, 113);
        }
    }
}