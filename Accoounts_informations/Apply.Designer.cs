namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class Apply
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
            // ── Declarations ──────────────────────────────────────
            this.pnl_left = new System.Windows.Forms.Panel();
            this.lbl_sideTitle = new System.Windows.Forms.Label();
            this.lbl_sideTagline = new System.Windows.Forms.Label();
            this.lbl_sideNote1 = new System.Windows.Forms.Label();
            this.lbl_sideNote2 = new System.Windows.Forms.Label();
            this.lbl_sideNote3 = new System.Windows.Forms.Label();

            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_card = new System.Windows.Forms.Panel();

            // Card header
            this.pnl_cardHeader = new System.Windows.Forms.Panel();
            this.lbl_cardTitle = new System.Windows.Forms.Label();

            // Section 1 — Account Info
            this.lbl_sec1 = new System.Windows.Forms.Label();

            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_err_UserName = new System.Windows.Forms.Label();

            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_err_Email = new System.Windows.Forms.Label();

            this.lbl_Password = new System.Windows.Forms.Label();
            this.pnl_passRow = new System.Windows.Forms.Panel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_TogglePass = new System.Windows.Forms.Button();
            this.lbl_err_Password = new System.Windows.Forms.Label();

            this.lbl_ConfirmPass = new System.Windows.Forms.Label();
            this.pnl_confirmRow = new System.Windows.Forms.Panel();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.btn_ToggleConfirm = new System.Windows.Forms.Button();
            this.lbl_err_ConfirmPass = new System.Windows.Forms.Label();

            // Section 2 — Personal Info
            this.lbl_sec2 = new System.Windows.Forms.Label();

            this.lbl_Gender = new System.Windows.Forms.Label();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.lbl_err_Gender = new System.Windows.Forms.Label();

            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_err_Phone = new System.Windows.Forms.Label();

            this.lbl_Experience = new System.Windows.Forms.Label();
            this.cmb_Experience = new System.Windows.Forms.ComboBox();
            this.lbl_err_Experience = new System.Windows.Forms.Label();

            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();

            // Buttons
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();

            // ── Suspend ───────────────────────────────────────────
            this.pnl_left.SuspendLayout();
            this.pnl_right.SuspendLayout();
            this.pnl_card.SuspendLayout();
            this.pnl_cardHeader.SuspendLayout();
            this.pnl_passRow.SuspendLayout();
            this.pnl_confirmRow.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════
            //  COLOURS
            // ════════════════════════════════════════════════════════
            System.Drawing.Color primary = System.Drawing.Color.FromArgb(30, 58, 138);
            System.Drawing.Color pageBg = System.Drawing.Color.FromArgb(241, 245, 249);
            System.Drawing.Color cardBg = System.Drawing.Color.White;
            System.Drawing.Color inputBg = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color neutral = System.Drawing.Color.FromArgb(100, 116, 139);
            System.Drawing.Color danger = System.Drawing.Color.FromArgb(220, 38, 38);
            System.Drawing.Color headerBg = System.Drawing.Color.FromArgb(239, 246, 255);
            System.Drawing.Color sidebarBg = System.Drawing.Color.FromArgb(15, 23, 42);
            System.Drawing.Color labelClr = System.Drawing.Color.FromArgb(51, 65, 85);
            System.Drawing.Color secClr = System.Drawing.Color.FromArgb(30, 41, 59);
            System.Drawing.Color success = System.Drawing.Color.FromArgb(22, 163, 74);

            // ════════════════════════════════════════════════════════
            //  LEFT PANEL
            // ════════════════════════════════════════════════════════
            this.pnl_left.BackColor = sidebarBg;
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(300, 720);
            this.pnl_left.TabIndex = 0;

            this.lbl_sideTitle.AutoSize = false;
            this.lbl_sideTitle.Font = new System.Drawing.Font("Segoe UI", 16F,
                                               System.Drawing.FontStyle.Bold);
            this.lbl_sideTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_sideTitle.Location = new System.Drawing.Point(20, 80);
            this.lbl_sideTitle.Name = "lbl_sideTitle";
            this.lbl_sideTitle.Size = new System.Drawing.Size(260, 60);
            this.lbl_sideTitle.TabIndex = 0;
            this.lbl_sideTitle.Text = "Teacher Application";
            this.lbl_sideTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lbl_sideTagline.AutoSize = false;
            this.lbl_sideTagline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_sideTagline.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lbl_sideTagline.Location = new System.Drawing.Point(20, 148);
            this.lbl_sideTagline.Name = "lbl_sideTagline";
            this.lbl_sideTagline.Size = new System.Drawing.Size(260, 40);
            this.lbl_sideTagline.TabIndex = 1;
            this.lbl_sideTagline.Text = "Join our team of dedicated educators";
            this.lbl_sideTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Divider line
            System.Windows.Forms.Panel divider = new System.Windows.Forms.Panel();
            divider.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            divider.Location = new System.Drawing.Point(20, 200);
            divider.Size = new System.Drawing.Size(260, 1);
            divider.TabIndex = 2;

            this.lbl_sideNote1.AutoSize = false;
            this.lbl_sideNote1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_sideNote1.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lbl_sideNote1.Location = new System.Drawing.Point(20, 230);
            this.lbl_sideNote1.Name = "lbl_sideNote1";
            this.lbl_sideNote1.Size = new System.Drawing.Size(260, 36);
            this.lbl_sideNote1.TabIndex = 3;
            this.lbl_sideNote1.Text = "  Fill in all required fields carefully";

            this.lbl_sideNote2.AutoSize = false;
            this.lbl_sideNote2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_sideNote2.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lbl_sideNote2.Location = new System.Drawing.Point(20, 276);
            this.lbl_sideNote2.Name = "lbl_sideNote2";
            this.lbl_sideNote2.Size = new System.Drawing.Size(260, 36);
            this.lbl_sideNote2.TabIndex = 4;
            this.lbl_sideNote2.Text = "  Admin will review and approve";

            this.lbl_sideNote3.AutoSize = false;
            this.lbl_sideNote3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_sideNote3.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lbl_sideNote3.Location = new System.Drawing.Point(20, 322);
            this.lbl_sideNote3.Name = "lbl_sideNote3";
            this.lbl_sideNote3.Size = new System.Drawing.Size(260, 36);
            this.lbl_sideNote3.TabIndex = 5;
            this.lbl_sideNote3.Text = "  Login after approval via Log In page";

            this.pnl_left.Controls.Add(this.lbl_sideTitle);
            this.pnl_left.Controls.Add(this.lbl_sideTagline);
            this.pnl_left.Controls.Add(divider);
            this.pnl_left.Controls.Add(this.lbl_sideNote1);
            this.pnl_left.Controls.Add(this.lbl_sideNote2);
            this.pnl_left.Controls.Add(this.lbl_sideNote3);

            // ════════════════════════════════════════════════════════
            //  RIGHT PANEL
            // ════════════════════════════════════════════════════════
            this.pnl_right.BackColor = pageBg;
            this.pnl_right.Location = new System.Drawing.Point(300, 0);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(700, 720);
            this.pnl_right.TabIndex = 1;
            this.pnl_right.AutoScroll = true;

            // ── CARD ───────────────────────────────────────────────
            this.pnl_card.BackColor = cardBg;
            this.pnl_card.Location = new System.Drawing.Point(30, 30);
            this.pnl_card.Name = "pnl_card";
            this.pnl_card.Size = new System.Drawing.Size(638, 650);
            this.pnl_card.TabIndex = 0;

            // Card header
            this.pnl_cardHeader.BackColor = headerBg;
            this.pnl_cardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cardHeader.Name = "pnl_cardHeader";
            this.pnl_cardHeader.Size = new System.Drawing.Size(638, 44);
            this.pnl_cardHeader.TabIndex = 0;

            this.lbl_cardTitle.AutoSize = false;
            this.lbl_cardTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cardTitle.Font = new System.Drawing.Font("Segoe UI", 13F,
                                               System.Drawing.FontStyle.Bold);
            this.lbl_cardTitle.ForeColor = primary;
            this.lbl_cardTitle.Name = "lbl_cardTitle";
            this.lbl_cardTitle.TabIndex = 0;
            this.lbl_cardTitle.Text = "Teacher Application Form";
            this.lbl_cardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnl_cardHeader.Controls.Add(this.lbl_cardTitle);

            // ════════════════════════════════════════════════════
            //  SECTION 1 — Account Information
            // ════════════════════════════════════════════════════
            this.lbl_sec1.AutoSize = false;
            this.lbl_sec1.Font = new System.Drawing.Font("Segoe UI", 9F,
                                          System.Drawing.FontStyle.Bold);
            this.lbl_sec1.ForeColor = primary;
            this.lbl_sec1.BackColor = headerBg;
            this.lbl_sec1.Location = new System.Drawing.Point(0, 54);
            this.lbl_sec1.Name = "lbl_sec1";
            this.lbl_sec1.Size = new System.Drawing.Size(638, 26);
            this.lbl_sec1.TabIndex = 1;
            this.lbl_sec1.Text = "   Account Information";
            this.lbl_sec1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── Full Name ──
            this.lbl_UserName.AutoSize = false;
            this.lbl_UserName.Font = new System.Drawing.Font("Segoe UI", 8.5F,
                                              System.Drawing.FontStyle.Bold);
            this.lbl_UserName.ForeColor = labelClr;
            this.lbl_UserName.Location = new System.Drawing.Point(20, 94);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(290, 20);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "Full Name *";

            this.txt_UserName.BackColor = inputBg;
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_UserName.Location = new System.Drawing.Point(20, 116);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(290, 26);
            this.txt_UserName.TabIndex = 3;

            this.lbl_err_UserName.AutoSize = false;
            this.lbl_err_UserName.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl_err_UserName.ForeColor = danger;
            this.lbl_err_UserName.Location = new System.Drawing.Point(20, 145);
            this.lbl_err_UserName.Name = "lbl_err_UserName";
            this.lbl_err_UserName.Size = new System.Drawing.Size(290, 16);
            this.lbl_err_UserName.TabIndex = 4;
            this.lbl_err_UserName.Text = "";

            // ── Email ── (right column, same row)
            this.lbl_Email.AutoSize = false;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 8.5F,
                                           System.Drawing.FontStyle.Bold);
            this.lbl_Email.ForeColor = labelClr;
            this.lbl_Email.Location = new System.Drawing.Point(328, 94);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(290, 20);
            this.lbl_Email.TabIndex = 5;
            this.lbl_Email.Text = "Email Address *";

            this.txt_Email.BackColor = inputBg;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Email.Location = new System.Drawing.Point(328, 116);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(290, 26);
            this.txt_Email.TabIndex = 6;

            this.lbl_err_Email.AutoSize = false;
            this.lbl_err_Email.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl_err_Email.ForeColor = danger;
            this.lbl_err_Email.Location = new System.Drawing.Point(328, 145);
            this.lbl_err_Email.Name = "lbl_err_Email";
            this.lbl_err_Email.Size = new System.Drawing.Size(290, 16);
            this.lbl_err_Email.TabIndex = 7;
            this.lbl_err_Email.Text = "";

            // ── Password ── (left, second row)
            this.lbl_Password.AutoSize = false;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 8.5F,
                                              System.Drawing.FontStyle.Bold);
            this.lbl_Password.ForeColor = labelClr;
            this.lbl_Password.Location = new System.Drawing.Point(20, 176);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(290, 20);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Password *";

            this.pnl_passRow.BackColor = inputBg;
            this.pnl_passRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_passRow.Location = new System.Drawing.Point(20, 198);
            this.pnl_passRow.Name = "pnl_passRow";
            this.pnl_passRow.Size = new System.Drawing.Size(290, 28);
            this.pnl_passRow.TabIndex = 9;

            this.txt_Password.BackColor = inputBg;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Password.Location = new System.Drawing.Point(2, 3);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(228, 22);
            this.txt_Password.TabIndex = 0;
            this.txt_Password.UseSystemPasswordChar = true;

            this.btn_TogglePass.BackColor = inputBg;
            this.btn_TogglePass.FlatAppearance.BorderSize = 0;
            this.btn_TogglePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TogglePass.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btn_TogglePass.ForeColor = neutral;
            this.btn_TogglePass.Location = new System.Drawing.Point(232, 3);
            this.btn_TogglePass.Name = "btn_TogglePass";
            this.btn_TogglePass.Size = new System.Drawing.Size(52, 20);
            this.btn_TogglePass.TabIndex = 1;
            this.btn_TogglePass.Text = "Show";
            this.btn_TogglePass.UseVisualStyleBackColor = false;
            this.btn_TogglePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TogglePass.Click += new System.EventHandler(this.btn_TogglePass_Click);
            this.pnl_passRow.Controls.Add(this.txt_Password);
            this.pnl_passRow.Controls.Add(this.btn_TogglePass);

            this.lbl_err_Password.AutoSize = false;
            this.lbl_err_Password.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl_err_Password.ForeColor = danger;
            this.lbl_err_Password.Location = new System.Drawing.Point(20, 229);
            this.lbl_err_Password.Name = "lbl_err_Password";
            this.lbl_err_Password.Size = new System.Drawing.Size(290, 16);
            this.lbl_err_Password.TabIndex = 10;
            this.lbl_err_Password.Text = "";

            // ── Confirm Password ── (right, same row)
            this.lbl_ConfirmPass.AutoSize = false;
            this.lbl_ConfirmPass.Font = new System.Drawing.Font("Segoe UI", 8.5F,
                                                 System.Drawing.FontStyle.Bold);
            this.lbl_ConfirmPass.ForeColor = labelClr;
            this.lbl_ConfirmPass.Location = new System.Drawing.Point(328, 176);
            this.lbl_ConfirmPass.Name = "lbl_ConfirmPass";
            this.lbl_ConfirmPass.Size = new System.Drawing.Size(290, 20);
            this.lbl_ConfirmPass.TabIndex = 11;
            this.lbl_ConfirmPass.Text = "Confirm Password *";

            this.pnl_confirmRow.BackColor = inputBg;
            this.pnl_confirmRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_confirmRow.Location = new System.Drawing.Point(328, 198);
            this.pnl_confirmRow.Name = "pnl_confirmRow";
            this.pnl_confirmRow.Size = new System.Drawing.Size(290, 28);
            this.pnl_confirmRow.TabIndex = 12;

            this.txt_ConfirmPass.BackColor = inputBg;
            this.txt_ConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ConfirmPass.Location = new System.Drawing.Point(2, 3);
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.Size = new System.Drawing.Size(228, 22);
            this.txt_ConfirmPass.TabIndex = 0;
            this.txt_ConfirmPass.UseSystemPasswordChar = true;

            this.btn_ToggleConfirm.BackColor = inputBg;
            this.btn_ToggleConfirm.FlatAppearance.BorderSize = 0;
            this.btn_ToggleConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ToggleConfirm.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btn_ToggleConfirm.ForeColor = neutral;
            this.btn_ToggleConfirm.Location = new System.Drawing.Point(232, 3);
            this.btn_ToggleConfirm.Name = "btn_ToggleConfirm";
            this.btn_ToggleConfirm.Size = new System.Drawing.Size(52, 20);
            this.btn_ToggleConfirm.TabIndex = 1;
            this.btn_ToggleConfirm.Text = "Show";
            this.btn_ToggleConfirm.UseVisualStyleBackColor = false;
            this.btn_ToggleConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ToggleConfirm.Click += new System.EventHandler(this.btn_ToggleConfirm_Click);
            this.pnl_confirmRow.Controls.Add(this.txt_ConfirmPass);
            this.pnl_confirmRow.Controls.Add(this.btn_ToggleConfirm);

            this.lbl_err_ConfirmPass.AutoSize = false;
            this.lbl_err_ConfirmPass.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl_err_ConfirmPass.ForeColor = danger;
            this.lbl_err_ConfirmPass.Location = new System.Drawing.Point(328, 229);
            this.lbl_err_ConfirmPass.Name = "lbl_err_ConfirmPass";
            this.lbl_err_ConfirmPass.Size = new System.Drawing.Size(290, 16);
            this.lbl_err_ConfirmPass.TabIndex = 13;
            this.lbl_err_ConfirmPass.Text = "";

            // ════════════════════════════════════════════════════
            //  SECTION 2 — Personal Information
            // ════════════════════════════════════════════════════
            this.lbl_sec2.AutoSize = false;
            this.lbl_sec2.Font = new System.Drawing.Font("Segoe UI", 9F,
                                          System.Drawing.FontStyle.Bold);
            this.lbl_sec2.ForeColor = primary;
            this.lbl_sec2.BackColor = headerBg;
            this.lbl_sec2.Location = new System.Drawing.Point(0, 260);
            this.lbl_sec2.Name = "lbl_sec2";
            this.lbl_sec2.Size = new System.Drawing.Size(638, 26);
            this.lbl_sec2.TabIndex = 14;
            this.lbl_sec2.Text = "   Personal Information";
            this.lbl_sec2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── Gender ── (left)
            this.lbl_Gender.AutoSize = false;
            this.lbl_Gender.Font = new System.Drawing.Font("Segoe UI", 8.5F,
                                            System.Drawing.FontStyle.Bold);
            this.lbl_Gender.ForeColor = labelClr;
            this.lbl_Gender.Location = new System.Drawing.Point(20, 300);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(180, 20);
            this.lbl_Gender.TabIndex = 15;
            this.lbl_Gender.Text = "Gender *";

            this.cmb_Gender.BackColor = inputBg;
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Gender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_Gender.Location = new System.Drawing.Point(20, 322);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(180, 26);
            this.cmb_Gender.TabIndex = 16;

            this.lbl_err_Gender.AutoSize = false;
            this.lbl_err_Gender.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl_err_Gender.ForeColor = danger;
            this.lbl_err_Gender.Location = new System.Drawing.Point(20, 351);
            this.lbl_err_Gender.Name = "lbl_err_Gender";
            this.lbl_err_Gender.Size = new System.Drawing.Size(180, 16);
            this.lbl_err_Gender.TabIndex = 17;
            this.lbl_err_Gender.Text = "";

            // ── Phone ── (middle)
            this.lbl_Phone.AutoSize = false;
            this.lbl_Phone.Font = new System.Drawing.Font("Segoe UI", 8.5F,
                                           System.Drawing.FontStyle.Bold);
            this.lbl_Phone.ForeColor = labelClr;
            this.lbl_Phone.Location = new System.Drawing.Point(216, 300);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(196, 20);
            this.lbl_Phone.TabIndex = 18;
            this.lbl_Phone.Text = "Phone Number *";

            this.txt_Phone.BackColor = inputBg;
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Phone.Location = new System.Drawing.Point(216, 322);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(196, 26);
            this.txt_Phone.TabIndex = 19;
            this.txt_Phone.MaxLength = 11;

            this.lbl_err_Phone.AutoSize = false;
            this.lbl_err_Phone.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl_err_Phone.ForeColor = danger;
            this.lbl_err_Phone.Location = new System.Drawing.Point(216, 351);
            this.lbl_err_Phone.Name = "lbl_err_Phone";
            this.lbl_err_Phone.Size = new System.Drawing.Size(196, 16);
            this.lbl_err_Phone.TabIndex = 20;
            this.lbl_err_Phone.Text = "";

            // ── Experience ── (right)
            this.lbl_Experience.AutoSize = false;
            this.lbl_Experience.Font = new System.Drawing.Font("Segoe UI", 8.5F,
                                                System.Drawing.FontStyle.Bold);
            this.lbl_Experience.ForeColor = labelClr;
            this.lbl_Experience.Location = new System.Drawing.Point(428, 300);
            this.lbl_Experience.Name = "lbl_Experience";
            this.lbl_Experience.Size = new System.Drawing.Size(190, 20);
            this.lbl_Experience.TabIndex = 21;
            this.lbl_Experience.Text = "Experience (Years) *";

            this.cmb_Experience.BackColor = inputBg;
            this.cmb_Experience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Experience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Experience.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_Experience.Location = new System.Drawing.Point(428, 322);
            this.cmb_Experience.Name = "cmb_Experience";
            this.cmb_Experience.Size = new System.Drawing.Size(190, 26);
            this.cmb_Experience.TabIndex = 22;

            this.lbl_err_Experience.AutoSize = false;
            this.lbl_err_Experience.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lbl_err_Experience.ForeColor = danger;
            this.lbl_err_Experience.Location = new System.Drawing.Point(428, 351);
            this.lbl_err_Experience.Name = "lbl_err_Experience";
            this.lbl_err_Experience.Size = new System.Drawing.Size(190, 16);
            this.lbl_err_Experience.TabIndex = 23;
            this.lbl_err_Experience.Text = "";

            // ── Address ── (full width)
            this.lbl_Address.AutoSize = false;
            this.lbl_Address.Font = new System.Drawing.Font("Segoe UI", 8.5F,
                                             System.Drawing.FontStyle.Bold);
            this.lbl_Address.ForeColor = labelClr;
            this.lbl_Address.Location = new System.Drawing.Point(20, 384);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(598, 20);
            this.lbl_Address.TabIndex = 24;
            this.lbl_Address.Text = "Address (Optional)";

            this.txt_Address.BackColor = inputBg;
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Address.Location = new System.Drawing.Point(20, 406);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(598, 60);
            this.txt_Address.TabIndex = 25;

            // ════════════════════════════════════════════════════
            //  STATUS NOTE
            // ════════════════════════════════════════════════════
            System.Windows.Forms.Panel pnl_note = new System.Windows.Forms.Panel();
            pnl_note.BackColor = System.Drawing.Color.FromArgb(254, 243, 199);
            pnl_note.Location = new System.Drawing.Point(20, 484);
            pnl_note.Name = "pnl_note";
            pnl_note.Size = new System.Drawing.Size(598, 36);
            pnl_note.TabIndex = 26;

            System.Windows.Forms.Label lbl_note = new System.Windows.Forms.Label();
            lbl_note.AutoSize = false;
            lbl_note.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl_note.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lbl_note.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14);
            lbl_note.Text = "  Note: Your account will be Pending until Admin reviews and approves your application.";
            lbl_note.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            pnl_note.Controls.Add(lbl_note);

            // ════════════════════════════════════════════════════
            //  ACTION BUTTONS
            // ════════════════════════════════════════════════════

            // Submit
            this.btn_Submit.BackColor = primary;
            this.btn_Submit.FlatAppearance.BorderSize = 0;
            this.btn_Submit.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(29, 78, 216);
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Segoe UI", 9.5F,
                                              System.Drawing.FontStyle.Bold);
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(20, 542);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(190, 38);
            this.btn_Submit.TabIndex = 27;
            this.btn_Submit.Text = "Submit Application";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);

            // Clear
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btn_Clear.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(203, 213, 225);
            this.btn_Clear.FlatAppearance.BorderSize = 1;
            this.btn_Clear.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(226, 232, 240);
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Clear.ForeColor = neutral;
            this.btn_Clear.Location = new System.Drawing.Point(224, 542);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(130, 38);
            this.btn_Clear.TabIndex = 28;
            this.btn_Clear.Text = "Clear Fields";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);

            // Back
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btn_Back.ForeColor = neutral;
            this.btn_Back.Location = new System.Drawing.Point(20, 596);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(598, 30);
            this.btn_Back.TabIndex = 29;
            this.btn_Back.Text = "< Back to Home";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);

            // ── Add all controls to card ───────────────────────
            this.pnl_card.Controls.Add(this.pnl_cardHeader);
            this.pnl_card.Controls.Add(this.lbl_sec1);
            this.pnl_card.Controls.Add(this.lbl_UserName);
            this.pnl_card.Controls.Add(this.txt_UserName);
            this.pnl_card.Controls.Add(this.lbl_err_UserName);
            this.pnl_card.Controls.Add(this.lbl_Email);
            this.pnl_card.Controls.Add(this.txt_Email);
            this.pnl_card.Controls.Add(this.lbl_err_Email);
            this.pnl_card.Controls.Add(this.lbl_Password);
            this.pnl_card.Controls.Add(this.pnl_passRow);
            this.pnl_card.Controls.Add(this.lbl_err_Password);
            this.pnl_card.Controls.Add(this.lbl_ConfirmPass);
            this.pnl_card.Controls.Add(this.pnl_confirmRow);
            this.pnl_card.Controls.Add(this.lbl_err_ConfirmPass);
            this.pnl_card.Controls.Add(this.lbl_sec2);
            this.pnl_card.Controls.Add(this.lbl_Gender);
            this.pnl_card.Controls.Add(this.cmb_Gender);
            this.pnl_card.Controls.Add(this.lbl_err_Gender);
            this.pnl_card.Controls.Add(this.lbl_Phone);
            this.pnl_card.Controls.Add(this.txt_Phone);
            this.pnl_card.Controls.Add(this.lbl_err_Phone);
            this.pnl_card.Controls.Add(this.lbl_Experience);
            this.pnl_card.Controls.Add(this.cmb_Experience);
            this.pnl_card.Controls.Add(this.lbl_err_Experience);
            this.pnl_card.Controls.Add(this.lbl_Address);
            this.pnl_card.Controls.Add(this.txt_Address);
            this.pnl_card.Controls.Add(pnl_note);
            this.pnl_card.Controls.Add(this.btn_Submit);
            this.pnl_card.Controls.Add(this.btn_Clear);
            this.pnl_card.Controls.Add(this.btn_Back);

            this.pnl_right.Controls.Add(this.pnl_card);

            // ════════════════════════════════════════════════════════
            //  FORM PROPERTIES
            // ════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Apply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System - Teacher Application";

            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_right);

            this.Load += new System.EventHandler(this.Apply_Load);

            // ── Resume ────────────────────────────────────────────
            this.pnl_passRow.ResumeLayout(false);
            this.pnl_passRow.PerformLayout();
            this.pnl_confirmRow.ResumeLayout(false);
            this.pnl_confirmRow.PerformLayout();
            this.pnl_cardHeader.ResumeLayout(false);
            this.pnl_card.ResumeLayout(false);
            this.pnl_right.ResumeLayout(false);
            this.pnl_left.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ────────────────────────────────────
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Label lbl_sideTitle;
        private System.Windows.Forms.Label lbl_sideTagline;
        private System.Windows.Forms.Label lbl_sideNote1;
        private System.Windows.Forms.Label lbl_sideNote2;
        private System.Windows.Forms.Label lbl_sideNote3;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_card;
        private System.Windows.Forms.Panel pnl_cardHeader;
        private System.Windows.Forms.Label lbl_cardTitle;
        private System.Windows.Forms.Label lbl_sec1;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_err_UserName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_err_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Panel pnl_passRow;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_TogglePass;
        private System.Windows.Forms.Label lbl_err_Password;
        private System.Windows.Forms.Label lbl_ConfirmPass;
        private System.Windows.Forms.Panel pnl_confirmRow;
        private System.Windows.Forms.TextBox txt_ConfirmPass;
        private System.Windows.Forms.Button btn_ToggleConfirm;
        private System.Windows.Forms.Label lbl_err_ConfirmPass;
        private System.Windows.Forms.Label lbl_sec2;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label lbl_err_Gender;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_err_Phone;
        private System.Windows.Forms.Label lbl_Experience;
        private System.Windows.Forms.ComboBox cmb_Experience;
        private System.Windows.Forms.Label lbl_err_Experience;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Back;
    }
}