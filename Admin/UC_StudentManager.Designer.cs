namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class UC_StudentManager
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
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_department = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.pnl_actionBar = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.pnl_searchBar = new System.Windows.Forms.Panel();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_filterStatus = new System.Windows.Forms.Label();
            this.cmb_StatusFilter = new System.Windows.Forms.ComboBox();
            this.btn_FilterStatus = new System.Windows.Forms.Button();
            this.dgv_Students = new System.Windows.Forms.DataGridView();
            this.pnl_pageHeader.SuspendLayout();
            this.pnl_formCard.SuspendLayout();
            this.pnl_formHeader.SuspendLayout();
            this.pnl_actionBar.SuspendLayout();
            this.pnl_searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_pageHeader
            // 
            this.pnl_pageHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnl_pageHeader.Controls.Add(this.lbl_pageTitle);
            this.pnl_pageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pnl_pageHeader.Name = "pnl_pageHeader";
            this.pnl_pageHeader.Size = new System.Drawing.Size(740, 34);
            this.pnl_pageHeader.TabIndex = 0;
            // 
            // lbl_pageTitle
            // 
            this.lbl_pageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lbl_pageTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_pageTitle.Name = "lbl_pageTitle";
            this.lbl_pageTitle.Size = new System.Drawing.Size(740, 34);
            this.lbl_pageTitle.TabIndex = 0;
            this.lbl_pageTitle.Text = "  👤  Student Manager";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_formCard
            // 
            this.pnl_formCard.BackColor = System.Drawing.Color.White;
            this.pnl_formCard.Controls.Add(this.pnl_formHeader);
            this.pnl_formCard.Controls.Add(this.lbl_username);
            this.pnl_formCard.Controls.Add(this.pnl_actionBar);
            this.pnl_formCard.Controls.Add(this.txt_UserName);
            this.pnl_formCard.Controls.Add(this.lbl_email);
            this.pnl_formCard.Controls.Add(this.txt_Email);
            this.pnl_formCard.Controls.Add(this.lbl_password);
            this.pnl_formCard.Controls.Add(this.txt_Password);
            this.pnl_formCard.Controls.Add(this.lbl_phone);
            this.pnl_formCard.Controls.Add(this.txt_Phone);
            this.pnl_formCard.Controls.Add(this.lbl_gender);
            this.pnl_formCard.Controls.Add(this.cmb_Gender);
            this.pnl_formCard.Controls.Add(this.lbl_address);
            this.pnl_formCard.Controls.Add(this.txt_Address);
            this.pnl_formCard.Controls.Add(this.lbl_department);
            this.pnl_formCard.Controls.Add(this.cmb_Department);
            this.pnl_formCard.Controls.Add(this.lbl_status);
            this.pnl_formCard.Controls.Add(this.cmb_Status);
            this.pnl_formCard.Location = new System.Drawing.Point(10, 44);
            this.pnl_formCard.Name = "pnl_formCard";
            this.pnl_formCard.Size = new System.Drawing.Size(720, 259);
            this.pnl_formCard.TabIndex = 1;
            // 
            // pnl_formHeader
            // 
            this.pnl_formHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnl_formHeader.Controls.Add(this.lbl_formTitle);
            this.pnl_formHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_formHeader.Location = new System.Drawing.Point(0, 0);
            this.pnl_formHeader.Name = "pnl_formHeader";
            this.pnl_formHeader.Size = new System.Drawing.Size(720, 30);
            this.pnl_formHeader.TabIndex = 0;
            // 
            // lbl_formTitle
            // 
            this.lbl_formTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_formTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_formTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lbl_formTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_formTitle.Name = "lbl_formTitle";
            this.lbl_formTitle.Size = new System.Drawing.Size(720, 30);
            this.lbl_formTitle.TabIndex = 0;
            this.lbl_formTitle.Text = "  Student Details";
            this.lbl_formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_username
            // 
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_username.Location = new System.Drawing.Point(14, 38);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(180, 20);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "User Name";
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_UserName.Location = new System.Drawing.Point(14, 60);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(180, 27);
            this.txt_UserName.TabIndex = 0;
            // 
            // lbl_email
            // 
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_email.Location = new System.Drawing.Point(14, 94);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(180, 20);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Email.Location = new System.Drawing.Point(14, 116);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(180, 27);
            this.txt_Email.TabIndex = 1;
            // 
            // lbl_password
            // 
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_password.Location = new System.Drawing.Point(14, 150);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(180, 20);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Password.Location = new System.Drawing.Point(14, 172);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(180, 27);
            this.txt_Password.TabIndex = 2;
            // 
            // lbl_phone
            // 
            this.lbl_phone.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_phone.Location = new System.Drawing.Point(394, 150);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(180, 20);
            this.lbl_phone.TabIndex = 7;
            this.lbl_phone.Text = "Phone";
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Phone.Location = new System.Drawing.Point(402, 184);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(180, 27);
            this.txt_Phone.TabIndex = 3;
            // 
            // lbl_gender
            // 
            this.lbl_gender.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_gender.Location = new System.Drawing.Point(204, 38);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(180, 20);
            this.lbl_gender.TabIndex = 9;
            this.lbl_gender.Text = "Gender";
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Gender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Location = new System.Drawing.Point(204, 60);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(180, 28);
            this.cmb_Gender.TabIndex = 4;
            // 
            // lbl_address
            // 
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_address.Location = new System.Drawing.Point(204, 94);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(180, 20);
            this.lbl_address.TabIndex = 11;
            this.lbl_address.Text = "Address";
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Address.Location = new System.Drawing.Point(204, 116);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(180, 82);
            this.txt_Address.TabIndex = 5;
            // 
            // lbl_department
            // 
            this.lbl_department.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_department.Location = new System.Drawing.Point(398, 38);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(180, 20);
            this.lbl_department.TabIndex = 13;
            this.lbl_department.Text = "Department";
            // 
            // cmb_Department
            // 
            this.cmb_Department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Department.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(398, 60);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(180, 28);
            this.cmb_Department.TabIndex = 6;
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_status.Location = new System.Drawing.Point(398, 94);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(180, 20);
            this.lbl_status.TabIndex = 15;
            this.lbl_status.Text = "Status";
            // 
            // cmb_Status
            // 
            this.cmb_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Status.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(398, 116);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(180, 28);
            this.cmb_Status.TabIndex = 7;
            // 
            // pnl_actionBar
            // 
            this.pnl_actionBar.Controls.Add(this.btn_Add);
            this.pnl_actionBar.Controls.Add(this.btn_Update);
            this.pnl_actionBar.Controls.Add(this.btn_Delete);
            this.pnl_actionBar.Controls.Add(this.btn_Clear);
            this.pnl_actionBar.Location = new System.Drawing.Point(0, 227);
            this.pnl_actionBar.Name = "pnl_actionBar";
            this.pnl_actionBar.Size = new System.Drawing.Size(720, 42);
            this.pnl_actionBar.TabIndex = 2;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
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
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
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
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
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
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
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
            // 
            // pnl_searchBar
            // 
            this.pnl_searchBar.Controls.Add(this.lbl_search);
            this.pnl_searchBar.Controls.Add(this.txt_Search);
            this.pnl_searchBar.Controls.Add(this.btn_Search);
            this.pnl_searchBar.Controls.Add(this.lbl_filterStatus);
            this.pnl_searchBar.Controls.Add(this.cmb_StatusFilter);
            this.pnl_searchBar.Controls.Add(this.btn_FilterStatus);
            this.pnl_searchBar.Location = new System.Drawing.Point(5, 315);
            this.pnl_searchBar.Name = "pnl_searchBar";
            this.pnl_searchBar.Size = new System.Drawing.Size(720, 36);
            this.pnl_searchBar.TabIndex = 3;
            // 
            // lbl_search
            // 
            this.lbl_search.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_search.Location = new System.Drawing.Point(0, 8);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(100, 20);
            this.lbl_search.TabIndex = 0;
            this.lbl_search.Text = "🔍 Search:";
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.Location = new System.Drawing.Point(100, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(200, 27);
            this.txt_Search.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
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
            // 
            // lbl_filterStatus
            // 
            this.lbl_filterStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_filterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_filterStatus.Location = new System.Drawing.Point(410, 8);
            this.lbl_filterStatus.Name = "lbl_filterStatus";
            this.lbl_filterStatus.Size = new System.Drawing.Size(70, 20);
            this.lbl_filterStatus.TabIndex = 3;
            this.lbl_filterStatus.Text = "Status:";
            // 
            // cmb_StatusFilter
            // 
            this.cmb_StatusFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cmb_StatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_StatusFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_StatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_StatusFilter.FormattingEnabled = true;
            this.cmb_StatusFilter.Location = new System.Drawing.Point(480, 5);
            this.cmb_StatusFilter.Name = "cmb_StatusFilter";
            this.cmb_StatusFilter.Size = new System.Drawing.Size(130, 28);
            this.cmb_StatusFilter.TabIndex = 2;
            // 
            // btn_FilterStatus
            // 
            this.btn_FilterStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btn_FilterStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FilterStatus.FlatAppearance.BorderSize = 0;
            this.btn_FilterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_FilterStatus.ForeColor = System.Drawing.Color.White;
            this.btn_FilterStatus.Location = new System.Drawing.Point(620, 5);
            this.btn_FilterStatus.Name = "btn_FilterStatus";
            this.btn_FilterStatus.Size = new System.Drawing.Size(90, 26);
            this.btn_FilterStatus.TabIndex = 3;
            this.btn_FilterStatus.Text = "Filter";
            this.btn_FilterStatus.UseVisualStyleBackColor = false;
            this.btn_FilterStatus.Click += new System.EventHandler(this.btn_FilterStatus_Click);
            // 
            // dgv_Students
            // 
            this.dgv_Students.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Students.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Students.ColumnHeadersHeight = 36;
            this.dgv_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Students.EnableHeadersVisualStyles = false;
            this.dgv_Students.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgv_Students.Location = new System.Drawing.Point(10, 362);
            this.dgv_Students.Name = "dgv_Students";
            this.dgv_Students.ReadOnly = true;
            this.dgv_Students.RowHeadersVisible = false;
            this.dgv_Students.RowHeadersWidth = 51;
            this.dgv_Students.RowTemplate.Height = 28;
            this.dgv_Students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Students.Size = new System.Drawing.Size(720, 200);
            this.dgv_Students.TabIndex = 4;
            this.dgv_Students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Students_CellClick);
            // 
            // UC_StudentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnl_pageHeader);
            this.Controls.Add(this.pnl_formCard);
            this.Controls.Add(this.pnl_searchBar);
            this.Controls.Add(this.dgv_Students);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UC_StudentManager";
            this.Size = new System.Drawing.Size(740, 568);
            this.Load += new System.EventHandler(this.UC_StudentManager_Load);
            this.pnl_pageHeader.ResumeLayout(false);
            this.pnl_formCard.ResumeLayout(false);
            this.pnl_formCard.PerformLayout();
            this.pnl_formHeader.ResumeLayout(false);
            this.pnl_actionBar.ResumeLayout(false);
            this.pnl_searchBar.ResumeLayout(false);
            this.pnl_searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Field declarations ────────────────────────────────────
        private System.Windows.Forms.Panel pnl_pageHeader;
        private System.Windows.Forms.Label lbl_pageTitle;

        private System.Windows.Forms.Panel pnl_formCard;
        private System.Windows.Forms.Panel pnl_formHeader;
        private System.Windows.Forms.Label lbl_formTitle;

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox cmb_Status;

        private System.Windows.Forms.Panel pnl_actionBar;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;

        private System.Windows.Forms.Panel pnl_searchBar;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_filterStatus;
        private System.Windows.Forms.ComboBox cmb_StatusFilter;
        private System.Windows.Forms.Button btn_FilterStatus;

        private System.Windows.Forms.DataGridView dgv_Students;
    }
}