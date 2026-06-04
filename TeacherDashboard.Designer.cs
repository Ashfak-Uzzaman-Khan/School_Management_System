namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class TeacherDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_teacherPanel = new System.Windows.Forms.Label();
            this.btn_logoutHeader = new System.Windows.Forms.Button();
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.Assignment_manager = new System.Windows.Forms.Button();
            this.btn_logoutSidebar = new System.Windows.Forms.Button();
            this.btn_requestStudyLeave = new System.Windows.Forms.Button();
            this.btn_attendanceManagement = new System.Windows.Forms.Button();
            this.btn_gradeManager = new System.Windows.Forms.Button();
            this.pnl_sidebarDivider = new System.Windows.Forms.Panel();
            this.pnl_sidebarHeader = new System.Windows.Forms.Panel();
            this.lbl_sidebarBrand = new System.Windows.Forms.Label();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.dgv_schedule = new System.Windows.Forms.DataGridView();
            this.pnl_header.SuspendLayout();
            this.pnl_sidebar.SuspendLayout();
            this.pnl_sidebarHeader.SuspendLayout();
            this.pnl_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnl_header.Controls.Add(this.lbl_teacherPanel);
            this.pnl_header.Controls.Add(this.btn_logoutHeader);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(960, 70);
            this.pnl_header.TabIndex = 0;
            // 
            // lbl_teacherPanel
            // 
            this.lbl_teacherPanel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_teacherPanel.ForeColor = System.Drawing.Color.White;
            this.lbl_teacherPanel.Location = new System.Drawing.Point(20, 0);
            this.lbl_teacherPanel.Name = "lbl_teacherPanel";
            this.lbl_teacherPanel.Size = new System.Drawing.Size(300, 70);
            this.lbl_teacherPanel.TabIndex = 0;
            this.lbl_teacherPanel.Text = "Teacher Panel";
            this.lbl_teacherPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_logoutHeader
            // 
            this.btn_logoutHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_logoutHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logoutHeader.FlatAppearance.BorderSize = 0;
            this.btn_logoutHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logoutHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_logoutHeader.ForeColor = System.Drawing.Color.White;
            this.btn_logoutHeader.Location = new System.Drawing.Point(830, 23);
            this.btn_logoutHeader.Name = "btn_logoutHeader";
            this.btn_logoutHeader.Size = new System.Drawing.Size(100, 34);
            this.btn_logoutHeader.TabIndex = 1;
            this.btn_logoutHeader.Text = "Logout";
            this.btn_logoutHeader.UseVisualStyleBackColor = false;
            this.btn_logoutHeader.Click += new System.EventHandler(this.btn_logoutHeader_Click);
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnl_sidebar.Controls.Add(this.btn_settings);
            this.pnl_sidebar.Controls.Add(this.btn_dashboard);
            this.pnl_sidebar.Controls.Add(this.Assignment_manager);
            this.pnl_sidebar.Controls.Add(this.btn_logoutSidebar);
            this.pnl_sidebar.Controls.Add(this.btn_requestStudyLeave);
            this.pnl_sidebar.Controls.Add(this.btn_attendanceManagement);
            this.pnl_sidebar.Controls.Add(this.btn_gradeManager);
            this.pnl_sidebar.Controls.Add(this.pnl_sidebarDivider);
            this.pnl_sidebar.Controls.Add(this.pnl_sidebarHeader);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 70);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(220, 568);
            this.pnl_sidebar.TabIndex = 1;
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_settings.Location = new System.Drawing.Point(0, 390);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(220, 40);
            this.btn_settings.TabIndex = 10;
            this.btn_settings.Text = "      ⚙️  Settings";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_dashboard.Location = new System.Drawing.Point(0, 75);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(220, 40);
            this.btn_dashboard.TabIndex = 11;
            this.btn_dashboard.Text = "      📊  Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // Assignment_manager
            // 
            this.Assignment_manager.BackColor = System.Drawing.Color.Transparent;
            this.Assignment_manager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Assignment_manager.FlatAppearance.BorderSize = 0;
            this.Assignment_manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Assignment_manager.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Assignment_manager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Assignment_manager.Location = new System.Drawing.Point(0, 165);
            this.Assignment_manager.Name = "Assignment_manager";
            this.Assignment_manager.Size = new System.Drawing.Size(220, 40);
            this.Assignment_manager.TabIndex = 9;
            this.Assignment_manager.Text = "      📚  Assignment Manager";
            this.Assignment_manager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Assignment_manager.UseVisualStyleBackColor = false;
            this.Assignment_manager.Click += new System.EventHandler(this.Assignment_manager_Click);
            // 
            // btn_logoutSidebar
            // 
            this.btn_logoutSidebar.BackColor = System.Drawing.Color.Transparent;
            this.btn_logoutSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logoutSidebar.FlatAppearance.BorderSize = 0;
            this.btn_logoutSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logoutSidebar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_logoutSidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btn_logoutSidebar.Location = new System.Drawing.Point(-6, 438);
            this.btn_logoutSidebar.Name = "btn_logoutSidebar";
            this.btn_logoutSidebar.Size = new System.Drawing.Size(226, 40);
            this.btn_logoutSidebar.TabIndex = 8;
            this.btn_logoutSidebar.Text = "      🚪  Log Out";
            this.btn_logoutSidebar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logoutSidebar.UseVisualStyleBackColor = false;
            this.btn_logoutSidebar.Click += new System.EventHandler(this.btn_logoutSidebar_Click);
            this.btn_logoutSidebar.MouseEnter += new System.EventHandler(this.btn_logoutSidebar_MouseEnter);
            this.btn_logoutSidebar.MouseLeave += new System.EventHandler(this.btn_logoutSidebar_MouseLeave);
            // 
            // btn_requestStudyLeave
            // 
            this.btn_requestStudyLeave.BackColor = System.Drawing.Color.Transparent;
            this.btn_requestStudyLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_requestStudyLeave.FlatAppearance.BorderSize = 0;
            this.btn_requestStudyLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_requestStudyLeave.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_requestStudyLeave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_requestStudyLeave.Location = new System.Drawing.Point(0, 255);
            this.btn_requestStudyLeave.Name = "btn_requestStudyLeave";
            this.btn_requestStudyLeave.Size = new System.Drawing.Size(220, 40);
            this.btn_requestStudyLeave.TabIndex = 6;
            this.btn_requestStudyLeave.Text = "      📅  Request Study Leave";
            this.btn_requestStudyLeave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_requestStudyLeave.UseVisualStyleBackColor = false;
            this.btn_requestStudyLeave.Click += new System.EventHandler(this.btn_requestStudyLeave_Click);
            this.btn_requestStudyLeave.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btn_requestStudyLeave.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btn_attendanceManagement
            // 
            this.btn_attendanceManagement.BackColor = System.Drawing.Color.Transparent;
            this.btn_attendanceManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_attendanceManagement.FlatAppearance.BorderSize = 0;
            this.btn_attendanceManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attendanceManagement.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_attendanceManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_attendanceManagement.Location = new System.Drawing.Point(0, 210);
            this.btn_attendanceManagement.Name = "btn_attendanceManagement";
            this.btn_attendanceManagement.Size = new System.Drawing.Size(220, 40);
            this.btn_attendanceManagement.TabIndex = 4;
            this.btn_attendanceManagement.Text = "      📋  Attendance Management";
            this.btn_attendanceManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_attendanceManagement.UseVisualStyleBackColor = false;
            this.btn_attendanceManagement.Click += new System.EventHandler(this.btn_attendanceManagement_Click);
            this.btn_attendanceManagement.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btn_attendanceManagement.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btn_gradeManager
            // 
            this.btn_gradeManager.BackColor = System.Drawing.Color.Transparent;
            this.btn_gradeManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gradeManager.FlatAppearance.BorderSize = 0;
            this.btn_gradeManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gradeManager.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_gradeManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_gradeManager.Location = new System.Drawing.Point(0, 120);
            this.btn_gradeManager.Name = "btn_gradeManager";
            this.btn_gradeManager.Size = new System.Drawing.Size(220, 40);
            this.btn_gradeManager.TabIndex = 2;
            this.btn_gradeManager.Text = "      🏫  Grade Manager";
            this.btn_gradeManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gradeManager.UseVisualStyleBackColor = false;
            this.btn_gradeManager.Click += new System.EventHandler(this.btn_gradeManager_Click);
            this.btn_gradeManager.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btn_gradeManager.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // pnl_sidebarDivider
            // 
            this.pnl_sidebarDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnl_sidebarDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_sidebarDivider.Location = new System.Drawing.Point(0, 60);
            this.pnl_sidebarDivider.Name = "pnl_sidebarDivider";
            this.pnl_sidebarDivider.Size = new System.Drawing.Size(220, 2);
            this.pnl_sidebarDivider.TabIndex = 1;
            // 
            // pnl_sidebarHeader
            // 
            this.pnl_sidebarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnl_sidebarHeader.Controls.Add(this.lbl_sidebarBrand);
            this.pnl_sidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_sidebarHeader.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebarHeader.Name = "pnl_sidebarHeader";
            this.pnl_sidebarHeader.Size = new System.Drawing.Size(220, 60);
            this.pnl_sidebarHeader.TabIndex = 0;
            // 
            // lbl_sidebarBrand
            // 
            this.lbl_sidebarBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_sidebarBrand.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_sidebarBrand.ForeColor = System.Drawing.Color.White;
            this.lbl_sidebarBrand.Location = new System.Drawing.Point(0, 0);
            this.lbl_sidebarBrand.Name = "lbl_sidebarBrand";
            this.lbl_sidebarBrand.Size = new System.Drawing.Size(220, 60);
            this.lbl_sidebarBrand.TabIndex = 0;
            this.lbl_sidebarBrand.Text = "🎓  SMS";
            this.lbl_sidebarBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnl_body.Controls.Add(this.lbl_welcome);
            this.pnl_body.Controls.Add(this.dgv_schedule);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(220, 70);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(740, 568);
            this.pnl_body.TabIndex = 2;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lbl_welcome.Location = new System.Drawing.Point(30, 20);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(680, 50);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome Mr. TeacherName";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_schedule
            // 
            this.dgv_schedule.AllowDrop = true;
            this.dgv_schedule.BackgroundColor = System.Drawing.Color.White;
            this.dgv_schedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_schedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_schedule.ColumnHeadersHeight = 36;
            this.dgv_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_schedule.EnableHeadersVisualStyles = false;
            this.dgv_schedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgv_schedule.Location = new System.Drawing.Point(30, 90);
            this.dgv_schedule.Name = "dgv_schedule";
            this.dgv_schedule.ReadOnly = true;
            this.dgv_schedule.RowHeadersVisible = false;
            this.dgv_schedule.RowHeadersWidth = 51;
            this.dgv_schedule.RowTemplate.Height = 28;
            this.dgv_schedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_schedule.Size = new System.Drawing.Size(680, 600);
            this.dgv_schedule.TabIndex = 1;
            // 
            // TeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(960, 638);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_sidebar);
            this.Controls.Add(this.pnl_header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TeacherDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Dashboard — School Management System";
            this.Load += new System.EventHandler(this.TeacherDashboard_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_sidebarHeader.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_teacherPanel;
        private System.Windows.Forms.Button btn_logoutHeader;

        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_sidebarHeader;
        private System.Windows.Forms.Label lbl_sidebarBrand;
        private System.Windows.Forms.Panel pnl_sidebarDivider;
        private System.Windows.Forms.Button btn_gradeManager;
        private System.Windows.Forms.Button btn_attendanceManagement;
        private System.Windows.Forms.Button btn_requestStudyLeave;
        private System.Windows.Forms.Button btn_logoutSidebar;

        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.DataGridView dgv_schedule;
        private System.Windows.Forms.Button Assignment_manager;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_settings;
    }
}