namespace ProgrammingCSharp0407.Forms
{
    partial class UploadDocsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            MotivationButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CVButton = new Button();
            JobExperiencButton = new Button();
            EducationButton = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            MotivationStatusLabel = new Label();
            CVStatusLabel = new Label();
            JobExperiencStatusLabel = new Label();
            EducationStatusLabel = new Label();
            EmploymentReferenceLabel = new Label();
            EmploymentReferenceButton = new Button();
            label9 = new Label();
            ConfirmButton = new Button();
            CancelButton = new Button();
            DeleteFileButton = new Button();
            UpdateUploadButton = new Button();
            UploadDocListView = new ListView();
            Id = new ColumnHeader();
            Motivation = new ColumnHeader();
            Education = new ColumnHeader();
            JobExperience = new ColumnHeader();
            CV = new ColumnHeader();
            EmploymentReference = new ColumnHeader();
            CreatedAt = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.ForeColor = Color.White;
            label1.Location = new Point(751, 127);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 1;
            label1.Text = "انگیزه نامه ";
            // 
            // MotivationButton
            // 
            MotivationButton.BackColor = Color.Transparent;
            MotivationButton.Cursor = Cursors.Hand;
            MotivationButton.FlatAppearance.BorderColor = Color.White;
            MotivationButton.FlatAppearance.BorderSize = 2;
            MotivationButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            MotivationButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            MotivationButton.FlatStyle = FlatStyle.Flat;
            MotivationButton.ForeColor = Color.Cyan;
            MotivationButton.Location = new Point(227, 120);
            MotivationButton.Name = "MotivationButton";
            MotivationButton.Size = new Size(180, 46);
            MotivationButton.TabIndex = 1;
            MotivationButton.Text = "اینجا آپلود کنید";
            MotivationButton.UseVisualStyleBackColor = false;
            MotivationButton.Click += MotivationButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(695, 182);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 3;
            label2.Text = "زندگی نامه (CV) ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(652, 237);
            label3.Name = "label3";
            label3.Size = new Size(222, 32);
            label3.TabIndex = 5;
            label3.Text = "آخرین مدرک تحصیلی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(750, 299);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 7;
            label4.Text = "تجربه کاری";
            // 
            // CVButton
            // 
            CVButton.BackColor = Color.Transparent;
            CVButton.Cursor = Cursors.Hand;
            CVButton.FlatAppearance.BorderColor = Color.White;
            CVButton.FlatAppearance.BorderSize = 2;
            CVButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            CVButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            CVButton.FlatStyle = FlatStyle.Flat;
            CVButton.ForeColor = Color.Cyan;
            CVButton.Location = new Point(227, 177);
            CVButton.Name = "CVButton";
            CVButton.Size = new Size(180, 46);
            CVButton.TabIndex = 2;
            CVButton.Text = "اینجا آپلود کنید";
            CVButton.UseVisualStyleBackColor = false;
            CVButton.Click += CVButton_Click;
            // 
            // JobExperiencButton
            // 
            JobExperiencButton.BackColor = Color.Transparent;
            JobExperiencButton.Cursor = Cursors.Hand;
            JobExperiencButton.FlatAppearance.BorderColor = Color.White;
            JobExperiencButton.FlatAppearance.BorderSize = 2;
            JobExperiencButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            JobExperiencButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            JobExperiencButton.FlatStyle = FlatStyle.Flat;
            JobExperiencButton.ForeColor = Color.Cyan;
            JobExperiencButton.Location = new Point(227, 293);
            JobExperiencButton.Name = "JobExperiencButton";
            JobExperiencButton.Size = new Size(180, 46);
            JobExperiencButton.TabIndex = 4;
            JobExperiencButton.Text = "اینجا آپلود کنید";
            JobExperiencButton.UseVisualStyleBackColor = false;
            JobExperiencButton.Click += JobExperiencButton_Click;
            // 
            // EducationButton
            // 
            EducationButton.BackColor = Color.Transparent;
            EducationButton.Cursor = Cursors.Hand;
            EducationButton.FlatAppearance.BorderColor = Color.White;
            EducationButton.FlatAppearance.BorderSize = 2;
            EducationButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            EducationButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            EducationButton.FlatStyle = FlatStyle.Flat;
            EducationButton.ForeColor = Color.Cyan;
            EducationButton.Location = new Point(227, 235);
            EducationButton.Name = "EducationButton";
            EducationButton.Size = new Size(180, 46);
            EducationButton.TabIndex = 3;
            EducationButton.Text = "اینجا آپلود کنید";
            EducationButton.UseVisualStyleBackColor = false;
            EducationButton.Click += EducationButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Aqua;
            label5.Location = new Point(681, 34);
            label5.Name = "label5";
            label5.Size = new Size(198, 37);
            label5.TabIndex = 11;
            label5.Text = ":مدارک مورد نیاز";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Aqua;
            label6.Location = new Point(75, 34);
            label6.Name = "label6";
            label6.Size = new Size(108, 37);
            label6.TabIndex = 12;
            label6.Text = "وضعیت";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Popup;
            label7.ForeColor = Color.White;
            label7.Location = new Point(53, 67);
            label7.Name = "label7";
            label7.Size = new Size(824, 32);
            label7.TabIndex = 13;
            label7.Text = "---------------------------------------------------------------------------------";
            // 
            // MotivationStatusLabel
            // 
            MotivationStatusLabel.AutoSize = true;
            MotivationStatusLabel.BackColor = Color.Transparent;
            MotivationStatusLabel.FlatStyle = FlatStyle.Popup;
            MotivationStatusLabel.ForeColor = Color.White;
            MotivationStatusLabel.Location = new Point(46, 127);
            MotivationStatusLabel.Name = "MotivationStatusLabel";
            MotivationStatusLabel.Size = new Size(151, 32);
            MotivationStatusLabel.TabIndex = 14;
            MotivationStatusLabel.Text = "بارگذاری نشده";
            // 
            // CVStatusLabel
            // 
            CVStatusLabel.AutoSize = true;
            CVStatusLabel.BackColor = Color.Transparent;
            CVStatusLabel.FlatStyle = FlatStyle.Popup;
            CVStatusLabel.ForeColor = Color.White;
            CVStatusLabel.Location = new Point(46, 182);
            CVStatusLabel.Name = "CVStatusLabel";
            CVStatusLabel.Size = new Size(151, 32);
            CVStatusLabel.TabIndex = 15;
            CVStatusLabel.Text = "بارگذاری نشده";
            // 
            // JobExperiencStatusLabel
            // 
            JobExperiencStatusLabel.AutoSize = true;
            JobExperiencStatusLabel.BackColor = Color.Transparent;
            JobExperiencStatusLabel.FlatStyle = FlatStyle.Popup;
            JobExperiencStatusLabel.ForeColor = Color.White;
            JobExperiencStatusLabel.Location = new Point(46, 302);
            JobExperiencStatusLabel.Name = "JobExperiencStatusLabel";
            JobExperiencStatusLabel.Size = new Size(151, 32);
            JobExperiencStatusLabel.TabIndex = 17;
            JobExperiencStatusLabel.Text = "بارگذاری نشده";
            // 
            // EducationStatusLabel
            // 
            EducationStatusLabel.AutoSize = true;
            EducationStatusLabel.BackColor = Color.Transparent;
            EducationStatusLabel.FlatStyle = FlatStyle.Popup;
            EducationStatusLabel.ForeColor = Color.White;
            EducationStatusLabel.Location = new Point(42, 241);
            EducationStatusLabel.Name = "EducationStatusLabel";
            EducationStatusLabel.Size = new Size(151, 32);
            EducationStatusLabel.TabIndex = 16;
            EducationStatusLabel.Text = "بارگذاری نشده";
            // 
            // EmploymentReferenceLabel
            // 
            EmploymentReferenceLabel.AutoSize = true;
            EmploymentReferenceLabel.BackColor = Color.Transparent;
            EmploymentReferenceLabel.FlatStyle = FlatStyle.Popup;
            EmploymentReferenceLabel.ForeColor = Color.White;
            EmploymentReferenceLabel.Location = new Point(42, 361);
            EmploymentReferenceLabel.Name = "EmploymentReferenceLabel";
            EmploymentReferenceLabel.Size = new Size(151, 32);
            EmploymentReferenceLabel.TabIndex = 20;
            EmploymentReferenceLabel.Text = "بارگذاری نشده";
            // 
            // EmploymentReferenceButton
            // 
            EmploymentReferenceButton.BackColor = Color.Transparent;
            EmploymentReferenceButton.Cursor = Cursors.Hand;
            EmploymentReferenceButton.FlatAppearance.BorderColor = Color.White;
            EmploymentReferenceButton.FlatAppearance.BorderSize = 2;
            EmploymentReferenceButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            EmploymentReferenceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            EmploymentReferenceButton.FlatStyle = FlatStyle.Flat;
            EmploymentReferenceButton.ForeColor = Color.Cyan;
            EmploymentReferenceButton.Location = new Point(227, 352);
            EmploymentReferenceButton.Name = "EmploymentReferenceButton";
            EmploymentReferenceButton.Size = new Size(180, 46);
            EmploymentReferenceButton.TabIndex = 5;
            EmploymentReferenceButton.Text = "اینجا آپلود کنید";
            EmploymentReferenceButton.UseVisualStyleBackColor = false;
            EmploymentReferenceButton.Click += EmploymentReferenceButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(481, 361);
            label9.Name = "label9";
            label9.Size = new Size(386, 32);
            label9.TabIndex = 18;
            label9.Text = "معرفی‌نامه شغلی (اگر موجود میباشد)";
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.FromArgb(224, 224, 224);
            ConfirmButton.Cursor = Cursors.Hand;
            ConfirmButton.FlatAppearance.BorderColor = Color.White;
            ConfirmButton.FlatAppearance.BorderSize = 2;
            ConfirmButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            ConfirmButton.FlatAppearance.MouseOverBackColor = Color.Aqua;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmButton.ForeColor = Color.Black;
            ConfirmButton.Location = new Point(663, 452);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(197, 79);
            ConfirmButton.TabIndex = 6;
            ConfirmButton.Text = "ثبت مدارک";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(224, 224, 224);
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.FlatAppearance.BorderColor = Color.White;
            CancelButton.FlatAppearance.BorderSize = 2;
            CancelButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            CancelButton.FlatAppearance.MouseOverBackColor = Color.Aqua;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(42, 452);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(197, 79);
            CancelButton.TabIndex = 9;
            CancelButton.Text = "بستن صفحه ";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // DeleteFileButton
            // 
            DeleteFileButton.BackColor = Color.FromArgb(224, 224, 224);
            DeleteFileButton.Cursor = Cursors.Hand;
            DeleteFileButton.FlatAppearance.BorderColor = Color.White;
            DeleteFileButton.FlatAppearance.BorderSize = 2;
            DeleteFileButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            DeleteFileButton.FlatAppearance.MouseOverBackColor = Color.Aqua;
            DeleteFileButton.FlatStyle = FlatStyle.Flat;
            DeleteFileButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteFileButton.ForeColor = Color.Black;
            DeleteFileButton.Location = new Point(456, 452);
            DeleteFileButton.Name = "DeleteFileButton";
            DeleteFileButton.Size = new Size(197, 79);
            DeleteFileButton.TabIndex = 7;
            DeleteFileButton.Text = "حذف فایل";
            DeleteFileButton.UseVisualStyleBackColor = false;
            DeleteFileButton.Click += DeleteFileButton_Click;
            // 
            // UpdateUploadButton
            // 
            UpdateUploadButton.BackColor = Color.FromArgb(224, 224, 224);
            UpdateUploadButton.Cursor = Cursors.Hand;
            UpdateUploadButton.FlatAppearance.BorderColor = Color.White;
            UpdateUploadButton.FlatAppearance.BorderSize = 2;
            UpdateUploadButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            UpdateUploadButton.FlatAppearance.MouseOverBackColor = Color.Aqua;
            UpdateUploadButton.FlatStyle = FlatStyle.Flat;
            UpdateUploadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateUploadButton.ForeColor = Color.Black;
            UpdateUploadButton.Location = new Point(249, 452);
            UpdateUploadButton.Name = "UpdateUploadButton";
            UpdateUploadButton.Size = new Size(197, 79);
            UpdateUploadButton.TabIndex = 8;
            UpdateUploadButton.Text = "به روز رسانی";
            UpdateUploadButton.UseVisualStyleBackColor = false;
            UpdateUploadButton.Click += UpdateUploadButton_Click;
            // 
            // UploadDocListView
            // 
            UploadDocListView.BackColor = Color.DarkSeaGreen;
            UploadDocListView.Columns.AddRange(new ColumnHeader[] { Id, Motivation, Education, JobExperience, CV, EmploymentReference, CreatedAt });
            UploadDocListView.ForeColor = Color.FromArgb(64, 64, 64);
            UploadDocListView.FullRowSelect = true;
            UploadDocListView.GridLines = true;
            UploadDocListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            UploadDocListView.Location = new Point(42, 560);
            UploadDocListView.Name = "UploadDocListView";
            UploadDocListView.Size = new Size(818, 440);
            UploadDocListView.TabIndex = 10;
            UploadDocListView.UseCompatibleStateImageBehavior = false;
            UploadDocListView.View = View.Details;
            UploadDocListView.SelectedIndexChanged += UploadDocListView_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 50;
            // 
            // Motivation
            // 
            Motivation.Text = "Motivation";
            Motivation.TextAlign = HorizontalAlignment.Center;
            Motivation.Width = 150;
            // 
            // Education
            // 
            Education.Text = "Education";
            Education.TextAlign = HorizontalAlignment.Center;
            Education.Width = 150;
            // 
            // JobExperience
            // 
            JobExperience.Text = "JobExperience";
            JobExperience.TextAlign = HorizontalAlignment.Center;
            JobExperience.Width = 200;
            // 
            // CV
            // 
            CV.Text = "CV";
            CV.TextAlign = HorizontalAlignment.Center;
            // 
            // EmploymentReference
            // 
            EmploymentReference.Text = "EmploymentReference";
            EmploymentReference.TextAlign = HorizontalAlignment.Center;
            EmploymentReference.Width = 230;
            // 
            // CreatedAt
            // 
            CreatedAt.Text = "CreatedAt";
            CreatedAt.TextAlign = HorizontalAlignment.Center;
            CreatedAt.Width = 150;
            // 
            // UploadDocsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(902, 1012);
            Controls.Add(UploadDocListView);
            Controls.Add(DeleteFileButton);
            Controls.Add(UpdateUploadButton);
            Controls.Add(CancelButton);
            Controls.Add(ConfirmButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(EmploymentReferenceLabel);
            Controls.Add(EmploymentReferenceButton);
            Controls.Add(label9);
            Controls.Add(JobExperiencStatusLabel);
            Controls.Add(EducationStatusLabel);
            Controls.Add(CVStatusLabel);
            Controls.Add(MotivationStatusLabel);
            Controls.Add(label7);
            Controls.Add(JobExperiencButton);
            Controls.Add(EducationButton);
            Controls.Add(CVButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MotivationButton);
            Controls.Add(label1);
            Name = "UploadDocsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صفحه بارگذاری مدارک";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button MotivationButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button CVButton;
        private Button JobExperiencButton;
        private Button EducationButton;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label MotivationStatusLabel;
        private Label CVStatusLabel;
        private Label JobExperiencStatusLabel;
        private Label EducationStatusLabel;
        private Label EmploymentReferenceLabel;
        private Button EmploymentReferenceButton;
        private Label label9;
        private Button ConfirmButton;
        private Button CancelButton;
        private Button DeleteFileButton;
        private Button UpdateUploadButton;
        private ListView UploadDocListView;
        private ColumnHeader Id;
        private ColumnHeader Motivation;
        private ColumnHeader Education;
        private ColumnHeader JobExperience;
        private ColumnHeader CV;
        private ColumnHeader EmploymentReference;
        private ColumnHeader CreatedAt;
    }
}