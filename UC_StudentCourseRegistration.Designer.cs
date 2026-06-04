namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class UC_StudentCourseRegistration
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
            // ── Declarations ──────────────────────────────────────
            this.pnl_pageHeader = new System.Windows.Forms.Panel();
            this.lbl_pageTitle = new System.Windows.Forms.Label();

            this.pnl_searchBar = new System.Windows.Forms.Panel();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();

            this.dgv_Courses = new System.Windows.Forms.DataGridView();

            this.pnl_actionBar = new System.Windows.Forms.Panel();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();

            // ── Suspend ───────────────────────────────────────────
            this.pnl_pageHeader.SuspendLayout();
            this.pnl_searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses)).BeginInit();
            this.pnl_actionBar.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════
            //  COLOURS
            // ════════════════════════════════════════════════════════
            System.Drawing.Color primary = System.Drawing.Color.FromArgb(30, 58, 138);
            System.Drawing.Color pageBg = System.Drawing.Color.FromArgb(241, 245, 249);
            System.Drawing.Color cardBg = System.Drawing.Color.White;
            System.Drawing.Color inputBg = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color stripBg = System.Drawing.Color.FromArgb(239, 246, 255);
            System.Drawing.Color neutral = System.Drawing.Color.FromArgb(100, 116, 139);
            System.Drawing.Color accent = System.Drawing.Color.FromArgb(59, 130, 246);
            System.Drawing.Color labelClr = System.Drawing.Color.FromArgb(51, 65, 85);

            // ════════════════════════════════════════════════════════
            //  PAGE HEADER STRIP
            // ════════════════════════════════════════════════════════
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
            this.lbl_pageTitle.Text = "  📋  Course Registration";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ════════════════════════════════════════════════════════
            //  SEARCH BAR
            // ════════════════════════════════════════════════════════
            this.pnl_searchBar.Controls.Add(this.lbl_search);
            this.pnl_searchBar.Controls.Add(this.txt_Search);
            this.pnl_searchBar.Controls.Add(this.btn_Search);
            this.pnl_searchBar.Location = new System.Drawing.Point(10, 44);
            this.pnl_searchBar.Name = "pnl_searchBar";
            this.pnl_searchBar.Size = new System.Drawing.Size(720, 36);
            this.pnl_searchBar.TabIndex = 1;

            this.lbl_search.AutoSize = false;
            this.lbl_search.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_search.ForeColor = labelClr;
            this.lbl_search.Location = new System.Drawing.Point(0, 8);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(100, 20);
            this.lbl_search.TabIndex = 0;
            this.lbl_search.Text = "🔍 Search:";

            this.txt_Search.BackColor = inputBg;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.Location = new System.Drawing.Point(100, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(200, 26);
            this.txt_Search.TabIndex = 0;

            this.btn_Search.BackColor = accent;
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
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);

            // ════════════════════════════════════════════════════════
            //  DATAGRIDVIEW – Available Courses
            // ════════════════════════════════════════════════════════
            this.dgv_Courses.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Courses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Courses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Courses.ColumnHeadersHeight = 36;
            this.dgv_Courses.EnableHeadersVisualStyles = false;
            this.dgv_Courses.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgv_Courses.Location = new System.Drawing.Point(10, 90);
            this.dgv_Courses.Name = "dgv_Courses";
            this.dgv_Courses.ReadOnly = true;
            this.dgv_Courses.RowHeadersVisible = false;
            this.dgv_Courses.RowTemplate.Height = 28;
            this.dgv_Courses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Courses.Size = new System.Drawing.Size(720, 400);
            this.dgv_Courses.TabIndex = 2;
            this.dgv_Courses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Courses_CellClick);

            // ════════════════════════════════════════════════════════
            //  ACTION BAR
            // ════════════════════════════════════════════════════════
            this.pnl_actionBar.Controls.Add(this.btn_Register);
            this.pnl_actionBar.Controls.Add(this.btn_Refresh);
            this.pnl_actionBar.Location = new System.Drawing.Point(10, 500);
            this.pnl_actionBar.Name = "pnl_actionBar";
            this.pnl_actionBar.Size = new System.Drawing.Size(720, 42);
            this.pnl_actionBar.TabIndex = 3;

            // Register button
            this.btn_Register.BackColor = accent;
            this.btn_Register.FlatAppearance.BorderSize = 0;
            this.btn_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(0, 4);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(130, 34);
            this.btn_Register.TabIndex = 0;
            this.btn_Register.Text = "➕ Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);

            // Refresh button (same as Clear)
            this.btn_Refresh.BackColor = neutral;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(140, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(130, 34);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "🔄 Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);

            // ════════════════════════════════════════════════════════
            //  USER CONTROL PROPERTIES
            // ════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = pageBg;
            this.Controls.Add(this.pnl_pageHeader);
            this.Controls.Add(this.pnl_searchBar);
            this.Controls.Add(this.dgv_Courses);
            this.Controls.Add(this.pnl_actionBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UC_StudentCourseRegistration";
            this.Size = new System.Drawing.Size(740, 568);
            this.Load += new System.EventHandler(this.UC_StudentCourseRegistration_Load);

            // ── Resume ────────────────────────────────────────────
            this.pnl_pageHeader.ResumeLayout(false);
            this.pnl_searchBar.ResumeLayout(false);
            this.pnl_searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses)).EndInit();
            this.pnl_actionBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ────────────────────────────────────
        private System.Windows.Forms.Panel pnl_pageHeader;
        private System.Windows.Forms.Label lbl_pageTitle;

        private System.Windows.Forms.Panel pnl_searchBar;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;

        private System.Windows.Forms.DataGridView dgv_Courses;

        private System.Windows.Forms.Panel pnl_actionBar;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Refresh;
    }
}