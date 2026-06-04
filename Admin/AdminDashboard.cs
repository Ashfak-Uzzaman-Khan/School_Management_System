using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class AdminDashboard : Form
    {
        public string UserName { get; set; } = "UserName";
        public int UserId { get; set; }

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = $"Welcome Mr. {UserName}";
            LoadDashboardCounts();
        }

        private void LoadDashboardCounts()
        {
            try
            {
                DataAccess da = new DataAccess();

                string sqlTeachers = "SELECT COUNT(*) FROM TeacherInfo";
                DataTable dtTeachers = da.ExecuteQueryTable(sqlTeachers);
                int teacherCount = Convert.ToInt32(dtTeachers.Rows[0][0]);
                lbl_teachersCount.Text = teacherCount.ToString();

                string sqlStudents = "SELECT COUNT(*) FROM StudentInfo";
                DataTable dtStudents = da.ExecuteQueryTable(sqlStudents);
                int studentCount = Convert.ToInt32(dtStudents.Rows[0][0]);
                lbl_studentsCount.Text = studentCount.ToString();

                string sqlDepts = "SELECT COUNT(*) FROM Departments";
                DataTable dtDepts = da.ExecuteQueryTable(sqlDepts);
                int deptCount = Convert.ToInt32(dtDepts.Rows[0][0]);
                lbl_deptCount.Text = deptCount.ToString();

                string sqlCourses = "SELECT COUNT(*) FROM CourseInfo";
                DataTable dtCourses = da.ExecuteQueryTable(sqlCourses);
                int courseCount = Convert.ToInt32(dtCourses.Rows[0][0]);
                lbl_coursesCount.Text = courseCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════
        //  HEADER LOGOUT
        // ════════════════════════════════════════════════════════
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

        // ════════════════════════════════════════════════════════
        //  DEFAULT VIEW
        // ════════════════════════════════════════════════════════
        private void ShowDefaultView()
        {
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(lbl_welcome);
            pnl_body.Controls.Add(pnl_infoCards);
            LoadDashboardCounts();   // ← refresh the numbers every time you return
        }
        // ════════════════════════════════════════════════════════
        //  SIDEBAR NAVIGATION – LOAD USER CONTROLS
        // ════════════════════════════════════════════════════════

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ShowDefaultView();
        }

        private void btn_teacherManager_Click(object sender, EventArgs e)
        {
            UC_TeacherManager uc = new UC_TeacherManager();
            LoadUserControl(uc);
        }

        private void btn_studentManager_Click(object sender, EventArgs e)
        {
            UC_StudentManager uc = new UC_StudentManager();
            LoadUserControl(uc);
        }

        private void button1_Click(object sender, EventArgs e)   // Course Manager
        {
            UC_CourseManager uc = new UC_CourseManager();
            LoadUserControl(uc);
        }

        private void btn_departmentManager_Click(object sender, EventArgs e)
        {
            UC_DepartmentManager uc = new UC_DepartmentManager();
            LoadUserControl(uc);
        }

        private void btn_researchBudget_Click(object sender, EventArgs e)
        {
            // Placeholder – will be implemented later
            MessageBox.Show("Research Budget Manager page will be added later.",
                "Research Budget Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_leaveRequest_Click(object sender, EventArgs e)
        {
            UC_AdminLeaveRequests uc = new UC_AdminLeaveRequests();
            LoadUserControl(uc);
        }

        private void btn_reviews_Click(object sender, EventArgs e)
        {
            UC_AdminReviews uc = new UC_AdminReviews();
            LoadUserControl(uc);
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            UC_AdminPayments uc = new UC_AdminPayments();
            LoadUserControl(uc);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (UserId <= 0)
            {
                MessageBox.Show("Admin user ID not set. Please log in again.",
                    "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UC_AdminProfile uc = new UC_AdminProfile();
            uc.AdminUserId = this.UserId;
            LoadUserControl(uc);
        }

        private void btn_logoutSidebar_Click(object sender, EventArgs e)
        {
            btn_logoutHeader_Click(sender, e);
        }

        // ════════════════════════════════════════════════════════
        //  HELPER – LOAD A USER CONTROL INTO THE BODY PANEL
        // ════════════════════════════════════════════════════════
        private void LoadUserControl(UserControl uc)
        {
            pnl_body.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnl_body.Controls.Add(uc);
        }

        // ════════════════════════════════════════════════════════
        //  SIDEBAR HOVER EFFECTS
        // ════════════════════════════════════════════════════════
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

        private void Card_Paint(object sender, PaintEventArgs e)
        {
            Panel card = sender as Panel;
            if (card != null)
            {
                Color accent = Color.FromArgb(59, 130, 246);
                if (card == pnl_cardTeachers) accent = Color.FromArgb(22, 163, 74);
                else if (card == pnl_cardStudents) accent = Color.FromArgb(59, 130, 246);
                else if (card == pnl_cardDepartments) accent = Color.FromArgb(234, 88, 12);
                else if (card == pnl_cardCourses) accent = Color.FromArgb(220, 38, 38);

                using (Pen pen = new Pen(accent, 4))
                {
                    e.Graphics.DrawLine(pen, 0, 0, card.Width, 0);
                }
            }
        }
    }
}