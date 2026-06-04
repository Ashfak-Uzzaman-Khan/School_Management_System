namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class UC_DepartmentManager
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
            this.btn_ShowAll = new System.Windows.Forms.Button();

            this.dgv_Departments = new System.Windows.Forms.DataGridView();
            this.lbl_studentsTitle = new System.Windows.Forms.Label();
            this.dgv_Students = new System.Windows.Forms.DataGridView();

            // ── Suspend ───────────────────────────────────────────
            this.pnl_pageHeader.SuspendLayout();
            this.pnl_searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Departments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════
            //  COLOURS
            // ════════════════════════════════════════════════════════
            System.Drawing.Color primary = System.Drawing.Color.FromArgb(30, 58, 138);
            System.Drawing.Color pageBg = System.Drawing.Color.FromArgb(241, 245, 249);
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
            this.lbl_pageTitle.Text = "  🏫  Department Manager";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ════════════════════════════════════════════════════════
            //  SEARCH BAR
            // ════════════════════════════════════════════════════════
            this.pnl_searchBar.Controls.Add(this.lbl_search);
            this.pnl_searchBar.Controls.Add(this.txt_Search);
            this.pnl_searchBar.Controls.Add(this.btn_Search);
            this.pnl_searchBar.Controls.Add(this.btn_ShowAll);
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

            // ════════════════════════════════════════════════════════
            //  DEPARTMENTS GRID
            // ════════════════════════════════════════════════════════
            this.dgv_Departments.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Departments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Departments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Departments.ColumnHeadersHeight = 36;
            this.dgv_Departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Departments.EnableHeadersVisualStyles = false;
            this.dgv_Departments.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgv_Departments.Location = new System.Drawing.Point(10, 90);
            this.dgv_Departments.Name = "dgv_Departments";
            this.dgv_Departments.ReadOnly = true;
            this.dgv_Departments.RowHeadersVisible = false;
            this.dgv_Departments.RowTemplate.Height = 28;
            this.dgv_Departments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Departments.Size = new System.Drawing.Size(720, 200);
            this.dgv_Departments.TabIndex = 2;
            this.dgv_Departments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Departments_CellClick);

            // ════════════════════════════════════════════════════════
            //  STUDENTS TITLE + GRID
            // ════════════════════════════════════════════════════════
            this.lbl_studentsTitle.AutoSize = false;
            this.lbl_studentsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_studentsTitle.ForeColor = primary;
            this.lbl_studentsTitle.Location = new System.Drawing.Point(10, 300);
            this.lbl_studentsTitle.Name = "lbl_studentsTitle";
            this.lbl_studentsTitle.Size = new System.Drawing.Size(300, 20);
            this.lbl_studentsTitle.TabIndex = 3;
            this.lbl_studentsTitle.Text = "Students in selected department:";

            this.dgv_Students.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Students.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Students.ColumnHeadersHeight = 36;
            this.dgv_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Students.EnableHeadersVisualStyles = false;
            this.dgv_Students.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgv_Students.Location = new System.Drawing.Point(10, 322);
            this.dgv_Students.Name = "dgv_Students";
            this.dgv_Students.ReadOnly = true;
            this.dgv_Students.RowHeadersVisible = false;
            this.dgv_Students.RowTemplate.Height = 28;
            this.dgv_Students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Students.Size = new System.Drawing.Size(720, 230);
            this.dgv_Students.TabIndex = 4;

            // ════════════════════════════════════════════════════════
            //  USER CONTROL PROPERTIES
            // ════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = pageBg;
            this.Controls.Add(this.pnl_pageHeader);
            this.Controls.Add(this.pnl_searchBar);
            this.Controls.Add(this.dgv_Departments);
            this.Controls.Add(this.lbl_studentsTitle);
            this.Controls.Add(this.dgv_Students);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UC_DepartmentManager";
            this.Size = new System.Drawing.Size(740, 568);
            this.Load += new System.EventHandler(this.UC_DepartmentManager_Load);

            // ── Resume ────────────────────────────────────────────
            this.pnl_pageHeader.ResumeLayout(false);
            this.pnl_searchBar.ResumeLayout(false);
            this.pnl_searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Departments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).EndInit();
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
        private System.Windows.Forms.Button btn_ShowAll;

        private System.Windows.Forms.DataGridView dgv_Departments;
        private System.Windows.Forms.Label lbl_studentsTitle;
        private System.Windows.Forms.DataGridView dgv_Students;
    }
}