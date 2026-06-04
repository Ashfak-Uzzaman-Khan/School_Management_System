namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class Login
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
            this.pnl_left = new System.Windows.Forms.Panel();
            this.lbl_schoolName = new System.Windows.Forms.Label();
            this.lbl_schoolTagline = new System.Windows.Forms.Label();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_card = new System.Windows.Forms.Panel();
            this.pnl_cardHeader = new System.Windows.Forms.Panel();
            this.lbl_cardTitle = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_emailError = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.pnl_passRow = new System.Windows.Forms.Panel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_TogglePass = new System.Windows.Forms.Button();
            this.lbl_passError = new System.Windows.Forms.Label();
            this.lnk_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_left.SuspendLayout();
            this.pnl_right.SuspendLayout();
            this.pnl_card.SuspendLayout();
            this.pnl_cardHeader.SuspendLayout();
            this.pnl_passRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnl_left.Controls.Add(this.lbl_schoolName);
            this.pnl_left.Controls.Add(this.lbl_schoolTagline);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(340, 580);
            this.pnl_left.TabIndex = 0;
            // 
            // lbl_schoolName
            // 
            this.lbl_schoolName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_schoolName.ForeColor = System.Drawing.Color.White;
            this.lbl_schoolName.Location = new System.Drawing.Point(20, 240);
            this.lbl_schoolName.Name = "lbl_schoolName";
            this.lbl_schoolName.Size = new System.Drawing.Size(300, 76);
            this.lbl_schoolName.TabIndex = 1;
            this.lbl_schoolName.Text = "School Management\nSystem";
            this.lbl_schoolName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_schoolTagline
            // 
            this.lbl_schoolTagline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_schoolTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lbl_schoolTagline.Location = new System.Drawing.Point(20, 316);
            this.lbl_schoolTagline.Name = "lbl_schoolTagline";
            this.lbl_schoolTagline.Size = new System.Drawing.Size(300, 60);
            this.lbl_schoolTagline.TabIndex = 2;
            this.lbl_schoolTagline.Text = "Empowering Education,\nOne Student at a Time.";
            this.lbl_schoolTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_right
            // 
            this.pnl_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnl_right.Controls.Add(this.pnl_card);
            this.pnl_right.Location = new System.Drawing.Point(340, 0);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(480, 580);
            this.pnl_right.TabIndex = 1;
            // 
            // pnl_card
            // 
            this.pnl_card.BackColor = System.Drawing.Color.White;
            this.pnl_card.Controls.Add(this.pnl_cardHeader);
            this.pnl_card.Controls.Add(this.lbl_email);
            this.pnl_card.Controls.Add(this.txt_Email);
            this.pnl_card.Controls.Add(this.lbl_emailError);
            this.pnl_card.Controls.Add(this.lbl_password);
            this.pnl_card.Controls.Add(this.pnl_passRow);
            this.pnl_card.Controls.Add(this.lbl_passError);
            this.pnl_card.Controls.Add(this.lnk_ForgotPassword);
            this.pnl_card.Controls.Add(this.btn_Login);
            this.pnl_card.Controls.Add(this.btn_Clear);
            this.pnl_card.Controls.Add(this.btn_Back);
            this.pnl_card.Location = new System.Drawing.Point(40, 60);
            this.pnl_card.Name = "pnl_card";
            this.pnl_card.Size = new System.Drawing.Size(400, 460);
            this.pnl_card.TabIndex = 0;
            // 
            // pnl_cardHeader
            // 
            this.pnl_cardHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnl_cardHeader.Controls.Add(this.lbl_cardTitle);
            this.pnl_cardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cardHeader.Location = new System.Drawing.Point(0, 0);
            this.pnl_cardHeader.Name = "pnl_cardHeader";
            this.pnl_cardHeader.Size = new System.Drawing.Size(400, 44);
            this.pnl_cardHeader.TabIndex = 0;
            // 
            // lbl_cardTitle
            // 
            this.lbl_cardTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cardTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_cardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lbl_cardTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_cardTitle.Name = "lbl_cardTitle";
            this.lbl_cardTitle.Size = new System.Drawing.Size(400, 44);
            this.lbl_cardTitle.TabIndex = 0;
            this.lbl_cardTitle.Text = "Sign In to Your Account";
            this.lbl_cardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_email
            // 
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_email.Location = new System.Drawing.Point(24, 70);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(352, 20);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email Address";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txt_Email.Location = new System.Drawing.Point(24, 94);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(352, 29);
            this.txt_Email.TabIndex = 2;
            this.txt_Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Email_KeyDown);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // lbl_emailError
            // 
            this.lbl_emailError.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl_emailError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_emailError.Location = new System.Drawing.Point(24, 124);
            this.lbl_emailError.Name = "lbl_emailError";
            this.lbl_emailError.Size = new System.Drawing.Size(352, 16);
            this.lbl_emailError.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_password.Location = new System.Drawing.Point(24, 158);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(352, 20);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password";
            // 
            // pnl_passRow
            // 
            this.pnl_passRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnl_passRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_passRow.Controls.Add(this.txt_Password);
            this.pnl_passRow.Controls.Add(this.btn_TogglePass);
            this.pnl_passRow.Location = new System.Drawing.Point(24, 182);
            this.pnl_passRow.Name = "pnl_passRow";
            this.pnl_passRow.Size = new System.Drawing.Size(352, 28);
            this.pnl_passRow.TabIndex = 5;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txt_Password.Location = new System.Drawing.Point(0, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(290, 22);
            this.txt_Password.TabIndex = 0;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // btn_TogglePass
            // 
            this.btn_TogglePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btn_TogglePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TogglePass.FlatAppearance.BorderSize = 0;
            this.btn_TogglePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TogglePass.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btn_TogglePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btn_TogglePass.Location = new System.Drawing.Point(292, 2);
            this.btn_TogglePass.Name = "btn_TogglePass";
            this.btn_TogglePass.Size = new System.Drawing.Size(56, 22);
            this.btn_TogglePass.TabIndex = 1;
            this.btn_TogglePass.Text = "👁️";
            this.btn_TogglePass.UseVisualStyleBackColor = false;
            this.btn_TogglePass.Click += new System.EventHandler(this.btn_TogglePass_Click);
            // 
            // lbl_passError
            // 
            this.lbl_passError.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl_passError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_passError.Location = new System.Drawing.Point(24, 214);
            this.lbl_passError.Name = "lbl_passError";
            this.lbl_passError.Size = new System.Drawing.Size(352, 16);
            this.lbl_passError.TabIndex = 6;
            // 
            // lnk_ForgotPassword
            // 
            this.lnk_ForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.lnk_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lnk_ForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lnk_ForgotPassword.Location = new System.Drawing.Point(24, 238);
            this.lnk_ForgotPassword.Name = "lnk_ForgotPassword";
            this.lnk_ForgotPassword.Size = new System.Drawing.Size(352, 20);
            this.lnk_ForgotPassword.TabIndex = 7;
            this.lnk_ForgotPassword.TabStop = true;
            this.lnk_ForgotPassword.Text = "Forgot your password? Click here to reset";
            this.lnk_ForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnk_ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_ForgotPassword_LinkClicked);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(24, 278);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(352, 38);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.Text = "Sign In";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btn_Clear.Location = new System.Drawing.Point(24, 328);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(352, 34);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear Fields";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Location = new System.Drawing.Point(24, 390);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(352, 30);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = " Back to Home";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(820, 580);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_right);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_right.ResumeLayout(false);
            this.pnl_card.ResumeLayout(false);
            this.pnl_card.PerformLayout();
            this.pnl_cardHeader.ResumeLayout(false);
            this.pnl_passRow.ResumeLayout(false);
            this.pnl_passRow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Field declarations ────────────────────────────────────
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Label lbl_schoolName;
        private System.Windows.Forms.Label lbl_schoolTagline;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_card;
        private System.Windows.Forms.Panel pnl_cardHeader;
        private System.Windows.Forms.Label lbl_cardTitle;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_emailError;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Panel pnl_passRow;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_TogglePass;
        private System.Windows.Forms.Label lbl_passError;
        private System.Windows.Forms.LinkLabel lnk_ForgotPassword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Back;
    }
}