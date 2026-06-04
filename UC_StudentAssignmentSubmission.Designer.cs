namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class UC_StudentAssignmentSubmission
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
            this.pnl_infoCards = new System.Windows.Forms.Panel();
            this.pnl_cardLeft = new System.Windows.Forms.Panel();
            this.lbl_leftIcon = new System.Windows.Forms.Label();
            this.lbl_leftCount = new System.Windows.Forms.Label();
            this.lbl_leftTitle = new System.Windows.Forms.Label();
            this.pnl_cardSubmitted = new System.Windows.Forms.Panel();
            this.lbl_subIcon = new System.Windows.Forms.Label();
            this.lbl_subCount = new System.Windows.Forms.Label();
            this.lbl_subTitle = new System.Windows.Forms.Label();
            this.pnl_searchBar = new System.Windows.Forms.Panel();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.dgv_Assignments = new System.Windows.Forms.DataGridView();
            this.pnl_submit = new System.Windows.Forms.Panel();
            this.lbl_submitTitle = new System.Windows.Forms.Label();
            this.lbl_selectedAssignment = new System.Windows.Forms.Label();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.pnl_pageHeader.SuspendLayout();
            this.pnl_infoCards.SuspendLayout();
            this.pnl_cardLeft.SuspendLayout();
            this.pnl_cardSubmitted.SuspendLayout();
            this.pnl_searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Assignments)).BeginInit();
            this.pnl_submit.SuspendLayout();
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
            this.lbl_pageTitle.Text = "  📝  My Assignments";
            // 
            // pnl_infoCards
            // 
            this.pnl_infoCards.Controls.Add(this.pnl_cardLeft);
            this.pnl_infoCards.Controls.Add(this.pnl_cardSubmitted);
            this.pnl_infoCards.Location = new System.Drawing.Point(10, 44);
            this.pnl_infoCards.Name = "pnl_infoCards";
            this.pnl_infoCards.Size = new System.Drawing.Size(720, 80);
            this.pnl_infoCards.TabIndex = 1;
            // 
            // pnl_cardLeft
            // 
            this.pnl_cardLeft.BackColor = System.Drawing.Color.White;
            this.pnl_cardLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_cardLeft.Controls.Add(this.lbl_leftIcon);
            this.pnl_cardLeft.Controls.Add(this.lbl_leftCount);
            this.pnl_cardLeft.Controls.Add(this.lbl_leftTitle);
            this.pnl_cardLeft.Location = new System.Drawing.Point(0, 0);
            this.pnl_cardLeft.Name = "pnl_cardLeft";
            this.pnl_cardLeft.Size = new System.Drawing.Size(200, 80);
            this.pnl_cardLeft.TabIndex = 0;
            // 
            // lbl_leftIcon
            // 
            this.lbl_leftIcon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbl_leftIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.lbl_leftIcon.Location = new System.Drawing.Point(10, 5);
            this.lbl_leftIcon.Name = "lbl_leftIcon";
            this.lbl_leftIcon.Size = new System.Drawing.Size(40, 30);
            this.lbl_leftIcon.TabIndex = 0;
            this.lbl_leftIcon.Text = "📋";
            // 
            // lbl_leftCount
            // 
            this.lbl_leftCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_leftCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lbl_leftCount.Location = new System.Drawing.Point(60, 5);
            this.lbl_leftCount.Name = "lbl_leftCount";
            this.lbl_leftCount.Size = new System.Drawing.Size(130, 30);
            this.lbl_leftCount.TabIndex = 1;
            this.lbl_leftCount.Text = "0";
            // 
            // lbl_leftTitle
            // 
            this.lbl_leftTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lbl_leftTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbl_leftTitle.Location = new System.Drawing.Point(10, 50);
            this.lbl_leftTitle.Name = "lbl_leftTitle";
            this.lbl_leftTitle.Size = new System.Drawing.Size(180, 20);
            this.lbl_leftTitle.TabIndex = 2;
            this.lbl_leftTitle.Text = "Assignments Left";
            // 
            // pnl_cardSubmitted
            // 
            this.pnl_cardSubmitted.BackColor = System.Drawing.Color.White;
            this.pnl_cardSubmitted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_cardSubmitted.Controls.Add(this.lbl_subIcon);
            this.pnl_cardSubmitted.Controls.Add(this.lbl_subCount);
            this.pnl_cardSubmitted.Controls.Add(this.lbl_subTitle);
            this.pnl_cardSubmitted.Location = new System.Drawing.Point(220, 0);
            this.pnl_cardSubmitted.Name = "pnl_cardSubmitted";
            this.pnl_cardSubmitted.Size = new System.Drawing.Size(200, 80);
            this.pnl_cardSubmitted.TabIndex = 1;
            // 
            // lbl_subIcon
            // 
            this.lbl_subIcon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbl_subIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lbl_subIcon.Location = new System.Drawing.Point(10, 5);
            this.lbl_subIcon.Name = "lbl_subIcon";
            this.lbl_subIcon.Size = new System.Drawing.Size(40, 30);
            this.lbl_subIcon.TabIndex = 0;
            this.lbl_subIcon.Text = "✅";
            // 
            // lbl_subCount
            // 
            this.lbl_subCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_subCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lbl_subCount.Location = new System.Drawing.Point(60, 5);
            this.lbl_subCount.Name = "lbl_subCount";
            this.lbl_subCount.Size = new System.Drawing.Size(130, 30);
            this.lbl_subCount.TabIndex = 1;
            this.lbl_subCount.Text = "0";
            // 
            // lbl_subTitle
            // 
            this.lbl_subTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lbl_subTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbl_subTitle.Location = new System.Drawing.Point(10, 50);
            this.lbl_subTitle.Name = "lbl_subTitle";
            this.lbl_subTitle.Size = new System.Drawing.Size(180, 20);
            this.lbl_subTitle.TabIndex = 2;
            this.lbl_subTitle.Text = "Submitted";
            // 
            // pnl_searchBar
            // 
            this.pnl_searchBar.Controls.Add(this.lbl_search);
            this.pnl_searchBar.Controls.Add(this.txt_Search);
            this.pnl_searchBar.Controls.Add(this.btn_Search);
            this.pnl_searchBar.Controls.Add(this.btn_ShowAll);
            this.pnl_searchBar.Location = new System.Drawing.Point(10, 130);
            this.pnl_searchBar.Name = "pnl_searchBar";
            this.pnl_searchBar.Size = new System.Drawing.Size(720, 36);
            this.pnl_searchBar.TabIndex = 2;
            // 
            // lbl_search
            // 
            this.lbl_search.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_search.Location = new System.Drawing.Point(0, 8);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(80, 20);
            this.lbl_search.TabIndex = 0;
            this.lbl_search.Text = "🔍 Course:";
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.Location = new System.Drawing.Point(85, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(180, 27);
            this.txt_Search.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(270, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 26);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btn_ShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowAll.FlatAppearance.BorderSize = 0;
            this.btn_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_ShowAll.ForeColor = System.Drawing.Color.White;
            this.btn_ShowAll.Location = new System.Drawing.Point(360, 5);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(80, 26);
            this.btn_ShowAll.TabIndex = 3;
            this.btn_ShowAll.Text = "Show All";
            this.btn_ShowAll.UseVisualStyleBackColor = false;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // dgv_Assignments
            // 
            this.dgv_Assignments.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Assignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Assignments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Assignments.ColumnHeadersHeight = 36;
            this.dgv_Assignments.EnableHeadersVisualStyles = false;
            this.dgv_Assignments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgv_Assignments.Location = new System.Drawing.Point(10, 172);
            this.dgv_Assignments.Name = "dgv_Assignments";
            this.dgv_Assignments.ReadOnly = true;
            this.dgv_Assignments.RowHeadersVisible = false;
            this.dgv_Assignments.RowHeadersWidth = 51;
            this.dgv_Assignments.RowTemplate.Height = 28;
            this.dgv_Assignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Assignments.Size = new System.Drawing.Size(720, 230);
            this.dgv_Assignments.TabIndex = 3;
            this.dgv_Assignments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Assignments_CellClick);
            // 
            // pnl_submit
            // 
            this.pnl_submit.BackColor = System.Drawing.Color.White;
            this.pnl_submit.Controls.Add(this.lbl_submitTitle);
            this.pnl_submit.Controls.Add(this.lbl_selectedAssignment);
            this.pnl_submit.Controls.Add(this.lbl_answer);
            this.pnl_submit.Controls.Add(this.txt_Answer);
            this.pnl_submit.Controls.Add(this.btn_Submit);
            this.pnl_submit.Location = new System.Drawing.Point(10, 408);
            this.pnl_submit.Name = "pnl_submit";
            this.pnl_submit.Size = new System.Drawing.Size(720, 150);
            this.pnl_submit.TabIndex = 4;
            // 
            // lbl_submitTitle
            // 
            this.lbl_submitTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_submitTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lbl_submitTitle.Location = new System.Drawing.Point(10, 5);
            this.lbl_submitTitle.Name = "lbl_submitTitle";
            this.lbl_submitTitle.Size = new System.Drawing.Size(200, 20);
            this.lbl_submitTitle.TabIndex = 0;
            this.lbl_submitTitle.Text = "Submit Answer";
            // 
            // lbl_selectedAssignment
            // 
            this.lbl_selectedAssignment.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lbl_selectedAssignment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_selectedAssignment.Location = new System.Drawing.Point(10, 28);
            this.lbl_selectedAssignment.Name = "lbl_selectedAssignment";
            this.lbl_selectedAssignment.Size = new System.Drawing.Size(400, 16);
            this.lbl_selectedAssignment.TabIndex = 1;
            this.lbl_selectedAssignment.Text = "Select an assignment from the list.";
            // 
            // lbl_answer
            // 
            this.lbl_answer.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_answer.Location = new System.Drawing.Point(10, 48);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(80, 16);
            this.lbl_answer.TabIndex = 2;
            this.lbl_answer.Text = "Your Answer:";
            // 
            // txt_Answer
            // 
            this.txt_Answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txt_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Answer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Answer.Location = new System.Drawing.Point(10, 66);
            this.txt_Answer.Multiline = true;
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(500, 60);
            this.txt_Answer.TabIndex = 3;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.FlatAppearance.BorderSize = 0;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(520, 90);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(130, 34);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "📩 Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // UC_StudentAssignmentSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnl_pageHeader);
            this.Controls.Add(this.pnl_infoCards);
            this.Controls.Add(this.pnl_searchBar);
            this.Controls.Add(this.dgv_Assignments);
            this.Controls.Add(this.pnl_submit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UC_StudentAssignmentSubmission";
            this.Size = new System.Drawing.Size(740, 568);
            this.Load += new System.EventHandler(this.UC_StudentAssignmentSubmission_Load);
            this.pnl_pageHeader.ResumeLayout(false);
            this.pnl_infoCards.ResumeLayout(false);
            this.pnl_cardLeft.ResumeLayout(false);
            this.pnl_cardSubmitted.ResumeLayout(false);
            this.pnl_searchBar.ResumeLayout(false);
            this.pnl_searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Assignments)).EndInit();
            this.pnl_submit.ResumeLayout(false);
            this.pnl_submit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_pageHeader;
        private System.Windows.Forms.Label lbl_pageTitle;

        private System.Windows.Forms.Panel pnl_infoCards;
        private System.Windows.Forms.Panel pnl_cardLeft;
        private System.Windows.Forms.Label lbl_leftIcon;
        private System.Windows.Forms.Label lbl_leftCount;
        private System.Windows.Forms.Label lbl_leftTitle;
        private System.Windows.Forms.Panel pnl_cardSubmitted;
        private System.Windows.Forms.Label lbl_subIcon;
        private System.Windows.Forms.Label lbl_subCount;
        private System.Windows.Forms.Label lbl_subTitle;

        private System.Windows.Forms.Panel pnl_searchBar;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ShowAll;

        private System.Windows.Forms.DataGridView dgv_Assignments;

        private System.Windows.Forms.Panel pnl_submit;
        private System.Windows.Forms.Label lbl_submitTitle;
        private System.Windows.Forms.Label lbl_selectedAssignment;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.Button btn_Submit;
    }
}