namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class UC_CourseManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnl_pageHeader = new System.Windows.Forms.Panel();
            this.lbl_pageTitle = new System.Windows.Forms.Label();
            this.pnl_formCard = new System.Windows.Forms.Panel();
            this.pnl_formHeader = new System.Windows.Forms.Panel();
            this.lbl_formTitle = new System.Windows.Forms.Label();
            this.lbl_courseName = new System.Windows.Forms.Label();
            this.txt_CourseName = new System.Windows.Forms.TextBox();
            this.lbl_dayOfWeek = new System.Windows.Forms.Label();
            this.cmb_DayOfWeek = new System.Windows.Forms.ComboBox();
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.dtp_StartTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_endTime = new System.Windows.Forms.Label();
            this.dtp_EndTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_courseFee = new System.Windows.Forms.Label();
            this.txt_CourseFee = new System.Windows.Forms.TextBox();
            this.lbl_teacher = new System.Windows.Forms.Label();
            this.cmb_Teacher = new System.Windows.Forms.ComboBox();
            this.pnl_actionBar = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.pnl_searchBar = new System.Windows.Forms.Panel();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.dgv_Courses = new System.Windows.Forms.DataGridView();
            this.lbl_studentsTitle = new System.Windows.Forms.Label();
            this.dgv_Students = new System.Windows.Forms.DataGridView();

            this.pnl_pageHeader.SuspendLayout();
            this.pnl_formCard.SuspendLayout();
            this.pnl_formHeader.SuspendLayout();
            this.pnl_actionBar.SuspendLayout();
            this.pnl_searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).BeginInit();
            this.SuspendLayout();

            // ── Colours ────────────────────────────────────────────
            System.Drawing.Color primary = System.Drawing.Color.FromArgb(30, 58, 138);
            System.Drawing.Color pageBg = System.Drawing.Color.FromArgb(241, 245, 249);
            System.Drawing.Color cardBg = System.Drawing.Color.White;
            System.Drawing.Color inputBg = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color stripBg = System.Drawing.Color.FromArgb(239, 246, 255);
            System.Drawing.Color neutral = System.Drawing.Color.FromArgb(100, 116, 139);
            System.Drawing.Color danger = System.Drawing.Color.FromArgb(220, 38, 38);
            System.Drawing.Color success = System.Drawing.Color.FromArgb(22, 163, 74);
            System.Drawing.Color accent = System.Drawing.Color.FromArgb(59, 130, 246);
            System.Drawing.Color labelClr = System.Drawing.Color.FromArgb(51, 65, 85);

            // ── pnl_pageHeader ─────────────────────────────────────
            this.pnl_pageHeader.BackColor = stripBg;
            this.pnl_pageHeader.Controls.Add(this.lbl_pageTitle);
            this.pnl_pageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pnl_pageHeader.Name = "pnl_pageHeader";
            this.pnl_pageHeader.Size = new System.Drawing.Size(740, 34);
            this.pnl_pageHeader.TabIndex = 0;

            this.lbl_pageTitle.AutoSize = false;
            this.lbl_pageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_pageTitle.ForeColor = primary;
            this.lbl_pageTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_pageTitle.Name = "lbl_pageTitle";
            this.lbl_pageTitle.Size = new System.Drawing.Size(740, 34);
            this.lbl_pageTitle.TabIndex = 0;
            this.lbl_pageTitle.Text = "  📚  Course Manager";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── pnl_formCard ───────────────────────────────────────
            this.pnl_formCard.BackColor = cardBg;
            this.pnl_formCard.Controls.Add(this.pnl_formHeader);
            this.pnl_formCard.Controls.Add(this.lbl_courseName);
            this.pnl_formCard.Controls.Add(this.txt_CourseName);
            this.pnl_formCard.Controls.Add(this.lbl_dayOfWeek);
            this.pnl_formCard.Controls.Add(this.cmb_DayOfWeek);
            this.pnl_formCard.Controls.Add(this.lbl_startTime);
            this.pnl_formCard.Controls.Add(this.dtp_StartTime);
            this.pnl_formCard.Controls.Add(this.lbl_endTime);
            this.pnl_formCard.Controls.Add(this.dtp_EndTime);
            this.pnl_formCard.Controls.Add(this.lbl_courseFee);
            this.pnl_formCard.Controls.Add(this.txt_CourseFee);
            this.pnl_formCard.Controls.Add(this.lbl_teacher);
            this.pnl_formCard.Controls.Add(this.cmb_Teacher);
            this.pnl_formCard.Location = new System.Drawing.Point(10, 44);
            this.pnl_formCard.Name = "pnl_formCard";
            this.pnl_formCard.Size = new System.Drawing.Size(720, 200);
            this.pnl_formCard.TabIndex = 1;

            this.pnl_formHeader.BackColor = stripBg;
            this.pnl_formHeader.Controls.Add(this.lbl_formTitle);
            this.pnl_formHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_formHeader.Location = new System.Drawing.Point(0, 0);
            this.pnl_formHeader.Name = "pnl_formHeader";
            this.pnl_formHeader.Size = new System.Drawing.Size(720, 30);
            this.pnl_formHeader.TabIndex = 0;

            this.lbl_formTitle.AutoSize = false;
            this.lbl_formTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_formTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_formTitle.ForeColor = primary;
            this.lbl_formTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_formTitle.Name = "lbl_formTitle";
            this.lbl_formTitle.Size = new System.Drawing.Size(720, 30);
            this.lbl_formTitle.TabIndex = 0;
            this.lbl_formTitle.Text = "  Course Details";
            this.lbl_formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            int leftX = 14, midX = 204, rightX = 398, right2X = 590;

            // Course Name
            this.lbl_courseName.AutoSize = false;
            this.lbl_courseName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_courseName.ForeColor = labelClr;
            this.lbl_courseName.Location = new System.Drawing.Point(leftX, 38);
            this.lbl_courseName.Name = "lbl_courseName";
            this.lbl_courseName.Size = new System.Drawing.Size(180, 20);
            this.lbl_courseName.Text = "Course Name";

            this.txt_CourseName.BackColor = inputBg;
            this.txt_CourseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CourseName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CourseName.Location = new System.Drawing.Point(leftX, 60);
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.Size = new System.Drawing.Size(180, 26);
            this.txt_CourseName.TabIndex = 0;

            // Day of Week
            this.lbl_dayOfWeek.AutoSize = false;
            this.lbl_dayOfWeek.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_dayOfWeek.ForeColor = labelClr;
            this.lbl_dayOfWeek.Location = new System.Drawing.Point(midX, 38);
            this.lbl_dayOfWeek.Name = "lbl_dayOfWeek";
            this.lbl_dayOfWeek.Size = new System.Drawing.Size(180, 20);
            this.lbl_dayOfWeek.Text = "Day of Week";

            this.cmb_DayOfWeek.BackColor = inputBg;
            this.cmb_DayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DayOfWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_DayOfWeek.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_DayOfWeek.FormattingEnabled = true;
            this.cmb_DayOfWeek.Location = new System.Drawing.Point(midX, 60);
            this.cmb_DayOfWeek.Name = "cmb_DayOfWeek";
            this.cmb_DayOfWeek.Size = new System.Drawing.Size(180, 26);
            this.cmb_DayOfWeek.TabIndex = 1;

            // Start Time
            this.lbl_startTime.AutoSize = false;
            this.lbl_startTime.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_startTime.ForeColor = labelClr;
            this.lbl_startTime.Location = new System.Drawing.Point(rightX, 38);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(180, 20);
            this.lbl_startTime.Text = "Start Time";

            this.dtp_StartTime.CustomFormat = "HH:mm";
            this.dtp_StartTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartTime.Location = new System.Drawing.Point(rightX, 60);
            this.dtp_StartTime.Name = "dtp_StartTime";
            this.dtp_StartTime.ShowUpDown = true;
            this.dtp_StartTime.Size = new System.Drawing.Size(180, 26);
            this.dtp_StartTime.TabIndex = 2;

            // End Time
            this.lbl_endTime.AutoSize = false;
            this.lbl_endTime.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_endTime.ForeColor = labelClr;
            this.lbl_endTime.Location = new System.Drawing.Point(right2X, 38);
            this.lbl_endTime.Name = "lbl_endTime";
            this.lbl_endTime.Size = new System.Drawing.Size(120, 20);
            this.lbl_endTime.Text = "End Time";

            this.dtp_EndTime.CustomFormat = "HH:mm";
            this.dtp_EndTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndTime.Location = new System.Drawing.Point(right2X, 60);
            this.dtp_EndTime.Name = "dtp_EndTime";
            this.dtp_EndTime.ShowUpDown = true;
            this.dtp_EndTime.Size = new System.Drawing.Size(120, 26);
            this.dtp_EndTime.TabIndex = 3;

            // Course Fee
            this.lbl_courseFee.AutoSize = false;
            this.lbl_courseFee.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_courseFee.ForeColor = labelClr;
            this.lbl_courseFee.Location = new System.Drawing.Point(leftX, 94);
            this.lbl_courseFee.Name = "lbl_courseFee";
            this.lbl_courseFee.Size = new System.Drawing.Size(180, 20);
            this.lbl_courseFee.Text = "Course Fee";

            this.txt_CourseFee.BackColor = inputBg;
            this.txt_CourseFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CourseFee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CourseFee.Location = new System.Drawing.Point(leftX, 116);
            this.txt_CourseFee.Name = "txt_CourseFee";
            this.txt_CourseFee.Size = new System.Drawing.Size(180, 26);
            this.txt_CourseFee.TabIndex = 4;

            // Teacher
            this.lbl_teacher.AutoSize = false;
            this.lbl_teacher.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_teacher.ForeColor = labelClr;
            this.lbl_teacher.Location = new System.Drawing.Point(midX, 94);
            this.lbl_teacher.Name = "lbl_teacher";
            this.lbl_teacher.Size = new System.Drawing.Size(180, 20);
            this.lbl_teacher.Text = "Assign Teacher";

            this.cmb_Teacher.BackColor = inputBg;
            this.cmb_Teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Teacher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_Teacher.FormattingEnabled = true;
            this.cmb_Teacher.Location = new System.Drawing.Point(midX, 116);
            this.cmb_Teacher.Name = "cmb_Teacher";
            this.cmb_Teacher.Size = new System.Drawing.Size(180, 26);
            this.cmb_Teacher.TabIndex = 5;

            // ── pnl_actionBar ──────────────────────────────────────
            this.pnl_actionBar.Controls.Add(this.btn_Add);
            this.pnl_actionBar.Controls.Add(this.btn_Update);
            this.pnl_actionBar.Controls.Add(this.btn_Delete);
            this.pnl_actionBar.Controls.Add(this.btn_Clear);
            this.pnl_actionBar.Location = new System.Drawing.Point(10, 252);
            this.pnl_actionBar.Name = "pnl_actionBar";
            this.pnl_actionBar.Size = new System.Drawing.Size(720, 42);
            this.pnl_actionBar.TabIndex = 2;

            this.btn_Add.BackColor = accent;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(0, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(130, 34);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "➕ Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);

            this.btn_Update.BackColor = success;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(140, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(130, 34);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "✏️ Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);

            this.btn_Delete.BackColor = danger;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(280, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(130, 34);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "🗑 Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);

            this.btn_Clear.BackColor = neutral;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(420, 4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(130, 34);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "🔄 Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);

            // ── pnl_searchBar ──────────────────────────────────────
            this.pnl_searchBar.Controls.Add(this.lbl_search);
            this.pnl_searchBar.Controls.Add(this.txt_Search);
            this.pnl_searchBar.Controls.Add(this.btn_Search);
            this.pnl_searchBar.Controls.Add(this.btn_ShowAll);
            this.pnl_searchBar.Location = new System.Drawing.Point(10, 300);
            this.pnl_searchBar.Name = "pnl_searchBar";
            this.pnl_searchBar.Size = new System.Drawing.Size(720, 36);
            this.pnl_searchBar.TabIndex = 3;

            this.lbl_search.AutoSize = false;
            this.lbl_search.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_search.ForeColor = labelClr;
            this.lbl_search.Location = new System.Drawing.Point(0, 8);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(100, 20);
            this.lbl_search.Text = "🔍 Search:";

            this.txt_Search.BackColor = inputBg;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.Location = new System.Drawing.Point(100, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(200, 26);
            this.txt_Search.TabIndex = 0;

            this.btn_Search.BackColor = accent;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(310, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 26);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);

            this.btn_ShowAll.BackColor = neutral;
            this.btn_ShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowAll.FlatAppearance.BorderSize = 0;
            this.btn_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_ShowAll.ForeColor = System.Drawing.Color.White;
            this.btn_ShowAll.Location = new System.Drawing.Point(400, 5);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(80, 26);
            this.btn_ShowAll.TabIndex = 2;
            this.btn_ShowAll.Text = "Show All";
            this.btn_ShowAll.UseVisualStyleBackColor = false;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);

            // ── dgv_Courses (taller, scroll enabled) ────────────────
            this.dgv_Courses.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Courses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Courses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Courses.ColumnHeadersHeight = 36;
            this.dgv_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Courses.EnableHeadersVisualStyles = false;
            this.dgv_Courses.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgv_Courses.Location = new System.Drawing.Point(10, 342);
            this.dgv_Courses.Name = "dgv_Courses";
            this.dgv_Courses.ReadOnly = true;
            this.dgv_Courses.RowHeadersVisible = false;
            this.dgv_Courses.RowTemplate.Height = 28;
            this.dgv_Courses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Courses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Courses.Size = new System.Drawing.Size(720, 180);   // increased
            this.dgv_Courses.TabIndex = 4;
            this.dgv_Courses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Courses_CellClick);

            // ── lbl_studentsTitle ─────────────────────────────────
            this.lbl_studentsTitle.AutoSize = false;
            this.lbl_studentsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_studentsTitle.ForeColor = primary;
            this.lbl_studentsTitle.Location = new System.Drawing.Point(10, 528);
            this.lbl_studentsTitle.Name = "lbl_studentsTitle";
            this.lbl_studentsTitle.Size = new System.Drawing.Size(200, 20);
            this.lbl_studentsTitle.Text = "Registered Students:";

            // ── dgv_Students (taller, scroll enabled) ──────────────
            this.dgv_Students.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Students.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Students.ColumnHeadersHeight = 36;
            this.dgv_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Students.EnableHeadersVisualStyles = false;
            this.dgv_Students.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgv_Students.Location = new System.Drawing.Point(10, 550);
            this.dgv_Students.Name = "dgv_Students";
            this.dgv_Students.ReadOnly = true;
            this.dgv_Students.RowHeadersVisible = false;
            this.dgv_Students.RowTemplate.Height = 28;
            this.dgv_Students.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Students.Size = new System.Drawing.Size(720, 100);   // increased
            this.dgv_Students.TabIndex = 6;

            // ── UserControl (AutoScroll = true) ──────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = pageBg;
            this.Controls.Add(this.pnl_pageHeader);
            this.Controls.Add(this.pnl_formCard);
            this.Controls.Add(this.pnl_actionBar);
            this.Controls.Add(this.pnl_searchBar);
            this.Controls.Add(this.dgv_Courses);
            this.Controls.Add(this.lbl_studentsTitle);
            this.Controls.Add(this.dgv_Students);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UC_CourseManager";
            this.Size = new System.Drawing.Size(740, 568);
            this.Load += new System.EventHandler(this.UC_CourseManager_Load);

            this.pnl_pageHeader.ResumeLayout(false);
            this.pnl_formCard.ResumeLayout(false);
            this.pnl_formCard.PerformLayout();
            this.pnl_formHeader.ResumeLayout(false);
            this.pnl_actionBar.ResumeLayout(false);
            this.pnl_searchBar.ResumeLayout(false);
            this.pnl_searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_pageHeader;
        private System.Windows.Forms.Label lbl_pageTitle;
        private System.Windows.Forms.Panel pnl_formCard;
        private System.Windows.Forms.Panel pnl_formHeader;
        private System.Windows.Forms.Label lbl_formTitle;
        private System.Windows.Forms.Label lbl_courseName;
        private System.Windows.Forms.TextBox txt_CourseName;
        private System.Windows.Forms.Label lbl_dayOfWeek;
        private System.Windows.Forms.ComboBox cmb_DayOfWeek;
        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.DateTimePicker dtp_StartTime;
        private System.Windows.Forms.Label lbl_endTime;
        private System.Windows.Forms.DateTimePicker dtp_EndTime;
        private System.Windows.Forms.Label lbl_courseFee;
        private System.Windows.Forms.TextBox txt_CourseFee;
        private System.Windows.Forms.Label lbl_teacher;
        private System.Windows.Forms.ComboBox cmb_Teacher;
        private System.Windows.Forms.Panel pnl_actionBar;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel pnl_searchBar;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.DataGridView dgv_Courses;
        private System.Windows.Forms.Label lbl_studentsTitle;
        private System.Windows.Forms.DataGridView dgv_Students;
    }
}