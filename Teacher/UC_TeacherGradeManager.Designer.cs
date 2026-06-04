namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class UC_TeacherGradeManager
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

            this.pnl_searchBar = new System.Windows.Forms.Panel();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();

            this.dgv_Grades = new System.Windows.Forms.DataGridView();

            this.pnl_editCard = new System.Windows.Forms.Panel();
            this.pnl_editHeader = new System.Windows.Forms.Panel();
            this.lbl_editTitle = new System.Windows.Forms.Label();
            this.lbl_grade = new System.Windows.Forms.Label();
            this.cmb_Grade = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();

            // ── Suspend ───────────────────────────────────────────
            this.pnl_pageHeader.SuspendLayout();
            this.pnl_searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grades)).BeginInit();
            this.pnl_editCard.SuspendLayout();
            this.pnl_editHeader.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Color primary = System.Drawing.Color.FromArgb(30, 58, 138);
            System.Drawing.Color pageBg = System.Drawing.Color.FromArgb(241, 245, 249);
            System.Drawing.Color cardBg = System.Drawing.Color.White;
            System.Drawing.Color inputBg = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color stripBg = System.Drawing.Color.FromArgb(239, 246, 255);
            System.Drawing.Color accent = System.Drawing.Color.FromArgb(59, 130, 246);
            System.Drawing.Color neutral = System.Drawing.Color.FromArgb(100, 116, 139);
            System.Drawing.Color labelClr = System.Drawing.Color.FromArgb(51, 65, 85);

            // Page header
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
            this.lbl_pageTitle.Text = "  🏫  Grade Manager";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Search bar
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
            this.txt_Search.Size = new System.Drawing.Size(250, 26);
            this.txt_Search.TabIndex = 0;

            this.btn_Search.BackColor = accent;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(360, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 26);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);

            // DataGridView
            this.dgv_Grades.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Grades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Grades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Grades.ColumnHeadersHeight = 36;
            this.dgv_Grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Grades.EnableHeadersVisualStyles = false;
            this.dgv_Grades.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgv_Grades.Location = new System.Drawing.Point(10, 86);
            this.dgv_Grades.Name = "dgv_Grades";
            this.dgv_Grades.ReadOnly = true;
            this.dgv_Grades.RowHeadersVisible = false;
            this.dgv_Grades.RowTemplate.Height = 28;
            this.dgv_Grades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Grades.Size = new System.Drawing.Size(720, 230);
            this.dgv_Grades.TabIndex = 2;
            this.dgv_Grades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Grades_CellClick);

            // Edit card
            this.pnl_editCard.BackColor = cardBg;
            this.pnl_editCard.Controls.Add(this.pnl_editHeader);
            this.pnl_editCard.Controls.Add(this.lbl_grade);
            this.pnl_editCard.Controls.Add(this.cmb_Grade);
            this.pnl_editCard.Controls.Add(this.btn_Save);
            this.pnl_editCard.Controls.Add(this.btn_Clear);
            this.pnl_editCard.Location = new System.Drawing.Point(10, 326);
            this.pnl_editCard.Name = "pnl_editCard";
            this.pnl_editCard.Size = new System.Drawing.Size(720, 80);
            this.pnl_editCard.TabIndex = 3;

            this.pnl_editHeader.BackColor = stripBg;
            this.pnl_editHeader.Controls.Add(this.lbl_editTitle);
            this.pnl_editHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_editHeader.Location = new System.Drawing.Point(0, 0);
            this.pnl_editHeader.Name = "pnl_editHeader";
            this.pnl_editHeader.Size = new System.Drawing.Size(720, 26);
            this.pnl_editHeader.TabIndex = 0;

            this.lbl_editTitle.AutoSize = false;
            this.lbl_editTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_editTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_editTitle.ForeColor = primary;
            this.lbl_editTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_editTitle.Name = "lbl_editTitle";
            this.lbl_editTitle.Size = new System.Drawing.Size(720, 26);
            this.lbl_editTitle.TabIndex = 0;
            this.lbl_editTitle.Text = "  Edit Selected Grade";
            this.lbl_editTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lbl_grade.AutoSize = false;
            this.lbl_grade.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_grade.ForeColor = labelClr;
            this.lbl_grade.Location = new System.Drawing.Point(20, 34);
            this.lbl_grade.Name = "lbl_grade";
            this.lbl_grade.Size = new System.Drawing.Size(80, 20);
            this.lbl_grade.TabIndex = 1;
            this.lbl_grade.Text = "Grade:";

            this.cmb_Grade.BackColor = inputBg;
            this.cmb_Grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Grade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_Grade.FormattingEnabled = true;
            this.cmb_Grade.Location = new System.Drawing.Point(100, 32);
            this.cmb_Grade.Name = "cmb_Grade";
            this.cmb_Grade.Size = new System.Drawing.Size(180, 26);
            this.cmb_Grade.TabIndex = 0;

            this.btn_Save.BackColor = accent;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(300, 32);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 26);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);

            this.btn_Clear.BackColor = neutral;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(390, 32);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(80, 26);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);

            // UserControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = pageBg;
            this.Controls.Add(this.pnl_pageHeader);
            this.Controls.Add(this.pnl_searchBar);
            this.Controls.Add(this.dgv_Grades);
            this.Controls.Add(this.pnl_editCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UC_TeacherGradeManager";
            this.Size = new System.Drawing.Size(740, 568);
            this.Load += new System.EventHandler(this.UC_TeacherGradeManager_Load);

            this.pnl_pageHeader.ResumeLayout(false);
            this.pnl_searchBar.ResumeLayout(false);
            this.pnl_searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grades)).EndInit();
            this.pnl_editCard.ResumeLayout(false);
            this.pnl_editCard.PerformLayout();
            this.pnl_editHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_pageHeader;
        private System.Windows.Forms.Label lbl_pageTitle;

        private System.Windows.Forms.Panel pnl_searchBar;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;

        private System.Windows.Forms.DataGridView dgv_Grades;

        private System.Windows.Forms.Panel pnl_editCard;
        private System.Windows.Forms.Panel pnl_editHeader;
        private System.Windows.Forms.Label lbl_editTitle;
        private System.Windows.Forms.Label lbl_grade;
        private System.Windows.Forms.ComboBox cmb_Grade;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
    }
}