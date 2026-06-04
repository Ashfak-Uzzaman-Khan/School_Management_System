namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class UC_StudentTeacherReview
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

            this.lbl_teacherSearch = new System.Windows.Forms.Label();
            this.txt_TeacherSearch = new System.Windows.Forms.TextBox();
            this.btn_SearchTeacher = new System.Windows.Forms.Button();
            this.lbl_selectedTeacher = new System.Windows.Forms.Label();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.num_Rating = new System.Windows.Forms.NumericUpDown();
            this.lbl_review = new System.Windows.Forms.Label();
            this.txt_ReviewText = new System.Windows.Forms.TextBox();
            this.btn_SubmitReview = new System.Windows.Forms.Button();

            this.dgv_MyReviews = new System.Windows.Forms.DataGridView();

            this.pnl_pageHeader.SuspendLayout();
            this.pnl_formCard.SuspendLayout();
            this.pnl_formHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MyReviews)).BeginInit();
            this.SuspendLayout();

            // Colours
            System.Drawing.Color primary = System.Drawing.Color.FromArgb(30, 58, 138);
            System.Drawing.Color pageBg = System.Drawing.Color.FromArgb(241, 245, 249);
            System.Drawing.Color cardBg = System.Drawing.Color.White;
            System.Drawing.Color inputBg = System.Drawing.Color.FromArgb(248, 250, 252);
            System.Drawing.Color stripBg = System.Drawing.Color.FromArgb(239, 246, 255);
            System.Drawing.Color success = System.Drawing.Color.FromArgb(22, 163, 74);
            System.Drawing.Color accent = System.Drawing.Color.FromArgb(59, 130, 246);
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
            this.lbl_pageTitle.Text = "  ⭐  Teacher Review";
            this.lbl_pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Form Card
            this.pnl_formCard.BackColor = cardBg;
            this.pnl_formCard.Controls.Add(this.pnl_formHeader);
            this.pnl_formCard.Controls.Add(this.lbl_teacherSearch);
            this.pnl_formCard.Controls.Add(this.txt_TeacherSearch);
            this.pnl_formCard.Controls.Add(this.btn_SearchTeacher);
            this.pnl_formCard.Controls.Add(this.lbl_selectedTeacher);
            this.pnl_formCard.Controls.Add(this.lbl_rating);
            this.pnl_formCard.Controls.Add(this.num_Rating);
            this.pnl_formCard.Controls.Add(this.lbl_review);
            this.pnl_formCard.Controls.Add(this.txt_ReviewText);
            this.pnl_formCard.Controls.Add(this.btn_SubmitReview);
            this.pnl_formCard.Location = new System.Drawing.Point(10, 44);
            this.pnl_formCard.Name = "pnl_formCard";
            this.pnl_formCard.Size = new System.Drawing.Size(720, 230);
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
            this.lbl_formTitle.Text = "  Give a Teacher Review";
            this.lbl_formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Search Teacher
            this.lbl_teacherSearch.AutoSize = false;
            this.lbl_teacherSearch.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_teacherSearch.ForeColor = labelClr;
            this.lbl_teacherSearch.Location = new System.Drawing.Point(14, 40);
            this.lbl_teacherSearch.Name = "lbl_teacherSearch";
            this.lbl_teacherSearch.Size = new System.Drawing.Size(120, 20);
            this.lbl_teacherSearch.TabIndex = 1;
            this.lbl_teacherSearch.Text = "Search Teacher:";

            this.txt_TeacherSearch.BackColor = inputBg;
            this.txt_TeacherSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TeacherSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TeacherSearch.Location = new System.Drawing.Point(14, 62);
            this.txt_TeacherSearch.Name = "txt_TeacherSearch";
            this.txt_TeacherSearch.Size = new System.Drawing.Size(200, 26);
            this.txt_TeacherSearch.TabIndex = 0;

            this.btn_SearchTeacher.BackColor = accent;
            this.btn_SearchTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchTeacher.FlatAppearance.BorderSize = 0;
            this.btn_SearchTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_SearchTeacher.ForeColor = System.Drawing.Color.White;
            this.btn_SearchTeacher.Location = new System.Drawing.Point(220, 62);
            this.btn_SearchTeacher.Name = "btn_SearchTeacher";
            this.btn_SearchTeacher.Size = new System.Drawing.Size(80, 26);
            this.btn_SearchTeacher.TabIndex = 1;
            this.btn_SearchTeacher.Text = "Search";
            this.btn_SearchTeacher.UseVisualStyleBackColor = false;
            this.btn_SearchTeacher.Click += new System.EventHandler(this.btn_SearchTeacher_Click);

            this.lbl_selectedTeacher.AutoSize = false;
            this.lbl_selectedTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_selectedTeacher.ForeColor = primary;
            this.lbl_selectedTeacher.Location = new System.Drawing.Point(14, 100);
            this.lbl_selectedTeacher.Name = "lbl_selectedTeacher";
            this.lbl_selectedTeacher.Size = new System.Drawing.Size(300, 20);
            this.lbl_selectedTeacher.TabIndex = 4;
            this.lbl_selectedTeacher.Text = "Selected Teacher: None";

            // Rating
            this.lbl_rating.AutoSize = false;
            this.lbl_rating.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_rating.ForeColor = labelClr;
            this.lbl_rating.Location = new System.Drawing.Point(14, 130);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(80, 20);
            this.lbl_rating.TabIndex = 5;
            this.lbl_rating.Text = "Rating (1-5):";

            this.num_Rating.BackColor = inputBg;
            this.num_Rating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Rating.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num_Rating.Location = new System.Drawing.Point(100, 128);
            this.num_Rating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.num_Rating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.num_Rating.Name = "num_Rating";
            this.num_Rating.Size = new System.Drawing.Size(60, 26);
            this.num_Rating.TabIndex = 3;
            this.num_Rating.Value = new decimal(new int[] { 5, 0, 0, 0 });

            // Review Text
            this.lbl_review.AutoSize = false;
            this.lbl_review.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_review.ForeColor = labelClr;
            this.lbl_review.Location = new System.Drawing.Point(14, 165);
            this.lbl_review.Name = "lbl_review";
            this.lbl_review.Size = new System.Drawing.Size(120, 20);
            this.lbl_review.TabIndex = 7;
            this.lbl_review.Text = "Review Text:";

            this.txt_ReviewText.BackColor = inputBg;
            this.txt_ReviewText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReviewText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ReviewText.Location = new System.Drawing.Point(14, 187);
            this.txt_ReviewText.Multiline = true;
            this.txt_ReviewText.Name = "txt_ReviewText";
            this.txt_ReviewText.Size = new System.Drawing.Size(692, 30);
            this.txt_ReviewText.TabIndex = 4;

            this.btn_SubmitReview.BackColor = success;
            this.btn_SubmitReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SubmitReview.FlatAppearance.BorderSize = 0;
            this.btn_SubmitReview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btn_SubmitReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SubmitReview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_SubmitReview.ForeColor = System.Drawing.Color.White;
            this.btn_SubmitReview.Location = new System.Drawing.Point(170, 128);
            this.btn_SubmitReview.Name = "btn_SubmitReview";
            this.btn_SubmitReview.Size = new System.Drawing.Size(150, 28);
            this.btn_SubmitReview.TabIndex = 5;
            this.btn_SubmitReview.Text = "⭐ Submit Review";
            this.btn_SubmitReview.UseVisualStyleBackColor = false;
            this.btn_SubmitReview.Click += new System.EventHandler(this.btn_SubmitReview_Click);

            // My Reviews Grid
            this.dgv_MyReviews.BackgroundColor = System.Drawing.Color.White;
            this.dgv_MyReviews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_MyReviews.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_MyReviews.ColumnHeadersHeight = 36;
            this.dgv_MyReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_MyReviews.EnableHeadersVisualStyles = false;
            this.dgv_MyReviews.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgv_MyReviews.Location = new System.Drawing.Point(10, 284);
            this.dgv_MyReviews.Name = "dgv_MyReviews";
            this.dgv_MyReviews.ReadOnly = true;
            this.dgv_MyReviews.RowHeadersVisible = false;
            this.dgv_MyReviews.RowTemplate.Height = 28;
            this.dgv_MyReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MyReviews.Size = new System.Drawing.Size(720, 270);
            this.dgv_MyReviews.TabIndex = 2;

            // User Control
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = pageBg;
            this.Controls.Add(this.pnl_pageHeader);
            this.Controls.Add(this.pnl_formCard);
            this.Controls.Add(this.dgv_MyReviews);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "UC_StudentTeacherReview";
            this.Size = new System.Drawing.Size(740, 568);
            this.Load += new System.EventHandler(this.UC_StudentTeacherReview_Load);

            this.pnl_pageHeader.ResumeLayout(false);
            this.pnl_formCard.ResumeLayout(false);
            this.pnl_formCard.PerformLayout();
            this.pnl_formHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MyReviews)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_pageHeader;
        private System.Windows.Forms.Label lbl_pageTitle;

        private System.Windows.Forms.Panel pnl_formCard;
        private System.Windows.Forms.Panel pnl_formHeader;
        private System.Windows.Forms.Label lbl_formTitle;
        private System.Windows.Forms.Label lbl_teacherSearch;
        private System.Windows.Forms.TextBox txt_TeacherSearch;
        private System.Windows.Forms.Button btn_SearchTeacher;
        private System.Windows.Forms.Label lbl_selectedTeacher;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.NumericUpDown num_Rating;
        private System.Windows.Forms.Label lbl_review;
        private System.Windows.Forms.TextBox txt_ReviewText;
        private System.Windows.Forms.Button btn_SubmitReview;

        private System.Windows.Forms.DataGridView dgv_MyReviews;
    }
}