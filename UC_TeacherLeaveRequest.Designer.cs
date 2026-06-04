namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class UC_TeacherLeaveRequest
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
            this.lbl_message = new System.Windows.Forms.Label();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();

            this.dgv_MyRequests = new System.Windows.Forms.DataGridView();

            this.pnl_pageHeader.SuspendLayout();
            this.pnl_formCard.SuspendLayout();
            this.pnl_formHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MyRequests)).BeginInit();
            this.SuspendLayout();

            // Colours
            System.Drawing.Color primary = System.Drawing.Color.FromArgb(30, 58, 138);
            System.Drawing.Color pageBg = System.Drawing.Color.FromArgb(241, 245, 249);
            System.Drawing.Color cardBg = System.Drawing.Color.White;
            System.Drawing.Color inputBg = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color stripBg = System.Drawing.Color.FromArgb(239, 246, 255);
            System.Drawing.Color success = System.Drawing.Color.FromArgb(22, 163, 74);
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
            this.lbl_pageTitle.Text = "  📅  Request Study Leave";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Form Card
            this.pnl_formCard.BackColor = cardBg;
            this.pnl_formCard.Controls.Add(this.pnl_formHeader);
            this.pnl_formCard.Controls.Add(this.lbl_message);
            this.pnl_formCard.Controls.Add(this.txt_Message);
            this.pnl_formCard.Controls.Add(this.btn_Submit);
            this.pnl_formCard.Location = new System.Drawing.Point(10, 44);
            this.pnl_formCard.Name = "pnl_formCard";
            this.pnl_formCard.Size = new System.Drawing.Size(720, 170);
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
            this.lbl_formTitle.Text = "  Submit New Leave Request";
            this.lbl_formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lbl_message.AutoSize = false;
            this.lbl_message.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_message.ForeColor = labelClr;
            this.lbl_message.Location = new System.Drawing.Point(14, 40);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(120, 20);
            this.lbl_message.TabIndex = 1;
            this.lbl_message.Text = "Leave Message:";

            this.txt_Message.BackColor = inputBg;
            this.txt_Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Message.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Message.Location = new System.Drawing.Point(14, 62);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(692, 60);
            this.txt_Message.TabIndex = 0;

            this.btn_Submit.BackColor = success;
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.FlatAppearance.BorderSize = 0;
            this.btn_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(14, 130);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(130, 28);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "📩 Submit Request";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);

            // Grid – My Requests
            this.dgv_MyRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgv_MyRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_MyRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_MyRequests.ColumnHeadersHeight = 36;
            this.dgv_MyRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_MyRequests.EnableHeadersVisualStyles = false;
            this.dgv_MyRequests.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgv_MyRequests.Location = new System.Drawing.Point(10, 224);
            this.dgv_MyRequests.Name = "dgv_MyRequests";
            this.dgv_MyRequests.ReadOnly = true;
            this.dgv_MyRequests.RowHeadersVisible = false;
            this.dgv_MyRequests.RowTemplate.Height = 28;
            this.dgv_MyRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MyRequests.Size = new System.Drawing.Size(720, 330);
            this.dgv_MyRequests.TabIndex = 2;

            // User Control
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = pageBg;
            this.Controls.Add(this.pnl_pageHeader);
            this.Controls.Add(this.pnl_formCard);
            this.Controls.Add(this.dgv_MyRequests);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UC_TeacherLeaveRequest";
            this.Size = new System.Drawing.Size(740, 568);
            this.Load += new System.EventHandler(this.UC_TeacherLeaveRequest_Load);

            this.pnl_pageHeader.ResumeLayout(false);
            this.pnl_formCard.ResumeLayout(false);
            this.pnl_formCard.PerformLayout();
            this.pnl_formHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MyRequests)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_pageHeader;
        private System.Windows.Forms.Label lbl_pageTitle;

        private System.Windows.Forms.Panel pnl_formCard;
        private System.Windows.Forms.Panel pnl_formHeader;
        private System.Windows.Forms.Label lbl_formTitle;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Button btn_Submit;

        private System.Windows.Forms.DataGridView dgv_MyRequests;
    }
}