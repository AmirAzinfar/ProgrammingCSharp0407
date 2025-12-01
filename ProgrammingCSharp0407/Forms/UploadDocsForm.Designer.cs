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
            WorkExperiencButton = new Button();
            EducationButton = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            MotivationStatusLabel = new Label();
            CVStatusLabel = new Label();
            WorkExperiencStatusLabel = new Label();
            EducationStatusLabel = new Label();
            WorkCerteficateLabel = new Label();
            WorkCertificateButton = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.ForeColor = Color.White;
            label1.Location = new Point(658, 111);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 1;
            label1.Text = ":انگیزه نامه ";
            // 
            // MotivationButton
            // 
            MotivationButton.BackColor = Color.LightGray;
            MotivationButton.Cursor = Cursors.Hand;
            MotivationButton.FlatAppearance.BorderColor = Color.White;
            MotivationButton.FlatAppearance.BorderSize = 2;
            MotivationButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            MotivationButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            MotivationButton.FlatStyle = FlatStyle.Flat;
            MotivationButton.Location = new Point(234, 104);
            MotivationButton.Name = "MotivationButton";
            MotivationButton.Size = new Size(180, 46);
            MotivationButton.TabIndex = 2;
            MotivationButton.Text = "اینجا آپلود کنید";
            MotivationButton.UseVisualStyleBackColor = false;
            MotivationButton.Click += MotivationButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(602, 190);
            label2.Name = "label2";
            label2.Size = new Size(184, 32);
            label2.TabIndex = 3;
            label2.Text = ":زندگی نامه (CV) ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(559, 271);
            label3.Name = "label3";
            label3.Size = new Size(227, 32);
            label3.TabIndex = 5;
            label3.Text = ":آخرین مدرک تحصیلی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(657, 350);
            label4.Name = "label4";
            label4.Size = new Size(128, 32);
            label4.TabIndex = 7;
            label4.Text = ":سابقه کاری";
            // 
            // CVButton
            // 
            CVButton.BackColor = Color.LightGray;
            CVButton.Cursor = Cursors.Hand;
            CVButton.FlatAppearance.BorderColor = Color.White;
            CVButton.FlatAppearance.BorderSize = 2;
            CVButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            CVButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            CVButton.FlatStyle = FlatStyle.Flat;
            CVButton.Location = new Point(234, 183);
            CVButton.Name = "CVButton";
            CVButton.Size = new Size(180, 46);
            CVButton.TabIndex = 8;
            CVButton.Text = "اینجا آپلود کنید";
            CVButton.UseVisualStyleBackColor = false;
            CVButton.Click += CVButton_Click;
            // 
            // WorkExperiencButton
            // 
            WorkExperiencButton.BackColor = Color.LightGray;
            WorkExperiencButton.Cursor = Cursors.Hand;
            WorkExperiencButton.FlatAppearance.BorderColor = Color.White;
            WorkExperiencButton.FlatAppearance.BorderSize = 2;
            WorkExperiencButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            WorkExperiencButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            WorkExperiencButton.FlatStyle = FlatStyle.Flat;
            WorkExperiencButton.Location = new Point(234, 343);
            WorkExperiencButton.Name = "WorkExperiencButton";
            WorkExperiencButton.Size = new Size(180, 46);
            WorkExperiencButton.TabIndex = 10;
            WorkExperiencButton.Text = "اینجا آپلود کنید";
            WorkExperiencButton.UseVisualStyleBackColor = false;
            WorkExperiencButton.Click += WorkExperiencButton_Click;
            // 
            // EducationButton
            // 
            EducationButton.BackColor = Color.LightGray;
            EducationButton.Cursor = Cursors.Hand;
            EducationButton.FlatAppearance.BorderColor = Color.White;
            EducationButton.FlatAppearance.BorderSize = 2;
            EducationButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            EducationButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            EducationButton.FlatStyle = FlatStyle.Flat;
            EducationButton.Location = new Point(234, 264);
            EducationButton.Name = "EducationButton";
            EducationButton.Size = new Size(180, 46);
            EducationButton.TabIndex = 9;
            EducationButton.Text = "اینجا آپلود کنید";
            EducationButton.UseVisualStyleBackColor = false;
            EducationButton.Click += EducationButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(588, 34);
            label5.Name = "label5";
            label5.Size = new Size(198, 37);
            label5.TabIndex = 11;
            label5.Text = ":مدارک مورد نیاز";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(75, 34);
            label6.Name = "label6";
            label6.Size = new Size(115, 37);
            label6.TabIndex = 12;
            label6.Text = ":وضعیت";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Popup;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(53, 71);
            label7.Name = "label7";
            label7.Size = new Size(734, 32);
            label7.TabIndex = 13;
            label7.Text = "------------------------------------------------------------------------";
            // 
            // MotivationStatusLabel
            // 
            MotivationStatusLabel.AutoSize = true;
            MotivationStatusLabel.BackColor = Color.Transparent;
            MotivationStatusLabel.FlatStyle = FlatStyle.Popup;
            MotivationStatusLabel.ForeColor = Color.FromArgb(224, 224, 224);
            MotivationStatusLabel.Location = new Point(53, 111);
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
            CVStatusLabel.ForeColor = Color.FromArgb(224, 224, 224);
            CVStatusLabel.Location = new Point(59, 190);
            CVStatusLabel.Name = "CVStatusLabel";
            CVStatusLabel.Size = new Size(151, 32);
            CVStatusLabel.TabIndex = 15;
            CVStatusLabel.Text = "بارگذاری نشده";
            // 
            // WorkExperiencStatusLabel
            // 
            WorkExperiencStatusLabel.AutoSize = true;
            WorkExperiencStatusLabel.BackColor = Color.Transparent;
            WorkExperiencStatusLabel.FlatStyle = FlatStyle.Popup;
            WorkExperiencStatusLabel.ForeColor = Color.FromArgb(224, 224, 224);
            WorkExperiencStatusLabel.Location = new Point(59, 350);
            WorkExperiencStatusLabel.Name = "WorkExperiencStatusLabel";
            WorkExperiencStatusLabel.Size = new Size(151, 32);
            WorkExperiencStatusLabel.TabIndex = 17;
            WorkExperiencStatusLabel.Text = "بارگذاری نشده";
            // 
            // EducationStatusLabel
            // 
            EducationStatusLabel.AutoSize = true;
            EducationStatusLabel.BackColor = Color.Transparent;
            EducationStatusLabel.FlatStyle = FlatStyle.Popup;
            EducationStatusLabel.ForeColor = Color.FromArgb(224, 224, 224);
            EducationStatusLabel.Location = new Point(53, 271);
            EducationStatusLabel.Name = "EducationStatusLabel";
            EducationStatusLabel.Size = new Size(151, 32);
            EducationStatusLabel.TabIndex = 16;
            EducationStatusLabel.Text = "بارگذاری نشده";
            // 
            // WorkCerteficateLabel
            // 
            WorkCerteficateLabel.AutoSize = true;
            WorkCerteficateLabel.BackColor = Color.Transparent;
            WorkCerteficateLabel.FlatStyle = FlatStyle.Popup;
            WorkCerteficateLabel.ForeColor = Color.FromArgb(224, 224, 224);
            WorkCerteficateLabel.Location = new Point(55, 432);
            WorkCerteficateLabel.Name = "WorkCerteficateLabel";
            WorkCerteficateLabel.Size = new Size(151, 32);
            WorkCerteficateLabel.TabIndex = 20;
            WorkCerteficateLabel.Text = "بارگذاری نشده";
            // 
            // WorkCertificateButton
            // 
            WorkCertificateButton.BackColor = Color.LightGray;
            WorkCertificateButton.Cursor = Cursors.Hand;
            WorkCertificateButton.FlatAppearance.BorderColor = Color.White;
            WorkCertificateButton.FlatAppearance.BorderSize = 2;
            WorkCertificateButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            WorkCertificateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            WorkCertificateButton.FlatStyle = FlatStyle.Flat;
            WorkCertificateButton.Location = new Point(234, 425);
            WorkCertificateButton.Name = "WorkCertificateButton";
            WorkCertificateButton.Size = new Size(180, 46);
            WorkCertificateButton.TabIndex = 19;
            WorkCertificateButton.Text = "اینجا آپلود کنید";
            WorkCertificateButton.UseVisualStyleBackColor = false;
            WorkCertificateButton.Click += WorkCertificateButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(470, 432);
            label9.Name = "label9";
            label9.Size = new Size(315, 32);
            label9.TabIndex = 18;
            label9.Text = ":گواهی کار (اگر موجود میباشد)";
            // 
            // UploadDocsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(825, 535);
            Controls.Add(WorkCerteficateLabel);
            Controls.Add(WorkCertificateButton);
            Controls.Add(label9);
            Controls.Add(WorkExperiencStatusLabel);
            Controls.Add(EducationStatusLabel);
            Controls.Add(CVStatusLabel);
            Controls.Add(MotivationStatusLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(WorkExperiencButton);
            Controls.Add(EducationButton);
            Controls.Add(CVButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MotivationButton);
            Controls.Add(label1);
            Name = "UploadDocsForm";
            Text = "صفحه بارگذاری مدارک";
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
        private Button WorkExperiencButton;
        private Button EducationButton;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label MotivationStatusLabel;
        private Label CVStatusLabel;
        private Label WorkExperiencStatusLabel;
        private Label EducationStatusLabel;
        private Label WorkCerteficateLabel;
        private Button WorkCertificateButton;
        private Label label9;
    }
}