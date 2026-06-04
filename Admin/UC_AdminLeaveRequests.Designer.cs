namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class UC_AdminLeaveRequests
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
            this.btn_ShowAll = new System.Windows.Forms.Button();

            this.dgv_LeaveRequests = new System.Windows.Forms.DataGridView();

            this.pnl_actionBar = new System.Windows.Forms.Panel();
            this.btn_Approve = new System.Windows.Forms.Button();
            this.btn_Decline = new System.Windows.Forms.Button();
            this.btn_Pending = new System.Windows.Forms.Button();

            this.pnl_pageHeader.SuspendLayout();
            this.pnl_searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LeaveRequests)).BeginInit();
            this.pnl_actionBar.SuspendLayout();
            this.SuspendLayout();

            // Colours
            System.Drawing.Color primary = System.Drawing.Color.FromArgb(30, 58, 138);
            System.Drawing.Color pageBg = System.Drawing.Color.FromArgb(241, 245, 249);
            System.Drawing.Color inputBg = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color stripBg = System.Drawing.Color.FromArgb(239, 246, 255);
            System.Drawing.Color neutral = System.Drawing.Color.FromArgb(100, 116, 139);
            System.Drawing.Color accent = System.Drawing.Color.FromArgb(59, 130, 246);
            System.Drawing.Color success = System.Drawing.Color.FromArgb(22, 163, 74);
            System.Drawing.Color danger = System.Drawing.Color.FromArgb(220, 38, 38);
            System.Drawing.Color warning = System.Drawing.Color.FromArgb(234, 88, 12);
            System.Drawing.Color labelClr = System.Drawing.Color.FromArgb(51, 65, 85);

            // Page Header
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
            this.lbl_pageTitle.Text = "  📅  Leave Requests Manager";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Search Bar
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
            this.lbl_search.Text = "🔍 Teacher:";

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

            // DataGridView
            this.dgv_LeaveRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgv_LeaveRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_LeaveRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_LeaveRequests.ColumnHeadersHeight = 36;
            this.dgv_LeaveRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_LeaveRequests.EnableHeadersVisualStyles = false;
            this.dgv_LeaveRequests.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgv_LeaveRequests.Location = new System.Drawing.Point(10, 90);
            this.dgv_LeaveRequests.Name = "dgv_LeaveRequests";
            this.dgv_LeaveRequests.ReadOnly = true;
            this.dgv_LeaveRequests.RowHeadersVisible = false;
            this.dgv_LeaveRequests.RowTemplate.Height = 28;
            this.dgv_LeaveRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LeaveRequests.Size = new System.Drawing.Size(720, 420);
            this.dgv_LeaveRequests.TabIndex = 2;
            this.dgv_LeaveRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LeaveRequests_CellClick);

            // Action Bar (status change)
            this.pnl_actionBar.Controls.Add(this.btn_Approve);
            this.pnl_actionBar.Controls.Add(this.btn_Decline);
            this.pnl_actionBar.Controls.Add(this.btn_Pending);
            this.pnl_actionBar.Location = new System.Drawing.Point(10, 518);
            this.pnl_actionBar.Name = "pnl_actionBar";
            this.pnl_actionBar.Size = new System.Drawing.Size(720, 40);
            this.pnl_actionBar.TabIndex = 3;

            this.btn_Approve.BackColor = success;
            this.btn_Approve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Approve.FlatAppearance.BorderSize = 0;
            this.btn_Approve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btn_Approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Approve.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Approve.ForeColor = System.Drawing.Color.White;
            this.btn_Approve.Location = new System.Drawing.Point(0, 3);
            this.btn_Approve.Name = "btn_Approve";
            this.btn_Approve.Size = new System.Drawing.Size(130, 34);
            this.btn_Approve.TabIndex = 0;
            this.btn_Approve.Text = "✅ Approve";
            this.btn_Approve.UseVisualStyleBackColor = false;
            this.btn_Approve.Click += new System.EventHandler(this.btn_Approve_Click);

            this.btn_Decline.BackColor = danger;
            this.btn_Decline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Decline.FlatAppearance.BorderSize = 0;
            this.btn_Decline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btn_Decline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Decline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Decline.ForeColor = System.Drawing.Color.White;
            this.btn_Decline.Location = new System.Drawing.Point(140, 3);
            this.btn_Decline.Name = "btn_Decline";
            this.btn_Decline.Size = new System.Drawing.Size(130, 34);
            this.btn_Decline.TabIndex = 1;
            this.btn_Decline.Text = "❌ Decline";
            this.btn_Decline.UseVisualStyleBackColor = false;
            this.btn_Decline.Click += new System.EventHandler(this.btn_Decline_Click);

            this.btn_Pending.BackColor = warning;
            this.btn_Pending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pending.FlatAppearance.BorderSize = 0;
            this.btn_Pending.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(194, 65, 12);
            this.btn_Pending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pending.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Pending.ForeColor = System.Drawing.Color.White;
            this.btn_Pending.Location = new System.Drawing.Point(280, 3);
            this.btn_Pending.Name = "btn_Pending";
            this.btn_Pending.Size = new System.Drawing.Size(130, 34);
            this.btn_Pending.TabIndex = 2;
            this.btn_Pending.Text = "🔄 Set Pending";
            this.btn_Pending.UseVisualStyleBackColor = false;
            this.btn_Pending.Click += new System.EventHandler(this.btn_Pending_Click);

            // User Control
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = pageBg;
            this.Controls.Add(this.pnl_pageHeader);
            this.Controls.Add(this.pnl_searchBar);
            this.Controls.Add(this.dgv_LeaveRequests);
            this.Controls.Add(this.pnl_actionBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UC_AdminLeaveRequests";
            this.Size = new System.Drawing.Size(740, 568);
            this.Load += new System.EventHandler(this.UC_AdminLeaveRequests_Load);

            this.pnl_pageHeader.ResumeLayout(false);
            this.pnl_searchBar.ResumeLayout(false);
            this.pnl_searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LeaveRequests)).EndInit();
            this.pnl_actionBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_pageHeader;
        private System.Windows.Forms.Label lbl_pageTitle;

        private System.Windows.Forms.Panel pnl_searchBar;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ShowAll;

        private System.Windows.Forms.DataGridView dgv_LeaveRequests;

        private System.Windows.Forms.Panel pnl_actionBar;
        private System.Windows.Forms.Button btn_Approve;
        private System.Windows.Forms.Button btn_Decline;
        private System.Windows.Forms.Button btn_Pending;
    }
}