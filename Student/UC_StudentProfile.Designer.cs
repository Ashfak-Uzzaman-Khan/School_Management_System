namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class UC_StudentProfile
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_deptValue = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_statusValue = new System.Windows.Forms.Label();
            this.pnl_actionBar = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.pnl_pageHeader.SuspendLayout();
            this.pnl_formCard.SuspendLayout();
            this.pnl_formHeader.SuspendLayout();
            this.pnl_actionBar.SuspendLayout();
            this.SuspendLayout();

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
            this.pnl_pageHeader.Size = new System.Drawing.Size(740, 34);

            this.lbl_pageTitle.AutoSize = false;
            this.lbl_pageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_pageTitle.ForeColor = primary;
            this.lbl_pageTitle.Text = "  👤  My Profile";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Form Card
            this.pnl_formCard.BackColor = cardBg;
            this.pnl_formCard.Controls.Add(this.pnl_formHeader);
            this.pnl_formCard.Controls.Add(this.lbl_username);
            this.pnl_formCard.Controls.Add(this.txt_UserName);
            this.pnl_formCard.Controls.Add(this.lbl_email);
            this.pnl_formCard.Controls.Add(this.txt_Email);
            this.pnl_formCard.Controls.Add(this.lbl_gender);
            this.pnl_formCard.Controls.Add(this.cmb_Gender);
            this.pnl_formCard.Controls.Add(this.lbl_phone);
            this.pnl_formCard.Controls.Add(this.txt_Phone);
            this.pnl_formCard.Controls.Add(this.lbl_address);
            this.pnl_formCard.Controls.Add(this.txt_Address);
            this.pnl_formCard.Controls.Add(this.lbl_department);
            this.pnl_formCard.Controls.Add(this.lbl_deptValue);
            this.pnl_formCard.Controls.Add(this.lbl_status);
            this.pnl_formCard.Controls.Add(this.lbl_statusValue);
            this.pnl_formCard.Location = new System.Drawing.Point(10, 44);
            this.pnl_formCard.Size = new System.Drawing.Size(720, 260);

            this.pnl_formHeader.BackColor = stripBg;
            this.pnl_formHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_formHeader.Size = new System.Drawing.Size(720, 30);
            this.pnl_formHeader.Controls.Add(this.lbl_formTitle);
            this.lbl_formTitle.AutoSize = false;
            this.lbl_formTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_formTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_formTitle.ForeColor = primary;
            this.lbl_formTitle.Text = "  Student Details";

            int leftX = 14, midX = 204, rightX = 398;

            // Username
            this.lbl_username.AutoSize = false;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_username.Location = new System.Drawing.Point(leftX, 38);
            this.lbl_username.Size = new System.Drawing.Size(180, 20);
            this.lbl_username.Text = "User Name";
            this.txt_UserName.BackColor = System.Drawing.Color.White;
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_UserName.Location = new System.Drawing.Point(leftX, 60);
            this.txt_UserName.Size = new System.Drawing.Size(180, 26);
            this.txt_UserName.TabIndex = 0;

            // Email (read-only)
            this.lbl_email.AutoSize = false;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_email.Location = new System.Drawing.Point(midX, 38);
            this.lbl_email.Size = new System.Drawing.Size(180, 20);
            this.lbl_email.Text = "Email";
            this.txt_Email.BackColor = inputBg;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Email.Location = new System.Drawing.Point(midX, 60);
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(180, 26);
            this.txt_Email.TabIndex = 1;

            // Gender (editable)
            this.lbl_gender.AutoSize = false;
            this.lbl_gender.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_gender.Location = new System.Drawing.Point(rightX, 38);
            this.lbl_gender.Size = new System.Drawing.Size(180, 20);
            this.lbl_gender.Text = "Gender";
            this.cmb_Gender.BackColor = System.Drawing.Color.White;
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Gender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_Gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            this.cmb_Gender.Location = new System.Drawing.Point(rightX, 60);
            this.cmb_Gender.Size = new System.Drawing.Size(180, 26);
            this.cmb_Gender.TabIndex = 2;

            // Phone
            this.lbl_phone.AutoSize = false;
            this.lbl_phone.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_phone.Location = new System.Drawing.Point(leftX, 94);
            this.lbl_phone.Size = new System.Drawing.Size(180, 20);
            this.lbl_phone.Text = "Phone";
            this.txt_Phone.BackColor = System.Drawing.Color.White;
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Phone.Location = new System.Drawing.Point(leftX, 116);
            this.txt_Phone.Size = new System.Drawing.Size(180, 26);
            this.txt_Phone.TabIndex = 3;

            // Address
            this.lbl_address.AutoSize = false;
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_address.Location = new System.Drawing.Point(midX, 94);
            this.lbl_address.Size = new System.Drawing.Size(180, 20);
            this.lbl_address.Text = "Address";
            this.txt_Address.BackColor = System.Drawing.Color.White;
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Address.Location = new System.Drawing.Point(midX, 116);
            this.txt_Address.Multiline = true;
            this.txt_Address.Size = new System.Drawing.Size(180, 82);
            this.txt_Address.TabIndex = 4;

            // Read-only department & status
            this.lbl_department.AutoSize = false;
            this.lbl_department.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_department.Location = new System.Drawing.Point(rightX, 94);
            this.lbl_department.Size = new System.Drawing.Size(180, 20);
            this.lbl_department.Text = "Department:";
            this.lbl_deptValue.AutoSize = false;
            this.lbl_deptValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_deptValue.Location = new System.Drawing.Point(rightX, 116);
            this.lbl_deptValue.Size = new System.Drawing.Size(180, 20);
            this.lbl_deptValue.Text = "-";

            this.lbl_status.AutoSize = false;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_status.Location = new System.Drawing.Point(rightX, 145);
            this.lbl_status.Size = new System.Drawing.Size(180, 20);
            this.lbl_status.Text = "Status:";
            this.lbl_statusValue.AutoSize = false;
            this.lbl_statusValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_statusValue.Location = new System.Drawing.Point(rightX, 167);
            this.lbl_statusValue.Size = new System.Drawing.Size(180, 20);
            this.lbl_statusValue.Text = "-";

            // Action Bar
            this.pnl_actionBar.Controls.Add(this.btn_Save);
            this.pnl_actionBar.Controls.Add(this.btn_Reload);
            this.pnl_actionBar.Location = new System.Drawing.Point(10, 314);

            this.btn_Save.BackColor = success;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(0, 4);
            this.btn_Save.Size = new System.Drawing.Size(130, 34);
            this.btn_Save.Text = "💾 Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);

            this.btn_Reload.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btn_Reload.FlatAppearance.BorderSize = 0;
            this.btn_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Reload.ForeColor = System.Drawing.Color.White;
            this.btn_Reload.Location = new System.Drawing.Point(140, 4);
            this.btn_Reload.Size = new System.Drawing.Size(130, 34);
            this.btn_Reload.Text = "🔄 Reload";
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);

            // User Control
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = pageBg;
            this.Controls.Add(this.pnl_pageHeader);
            this.Controls.Add(this.pnl_formCard);
            this.Controls.Add(this.pnl_actionBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UC_StudentProfile";
            this.Size = new System.Drawing.Size(740, 568);
            this.Load += new System.EventHandler(this.UC_StudentProfile_Load);

            this.pnl_pageHeader.ResumeLayout(false);
            this.pnl_formCard.ResumeLayout(false);
            this.pnl_formCard.PerformLayout();
            this.pnl_formHeader.ResumeLayout(false);
            this.pnl_actionBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_pageHeader;
        private System.Windows.Forms.Label lbl_pageTitle;
        private System.Windows.Forms.Panel pnl_formCard;
        private System.Windows.Forms.Panel pnl_formHeader;
        private System.Windows.Forms.Label lbl_formTitle;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_deptValue;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_statusValue;
        private System.Windows.Forms.Panel pnl_actionBar;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Reload;
    }
}