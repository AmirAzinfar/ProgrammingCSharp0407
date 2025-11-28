namespace ProgrammingCSharp0407.Forms
{
    partial class JobManagmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobManagmentForm));
            label1 = new Label();
            FieldOfJobComboBox = new ComboBox();
            label2 = new Label();
            JobTitelComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SalaryTextBox = new TextBox();
            FullTimeRadioButton = new RadioButton();
            HalfTimeRadioButton = new RadioButton();
            ProvinzComboBox = new ComboBox();
            CityComboBox = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            NowRadioButton = new RadioButton();
            label10 = new Label();
            EnterancedateTimePicker = new DateTimePicker();
            AgreementRadioButton = new RadioButton();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            DeleteInfoFormbutton = new Button();
            RegisterApplybutton = new Button();
            CancelApplaybutton = new Button();
            JobAppliedDataGridView = new DataGridView();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)JobAppliedDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1624, 414);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 0;
            label1.Text = ":حوزه  کاری";
            // 
            // FieldOfJobComboBox
            // 
            FieldOfJobComboBox.FormattingEnabled = true;
            FieldOfJobComboBox.Location = new Point(984, 411);
            FieldOfJobComboBox.Name = "FieldOfJobComboBox";
            FieldOfJobComboBox.Size = new Size(499, 40);
            FieldOfJobComboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1603, 494);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 2;
            label2.Text = ":عنوان شغلی";
            // 
            // JobTitelComboBox
            // 
            JobTitelComboBox.FormattingEnabled = true;
            JobTitelComboBox.Location = new Point(984, 486);
            JobTitelComboBox.Name = "JobTitelComboBox";
            JobTitelComboBox.Size = new Size(499, 40);
            JobTitelComboBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1615, 660);
            label3.Name = "label3";
            label3.Size = new Size(134, 32);
            label3.TabIndex = 4;
            label3.Text = ":ساعت کاری";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1490, 580);
            label4.Name = "label4";
            label4.Size = new Size(263, 32);
            label4.TabIndex = 5;
            label4.Text = ":حقوق ماهانه (پیشنهادی)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1649, 739);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 6;
            label5.Text = ":محل کار";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1116, 573);
            label6.Name = "label6";
            label6.Size = new Size(70, 32);
            label6.TabIndex = 7;
            label6.Text = "تومان";
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.Location = new Point(1203, 573);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new Size(280, 39);
            SalaryTextBox.TabIndex = 3;
            // 
            // FullTimeRadioButton
            // 
            FullTimeRadioButton.AutoSize = true;
            FullTimeRadioButton.Location = new Point(1343, 660);
            FullTimeRadioButton.Name = "FullTimeRadioButton";
            FullTimeRadioButton.Size = new Size(140, 36);
            FullTimeRadioButton.TabIndex = 4;
            FullTimeRadioButton.TabStop = true;
            FullTimeRadioButton.Text = "تمام وقت";
            FullTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // HalfTimeRadioButton
            // 
            HalfTimeRadioButton.AutoSize = true;
            HalfTimeRadioButton.Location = new Point(1116, 658);
            HalfTimeRadioButton.Name = "HalfTimeRadioButton";
            HalfTimeRadioButton.Size = new Size(147, 36);
            HalfTimeRadioButton.TabIndex = 5;
            HalfTimeRadioButton.TabStop = true;
            HalfTimeRadioButton.Text = "نیمه وقت ";
            HalfTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProvinzComboBox
            // 
            ProvinzComboBox.FormattingEnabled = true;
            ProvinzComboBox.Location = new Point(984, 739);
            ProvinzComboBox.Name = "ProvinzComboBox";
            ProvinzComboBox.Size = new Size(387, 40);
            ProvinzComboBox.TabIndex = 6;
            // 
            // CityComboBox
            // 
            CityComboBox.FormattingEnabled = true;
            CityComboBox.Location = new Point(984, 799);
            CityComboBox.Name = "CityComboBox";
            CityComboBox.Size = new Size(387, 40);
            CityComboBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1408, 739);
            label7.Name = "label7";
            label7.Size = new Size(75, 32);
            label7.TabIndex = 13;
            label7.Text = ":استان";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1374, 799);
            label8.Name = "label8";
            label8.Size = new Size(109, 32);
            label8.TabIndex = 14;
            label8.Text = ":شهرستان";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1591, 893);
            label9.Name = "label9";
            label9.Size = new Size(158, 32);
            label9.TabIndex = 15;
            label9.Text = ":شروع به کار از";
            // 
            // NowRadioButton
            // 
            NowRadioButton.AutoSize = true;
            NowRadioButton.Location = new Point(1384, 952);
            NowRadioButton.Name = "NowRadioButton";
            NowRadioButton.Size = new Size(99, 36);
            NowRadioButton.TabIndex = 9;
            NowRadioButton.TabStop = true;
            NowRadioButton.Text = "اکنون";
            NowRadioButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1416, 893);
            label10.Name = "label10";
            label10.Size = new Size(74, 32);
            label10.TabIndex = 17;
            label10.Text = ":تاریخ ";
            // 
            // EnterancedateTimePicker
            // 
            EnterancedateTimePicker.Location = new Point(984, 893);
            EnterancedateTimePicker.Name = "EnterancedateTimePicker";
            EnterancedateTimePicker.Size = new Size(387, 39);
            EnterancedateTimePicker.TabIndex = 8;
            // 
            // AgreementRadioButton
            // 
            AgreementRadioButton.AutoSize = true;
            AgreementRadioButton.Location = new Point(1116, 952);
            AgreementRadioButton.Name = "AgreementRadioButton";
            AgreementRadioButton.Size = new Size(191, 36);
            AgreementRadioButton.TabIndex = 10;
            AgreementRadioButton.TabStop = true;
            AgreementRadioButton.Text = "به طور توافقی";
            AgreementRadioButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(1598, 44);
            label11.Name = "label11";
            label11.Size = new Size(166, 32);
            label11.TabIndex = 21;
            label11.Text = ":متقاضی گرامی";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1006, 794);
            label12.Name = "label12";
            label12.Size = new Size(0, 32);
            label12.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(-1545, 784);
            label13.Name = "label13";
            label13.Size = new Size(0, 32);
            label13.TabIndex = 23;
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label14
            // 
            label14.Location = new Point(934, 76);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.Yes;
            label14.Size = new Size(848, 189);
            label14.TabIndex = 11;
            label14.Text = resources.GetString("label14.Text");
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Location = new Point(1601, 256);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(163, 48);
            label15.TabIndex = 12;
            label15.Text = "با احترام فراوان ";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.Location = new Point(1545, 304);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.Yes;
            label16.Size = new Size(237, 48);
            label16.TabIndex = 24;
            label16.Text = "شرکت توسعه نیرو";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteInfoFormbutton
            // 
            DeleteInfoFormbutton.BackColor = Color.White;
            DeleteInfoFormbutton.Location = new Point(1252, 1058);
            DeleteInfoFormbutton.Name = "DeleteInfoFormbutton";
            DeleteInfoFormbutton.Size = new Size(231, 73);
            DeleteInfoFormbutton.TabIndex = 12;
            DeleteInfoFormbutton.Text = "حذف اطلاعات";
            DeleteInfoFormbutton.UseVisualStyleBackColor = false;
            // 
            // RegisterApplybutton
            // 
            RegisterApplybutton.BackColor = Color.Cyan;
            RegisterApplybutton.Location = new Point(984, 1058);
            RegisterApplybutton.Name = "RegisterApplybutton";
            RegisterApplybutton.Size = new Size(232, 73);
            RegisterApplybutton.TabIndex = 11;
            RegisterApplybutton.Text = "ثبت درخواست";
            RegisterApplybutton.UseVisualStyleBackColor = false;
            RegisterApplybutton.Click += RegisterApplybutton_Click;
            // 
            // CancelApplaybutton
            // 
            CancelApplaybutton.BackColor = Color.Transparent;
            CancelApplaybutton.Location = new Point(1518, 1058);
            CancelApplaybutton.Name = "CancelApplaybutton";
            CancelApplaybutton.Size = new Size(231, 73);
            CancelApplaybutton.TabIndex = 13;
            CancelApplaybutton.Text = "لغو درخواست";
            CancelApplaybutton.UseVisualStyleBackColor = false;
            // 
            // JobAppliedDataGridView
            // 
            JobAppliedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JobAppliedDataGridView.Location = new Point(35, 105);
            JobAppliedDataGridView.Name = "JobAppliedDataGridView";
            JobAppliedDataGridView.RowHeadersWidth = 82;
            JobAppliedDataGridView.Size = new Size(881, 1026);
            JobAppliedDataGridView.TabIndex = 25;
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.Location = new Point(961, 352);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.Yes;
            label17.Size = new Size(803, 41);
            label17.TabIndex = 26;
            label17.Text = "-------------------------------------------------------------------------------";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // JobManagmentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1816, 1185);
            Controls.Add(label17);
            Controls.Add(JobAppliedDataGridView);
            Controls.Add(CancelApplaybutton);
            Controls.Add(RegisterApplybutton);
            Controls.Add(DeleteInfoFormbutton);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(AgreementRadioButton);
            Controls.Add(EnterancedateTimePicker);
            Controls.Add(label10);
            Controls.Add(NowRadioButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(CityComboBox);
            Controls.Add(ProvinzComboBox);
            Controls.Add(HalfTimeRadioButton);
            Controls.Add(FullTimeRadioButton);
            Controls.Add(SalaryTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(JobTitelComboBox);
            Controls.Add(label2);
            Controls.Add(FieldOfJobComboBox);
            Controls.Add(label1);
            Name = "JobManagmentForm";
            Text = "JobManagmentForm";
            ((System.ComponentModel.ISupportInitialize)JobAppliedDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox FieldOfJobComboBox;
        private Label label2;
        private ComboBox JobTitelComboBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox SalaryTextBox;
        private RadioButton FullTimeRadioButton;
        private RadioButton HalfTimeRadioButton;
        private ComboBox ProvinzComboBox;
        private ComboBox CityComboBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private RadioButton NowRadioButton;
        private Label label10;
        private DateTimePicker EnterancedateTimePicker;
        private RadioButton AgreementRadioButton;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button DeleteInfoFormbutton;
        private Button RegisterApplybutton;
        private Button CancelApplaybutton;
        private DataGridView JobAppliedDataGridView;
        private Label label17;
    }
}