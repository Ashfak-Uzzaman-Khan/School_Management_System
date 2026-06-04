namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class StudentDashboard
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
            this.lbl_studentPanel = new System.Windows.Forms.Label();
            this.btn_logoutHeader = new System.Windows.Forms.Button();
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.Assignment_submission = new System.Windows.Forms.Button();
            this.btn_logoutSidebar = new System.Windows.Forms.Button();
            this.btn_teacherReview = new System.Windows.Forms.Button();
            this.btn_attendanceStatus = new System.Windows.Forms.Button();
            this.btn_results = new System.Windows.Forms.Button();
            this.btn_payments = new System.Windows.Forms.Button();
            this.btn_registration = new System.Windows.Forms.Button();
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
            this.pnl_header.Controls.Add(this.lbl_studentPanel);
            this.pnl_header.Controls.Add(this.btn_logoutHeader);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(960, 70);
            this.pnl_header.TabIndex = 0;
            // 
            // lbl_studentPanel
            // 
            this.lbl_studentPanel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_studentPanel.ForeColor = System.Drawing.Color.White;
            this.lbl_studentPanel.Location = new System.Drawing.Point(20, 0);
            this.lbl_studentPanel.Name = "lbl_studentPanel";
            this.lbl_studentPanel.Size = new System.Drawing.Size(300, 70);
            this.lbl_studentPanel.TabIndex = 0;
            this.lbl_studentPanel.Text = "Student Panel";
            this.lbl_studentPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pnl_sidebar.Controls.Add(this.Assignment_submission);
            this.pnl_sidebar.Controls.Add(this.btn_logoutSidebar);
            this.pnl_sidebar.Controls.Add(this.btn_teacherReview);
            this.pnl_sidebar.Controls.Add(this.btn_attendanceStatus);
            this.pnl_sidebar.Controls.Add(this.btn_results);
            this.pnl_sidebar.Controls.Add(this.btn_payments);
            this.pnl_sidebar.Controls.Add(this.btn_registration);
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
            this.btn_settings.Location = new System.Drawing.Point(0, 414);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(220, 40);
            this.btn_settings.TabIndex = 11;
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
            this.btn_dashboard.TabIndex = 12;
            this.btn_dashboard.Text = "      📊  Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // Assignment_submission
            // 
            this.Assignment_submission.BackColor = System.Drawing.Color.Transparent;
            this.Assignment_submission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Assignment_submission.FlatAppearance.BorderSize = 0;
            this.Assignment_submission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Assignment_submission.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Assignment_submission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Assignment_submission.Location = new System.Drawing.Point(-3, 345);
            this.Assignment_submission.Name = "Assignment_submission";
            this.Assignment_submission.Size = new System.Drawing.Size(220, 40);
            this.Assignment_submission.TabIndex = 10;
            this.Assignment_submission.TabStop = false;
            this.Assignment_submission.Text = "      📚  Assignment Submission";
            this.Assignment_submission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Assignment_submission.UseVisualStyleBackColor = false;
            this.Assignment_submission.Click += new System.EventHandler(this.Assignment_submission_Click);
            // 
            // btn_logoutSidebar
            // 
            this.btn_logoutSidebar.BackColor = System.Drawing.Color.Transparent;
            this.btn_logoutSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logoutSidebar.FlatAppearance.BorderSize = 0;
            this.btn_logoutSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logoutSidebar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_logoutSidebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btn_logoutSidebar.Location = new System.Drawing.Point(-3, 460);
            this.btn_logoutSidebar.Name = "btn_logoutSidebar";
            this.btn_logoutSidebar.Size = new System.Drawing.Size(220, 40);
            this.btn_logoutSidebar.TabIndex = 9;
            this.btn_logoutSidebar.Text = "      🚪  Log Out";
            this.btn_logoutSidebar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logoutSidebar.UseVisualStyleBackColor = false;
            this.btn_logoutSidebar.Click += new System.EventHandler(this.btn_logoutSidebar_Click);
            this.btn_logoutSidebar.MouseEnter += new System.EventHandler(this.btn_logoutSidebar_MouseEnter);
            this.btn_logoutSidebar.MouseLeave += new System.EventHandler(this.btn_logoutSidebar_MouseLeave);
            // 
            // btn_teacherReview
            // 
            this.btn_teacherReview.BackColor = System.Drawing.Color.Transparent;
            this.btn_teacherReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teacherReview.FlatAppearance.BorderSize = 0;
            this.btn_teacherReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacherReview.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_teacherReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_teacherReview.Location = new System.Drawing.Point(0, 300);
            this.btn_teacherReview.Name = "btn_teacherReview";
            this.btn_teacherReview.Size = new System.Drawing.Size(220, 40);
            this.btn_teacherReview.TabIndex = 6;
            this.btn_teacherReview.Text = "      ⭐  Teacher Review";
            this.btn_teacherReview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teacherReview.UseVisualStyleBackColor = false;
            this.btn_teacherReview.Click += new System.EventHandler(this.btn_teacherReview_Click);
            this.btn_teacherReview.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btn_teacherReview.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btn_attendanceStatus
            // 
            this.btn_attendanceStatus.BackColor = System.Drawing.Color.Transparent;
            this.btn_attendanceStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_attendanceStatus.FlatAppearance.BorderSize = 0;
            this.btn_attendanceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attendanceStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_attendanceStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_attendanceStatus.Location = new System.Drawing.Point(0, 255);
            this.btn_attendanceStatus.Name = "btn_attendanceStatus";
            this.btn_attendanceStatus.Size = new System.Drawing.Size(220, 40);
            this.btn_attendanceStatus.TabIndex = 5;
            this.btn_attendanceStatus.Text = "      📋  Attendance Status";
            this.btn_attendanceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_attendanceStatus.UseVisualStyleBackColor = false;
            this.btn_attendanceStatus.Click += new System.EventHandler(this.btn_attendanceStatus_Click);
            this.btn_attendanceStatus.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btn_attendanceStatus.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btn_results
            // 
            this.btn_results.BackColor = System.Drawing.Color.Transparent;
            this.btn_results.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_results.FlatAppearance.BorderSize = 0;
            this.btn_results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_results.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_results.Location = new System.Drawing.Point(0, 210);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(220, 40);
            this.btn_results.TabIndex = 4;
            this.btn_results.Text = "      📊  Results";
            this.btn_results.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_results.UseVisualStyleBackColor = false;
            this.btn_results.Click += new System.EventHandler(this.btn_results_Click);
            this.btn_results.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btn_results.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btn_payments
            // 
            this.btn_payments.BackColor = System.Drawing.Color.Transparent;
            this.btn_payments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_payments.FlatAppearance.BorderSize = 0;
            this.btn_payments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payments.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_payments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_payments.Location = new System.Drawing.Point(0, 165);
            this.btn_payments.Name = "btn_payments";
            this.btn_payments.Size = new System.Drawing.Size(220, 40);
            this.btn_payments.TabIndex = 3;
            this.btn_payments.Text = "      💰  Payments";
            this.btn_payments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payments.UseVisualStyleBackColor = false;
            this.btn_payments.Click += new System.EventHandler(this.btn_payments_Click);
            this.btn_payments.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btn_payments.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btn_registration
            // 
            this.btn_registration.BackColor = System.Drawing.Color.Transparent;
            this.btn_registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registration.FlatAppearance.BorderSize = 0;
            this.btn_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registration.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_registration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_registration.Location = new System.Drawing.Point(0, 120);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(220, 40);
            this.btn_registration.TabIndex = 2;
            this.btn_registration.Text = "      📝  Registration";
            this.btn_registration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registration.UseVisualStyleBackColor = false;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            this.btn_registration.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btn_registration.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
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
            this.lbl_welcome.Text = "Welcome Mr. StudentName";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_schedule
            // 
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
            // StudentDashboard
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
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Dashboard — School Management System";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_sidebarHeader.ResumeLayout(false);
            this.pnl_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_studentPanel;
        private System.Windows.Forms.Button btn_logoutHeader;

        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_sidebarHeader;
        private System.Windows.Forms.Label lbl_sidebarBrand;
        private System.Windows.Forms.Panel pnl_sidebarDivider;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Button btn_payments;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.Button btn_attendanceStatus;
        private System.Windows.Forms.Button btn_teacherReview;
        private System.Windows.Forms.Button btn_logoutSidebar;

        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.DataGridView dgv_schedule;
        private System.Windows.Forms.Button Assignment_submission;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_settings;
    }
}