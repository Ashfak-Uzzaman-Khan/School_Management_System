namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class UC_TeacherAssignmentManager
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

            // Course selection
            this.pnl_formCard = new System.Windows.Forms.Panel();
            this.pnl_formHeader = new System.Windows.Forms.Panel();
            this.lbl_formTitle = new System.Windows.Forms.Label();
            this.lbl_selectCourse = new System.Windows.Forms.Label();
            this.cmb_Course = new System.Windows.Forms.ComboBox();

            // Assignment list
            this.dgv_Assignments = new System.Windows.Forms.DataGridView();

            // Add/Delete buttons
            this.pnl_actionBar = new System.Windows.Forms.Panel();
            this.btn_AddAssignment = new System.Windows.Forms.Button();
            this.btn_DeleteAssignment = new System.Windows.Forms.Button();

            // Add assignment panel (hidden initially)
            this.pnl_addAssignment = new System.Windows.Forms.Panel();
            this.lbl_addDetails = new System.Windows.Forms.Label();
            this.txt_AssignmentDetails = new System.Windows.Forms.TextBox();
            this.lbl_deadline = new System.Windows.Forms.Label();
            this.dtp_Deadline = new System.Windows.Forms.DateTimePicker();
            this.btn_SaveAssignment = new System.Windows.Forms.Button();
            this.btn_CancelAdd = new System.Windows.Forms.Button();

            // Search student submission
            this.pnl_searchBar = new System.Windows.Forms.Panel();
            this.lbl_searchStudent = new System.Windows.Forms.Label();
            this.txt_SearchStudent = new System.Windows.Forms.TextBox();
            this.btn_SearchStudent = new System.Windows.Forms.Button();
            this.dgv_Submissions = new System.Windows.Forms.DataGridView();

            this.pnl_pageHeader.SuspendLayout();
            this.pnl_formCard.SuspendLayout();
            this.pnl_formHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Assignments)).BeginInit();
            this.pnl_actionBar.SuspendLayout();
            this.pnl_addAssignment.SuspendLayout();
            this.pnl_searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Submissions)).BeginInit();
            this.SuspendLayout();

            System.Drawing.Color primary = System.Drawing.Color.FromArgb(30, 58, 138);
            System.Drawing.Color pageBg = System.Drawing.Color.FromArgb(241, 245, 249);
            System.Drawing.Color cardBg = System.Drawing.Color.White;
            System.Drawing.Color inputBg = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color stripBg = System.Drawing.Color.FromArgb(239, 246, 255);
            System.Drawing.Color neutral = System.Drawing.Color.FromArgb(100, 116, 139);
            System.Drawing.Color danger = System.Drawing.Color.FromArgb(220, 38, 38);
            System.Drawing.Color success = System.Drawing.Color.FromArgb(22, 163, 74);
            System.Drawing.Color accent = System.Drawing.Color.FromArgb(59, 130, 246);
            System.Drawing.Color labelClr = System.Drawing.Color.FromArgb(51, 65, 85);

            // Page Header
            this.pnl_pageHeader.BackColor = stripBg;
            this.pnl_pageHeader.Controls.Add(this.lbl_pageTitle);
            this.pnl_pageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pnl_pageHeader.Size = new System.Drawing.Size(740, 34);
            this.pnl_pageHeader.TabIndex = 0;

            this.lbl_pageTitle.AutoSize = false;
            this.lbl_pageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_pageTitle.ForeColor = primary;
            this.lbl_pageTitle.Text = "  📝  Assignment Manager";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Form Card – Course selection
            this.pnl_formCard.BackColor = cardBg;
            this.pnl_formCard.Controls.Add(this.pnl_formHeader);
            this.pnl_formCard.Controls.Add(this.lbl_selectCourse);
            this.pnl_formCard.Controls.Add(this.cmb_Course);
            this.pnl_formCard.Location = new System.Drawing.Point(10, 44);
            this.pnl_formCard.Size = new System.Drawing.Size(720, 70);
            this.pnl_formCard.TabIndex = 1;

            this.pnl_formHeader.BackColor = stripBg;
            this.pnl_formHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_formHeader.Size = new System.Drawing.Size(720, 24);
            this.pnl_formHeader.Controls.Add(this.lbl_formTitle);
            this.lbl_formTitle.AutoSize = false;
            this.lbl_formTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_formTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_formTitle.ForeColor = primary;
            this.lbl_formTitle.Text = "  Select Course";

            this.lbl_selectCourse.AutoSize = false;
            this.lbl_selectCourse.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_selectCourse.ForeColor = labelClr;
            this.lbl_selectCourse.Location = new System.Drawing.Point(14, 30);
            this.lbl_selectCourse.Size = new System.Drawing.Size(100, 20);
            this.lbl_selectCourse.Text = "Course:";

            this.cmb_Course.BackColor = inputBg;
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Course.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_Course.Location = new System.Drawing.Point(120, 28);
            this.cmb_Course.Size = new System.Drawing.Size(250, 26);
            this.cmb_Course.SelectedIndexChanged += new System.EventHandler(this.cmb_Course_SelectedIndexChanged);

            // Assignments Grid
            this.dgv_Assignments.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Assignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Assignments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Assignments.ColumnHeadersHeight = 36;
            this.dgv_Assignments.EnableHeadersVisualStyles = false;
            this.dgv_Assignments.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgv_Assignments.Location = new System.Drawing.Point(10, 120);
            this.dgv_Assignments.Name = "dgv_Assignments";
            this.dgv_Assignments.ReadOnly = true;
            this.dgv_Assignments.RowHeadersVisible = false;
            this.dgv_Assignments.RowTemplate.Height = 28;
            this.dgv_Assignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Assignments.Size = new System.Drawing.Size(720, 140);
            this.dgv_Assignments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Assignments_CellClick);

            // Action bar (Add/Delete)
            this.pnl_actionBar.Controls.Add(this.btn_AddAssignment);
            this.pnl_actionBar.Controls.Add(this.btn_DeleteAssignment);
            this.pnl_actionBar.Location = new System.Drawing.Point(10, 265);
            this.pnl_actionBar.Size = new System.Drawing.Size(720, 34);

            this.btn_AddAssignment.BackColor = accent;
            this.btn_AddAssignment.FlatAppearance.BorderSize = 0;
            this.btn_AddAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAssignment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_AddAssignment.ForeColor = System.Drawing.Color.White;
            this.btn_AddAssignment.Location = new System.Drawing.Point(0, 0);
            this.btn_AddAssignment.Size = new System.Drawing.Size(130, 34);
            this.btn_AddAssignment.Text = "➕ Add";
            this.btn_AddAssignment.UseVisualStyleBackColor = false;
            this.btn_AddAssignment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddAssignment.Click += new System.EventHandler(this.btn_AddAssignment_Click);

            this.btn_DeleteAssignment.BackColor = danger;
            this.btn_DeleteAssignment.FlatAppearance.BorderSize = 0;
            this.btn_DeleteAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteAssignment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteAssignment.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteAssignment.Location = new System.Drawing.Point(140, 0);
            this.btn_DeleteAssignment.Size = new System.Drawing.Size(130, 34);
            this.btn_DeleteAssignment.Text = "🗑 Delete";
            this.btn_DeleteAssignment.UseVisualStyleBackColor = false;
            this.btn_DeleteAssignment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteAssignment.Click += new System.EventHandler(this.btn_DeleteAssignment_Click);

            // Add Assignment Panel (initially hidden)
            this.pnl_addAssignment.BackColor = cardBg;
            this.pnl_addAssignment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_addAssignment.Controls.Add(this.lbl_addDetails);
            this.pnl_addAssignment.Controls.Add(this.txt_AssignmentDetails);
            this.pnl_addAssignment.Controls.Add(this.lbl_deadline);
            this.pnl_addAssignment.Controls.Add(this.dtp_Deadline);
            this.pnl_addAssignment.Controls.Add(this.btn_SaveAssignment);
            this.pnl_addAssignment.Controls.Add(this.btn_CancelAdd);
            this.pnl_addAssignment.Location = new System.Drawing.Point(10, 300);
            this.pnl_addAssignment.Name = "pnl_addAssignment";
            this.pnl_addAssignment.Size = new System.Drawing.Size(720, 130);
            this.pnl_addAssignment.Visible = false;

            this.lbl_addDetails.AutoSize = false;
            this.lbl_addDetails.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_addDetails.ForeColor = labelClr;
            this.lbl_addDetails.Location = new System.Drawing.Point(14, 10);
            this.lbl_addDetails.Size = new System.Drawing.Size(120, 20);
            this.lbl_addDetails.Text = "Details:";

            this.txt_AssignmentDetails.BackColor = inputBg;
            this.txt_AssignmentDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AssignmentDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_AssignmentDetails.Location = new System.Drawing.Point(14, 32);
            this.txt_AssignmentDetails.Multiline = true;
            this.txt_AssignmentDetails.Size = new System.Drawing.Size(400, 60);

            this.lbl_deadline.AutoSize = false;
            this.lbl_deadline.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_deadline.Location = new System.Drawing.Point(430, 10);
            this.lbl_deadline.Size = new System.Drawing.Size(100, 20);
            this.lbl_deadline.Text = "Deadline:";

            this.dtp_Deadline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_Deadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Deadline.Location = new System.Drawing.Point(430, 32);
            this.dtp_Deadline.Size = new System.Drawing.Size(150, 26);

            this.btn_SaveAssignment.BackColor = success;
            this.btn_SaveAssignment.FlatAppearance.BorderSize = 0;
            this.btn_SaveAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveAssignment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_SaveAssignment.ForeColor = System.Drawing.Color.White;
            this.btn_SaveAssignment.Location = new System.Drawing.Point(430, 70);
            this.btn_SaveAssignment.Size = new System.Drawing.Size(80, 28);
            this.btn_SaveAssignment.Text = "Save";
            this.btn_SaveAssignment.UseVisualStyleBackColor = false;
            this.btn_SaveAssignment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveAssignment.Click += new System.EventHandler(this.btn_SaveAssignment_Click);

            this.btn_CancelAdd.BackColor = neutral;
            this.btn_CancelAdd.FlatAppearance.BorderSize = 0;
            this.btn_CancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_CancelAdd.ForeColor = System.Drawing.Color.White;
            this.btn_CancelAdd.Location = new System.Drawing.Point(520, 70);
            this.btn_CancelAdd.Size = new System.Drawing.Size(60, 28);
            this.btn_CancelAdd.Text = "Cancel";
            this.btn_CancelAdd.UseVisualStyleBackColor = false;
            this.btn_CancelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelAdd.Click += new System.EventHandler(this.btn_CancelAdd_Click);

            // Search Student Submission
            this.pnl_searchBar.Controls.Add(this.lbl_searchStudent);
            this.pnl_searchBar.Controls.Add(this.txt_SearchStudent);
            this.pnl_searchBar.Controls.Add(this.btn_SearchStudent);
            this.pnl_searchBar.Location = new System.Drawing.Point(10, 435);
            this.pnl_searchBar.Size = new System.Drawing.Size(720, 36);

            this.lbl_searchStudent.AutoSize = false;
            this.lbl_searchStudent.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_searchStudent.ForeColor = labelClr;
            this.lbl_searchStudent.Location = new System.Drawing.Point(0, 8);
            this.lbl_searchStudent.Size = new System.Drawing.Size(100, 20);
            this.lbl_searchStudent.Text = "🔍 Student:";

            this.txt_SearchStudent.BackColor = inputBg;
            this.txt_SearchStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SearchStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SearchStudent.Location = new System.Drawing.Point(100, 5);
            this.txt_SearchStudent.Size = new System.Drawing.Size(200, 26);

            this.btn_SearchStudent.BackColor = accent;
            this.btn_SearchStudent.FlatAppearance.BorderSize = 0;
            this.btn_SearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_SearchStudent.ForeColor = System.Drawing.Color.White;
            this.btn_SearchStudent.Location = new System.Drawing.Point(310, 5);
            this.btn_SearchStudent.Size = new System.Drawing.Size(80, 26);
            this.btn_SearchStudent.Text = "Search";
            this.btn_SearchStudent.UseVisualStyleBackColor = false;
            this.btn_SearchStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchStudent.Click += new System.EventHandler(this.btn_SearchStudent_Click);

            this.dgv_Submissions.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Submissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Submissions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Submissions.ColumnHeadersHeight = 36;
            this.dgv_Submissions.EnableHeadersVisualStyles = false;
            this.dgv_Submissions.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgv_Submissions.Location = new System.Drawing.Point(10, 475);
            this.dgv_Submissions.Name = "dgv_Submissions";
            this.dgv_Submissions.ReadOnly = true;
            this.dgv_Submissions.RowHeadersVisible = false;
            this.dgv_Submissions.RowTemplate.Height = 28;
            this.dgv_Submissions.Size = new System.Drawing.Size(720, 85);

            // User Control
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = pageBg;
            this.Controls.Add(this.pnl_pageHeader);
            this.Controls.Add(this.pnl_formCard);
            this.Controls.Add(this.dgv_Assignments);
            this.Controls.Add(this.pnl_actionBar);
            this.Controls.Add(this.pnl_addAssignment);
            this.Controls.Add(this.pnl_searchBar);
            this.Controls.Add(this.dgv_Submissions);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UC_TeacherAssignmentManager";
            this.Size = new System.Drawing.Size(740, 568);
            this.Load += new System.EventHandler(this.UC_TeacherAssignmentManager_Load);

            this.pnl_pageHeader.ResumeLayout(false);
            this.pnl_formCard.ResumeLayout(false);
            this.pnl_formHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Assignments)).EndInit();
            this.pnl_actionBar.ResumeLayout(false);
            this.pnl_addAssignment.ResumeLayout(false);
            this.pnl_addAssignment.PerformLayout();
            this.pnl_searchBar.ResumeLayout(false);
            this.pnl_searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Submissions)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_pageHeader;
        private System.Windows.Forms.Label lbl_pageTitle;

        private System.Windows.Forms.Panel pnl_formCard;
        private System.Windows.Forms.Panel pnl_formHeader;
        private System.Windows.Forms.Label lbl_formTitle;
        private System.Windows.Forms.Label lbl_selectCourse;
        private System.Windows.Forms.ComboBox cmb_Course;

        private System.Windows.Forms.DataGridView dgv_Assignments;

        private System.Windows.Forms.Panel pnl_actionBar;
        private System.Windows.Forms.Button btn_AddAssignment;
        private System.Windows.Forms.Button btn_DeleteAssignment;

        private System.Windows.Forms.Panel pnl_addAssignment;
        private System.Windows.Forms.Label lbl_addDetails;
        private System.Windows.Forms.TextBox txt_AssignmentDetails;
        private System.Windows.Forms.Label lbl_deadline;
        private System.Windows.Forms.DateTimePicker dtp_Deadline;
        private System.Windows.Forms.Button btn_SaveAssignment;
        private System.Windows.Forms.Button btn_CancelAdd;

        private System.Windows.Forms.Panel pnl_searchBar;
        private System.Windows.Forms.Label lbl_searchStudent;
        private System.Windows.Forms.TextBox txt_SearchStudent;
        private System.Windows.Forms.Button btn_SearchStudent;
        private System.Windows.Forms.DataGridView dgv_Submissions;
    }
}