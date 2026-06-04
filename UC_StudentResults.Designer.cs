namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class UC_StudentResults
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

            this.pnl_infoCard = new System.Windows.Forms.Panel();
            this.lbl_infoTitle = new System.Windows.Forms.Label();
            this.lbl_cgpa = new System.Windows.Forms.Label();

            this.pnl_searchBar = new System.Windows.Forms.Panel();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();

            this.dgv_Results = new System.Windows.Forms.DataGridView();

            this.pnl_pageHeader.SuspendLayout();
            this.pnl_infoCard.SuspendLayout();
            this.pnl_searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Results)).BeginInit();
            this.SuspendLayout();

            System.Drawing.Color primary = System.Drawing.Color.FromArgb(30, 58, 138);
            System.Drawing.Color pageBg = System.Drawing.Color.FromArgb(241, 245, 249);
            System.Drawing.Color cardBg = System.Drawing.Color.White;
            System.Drawing.Color inputBg = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color stripBg = System.Drawing.Color.FromArgb(239, 246, 255);
            System.Drawing.Color accent = System.Drawing.Color.FromArgb(59, 130, 246);
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
            this.lbl_pageTitle.Text = "  📊  Results";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Info card (CGPA)
            this.pnl_infoCard.BackColor = cardBg;
            this.pnl_infoCard.Controls.Add(this.lbl_infoTitle);
            this.pnl_infoCard.Controls.Add(this.lbl_cgpa);
            this.pnl_infoCard.Location = new System.Drawing.Point(10, 44);
            this.pnl_infoCard.Name = "pnl_infoCard";
            this.pnl_infoCard.Size = new System.Drawing.Size(720, 60);
            this.pnl_infoCard.TabIndex = 1;

            this.lbl_infoTitle.AutoSize = false;
            this.lbl_infoTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_infoTitle.ForeColor = primary;
            this.lbl_infoTitle.Location = new System.Drawing.Point(20, 10);
            this.lbl_infoTitle.Name = "lbl_infoTitle";
            this.lbl_infoTitle.Size = new System.Drawing.Size(200, 24);
            this.lbl_infoTitle.TabIndex = 0;
            this.lbl_infoTitle.Text = "Your CGPA";

            this.lbl_cgpa.AutoSize = false;
            this.lbl_cgpa.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_cgpa.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lbl_cgpa.Location = new System.Drawing.Point(400, 10);
            this.lbl_cgpa.Name = "lbl_cgpa";
            this.lbl_cgpa.Size = new System.Drawing.Size(300, 40);
            this.lbl_cgpa.TabIndex = 1;
            this.lbl_cgpa.Text = "0.00";
            this.lbl_cgpa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // Search bar
            this.pnl_searchBar.Controls.Add(this.lbl_search);
            this.pnl_searchBar.Controls.Add(this.txt_Search);
            this.pnl_searchBar.Controls.Add(this.btn_Search);
            this.pnl_searchBar.Location = new System.Drawing.Point(10, 114);
            this.pnl_searchBar.Name = "pnl_searchBar";
            this.pnl_searchBar.Size = new System.Drawing.Size(720, 36);
            this.pnl_searchBar.TabIndex = 2;

            this.lbl_search.AutoSize = false;
            this.lbl_search.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_search.ForeColor = labelClr;
            this.lbl_search.Location = new System.Drawing.Point(0, 8);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(100, 20);
            this.lbl_search.TabIndex = 0;
            this.lbl_search.Text = "🔍 Course:";

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
            this.dgv_Results.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Results.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Results.ColumnHeadersHeight = 36;
            this.dgv_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Results.EnableHeadersVisualStyles = false;
            this.dgv_Results.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgv_Results.Location = new System.Drawing.Point(10, 160);
            this.dgv_Results.Name = "dgv_Results";
            this.dgv_Results.ReadOnly = true;
            this.dgv_Results.RowHeadersVisible = false;
            this.dgv_Results.RowTemplate.Height = 28;
            this.dgv_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Results.Size = new System.Drawing.Size(720, 395);
            this.dgv_Results.TabIndex = 3;

            // UserControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = pageBg;
            this.Controls.Add(this.pnl_pageHeader);
            this.Controls.Add(this.pnl_infoCard);
            this.Controls.Add(this.pnl_searchBar);
            this.Controls.Add(this.dgv_Results);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UC_StudentResults";
            this.Size = new System.Drawing.Size(740, 568);
            this.Load += new System.EventHandler(this.UC_StudentResults_Load);

            this.pnl_pageHeader.ResumeLayout(false);
            this.pnl_infoCard.ResumeLayout(false);
            this.pnl_searchBar.ResumeLayout(false);
            this.pnl_searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Results)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_pageHeader;
        private System.Windows.Forms.Label lbl_pageTitle;

        private System.Windows.Forms.Panel pnl_infoCard;
        private System.Windows.Forms.Label lbl_infoTitle;
        private System.Windows.Forms.Label lbl_cgpa;

        private System.Windows.Forms.Panel pnl_searchBar;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;

        private System.Windows.Forms.DataGridView dgv_Results;
    }
}