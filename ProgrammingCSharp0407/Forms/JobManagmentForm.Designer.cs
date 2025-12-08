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
            ProvinceComboBox = new ComboBox();
            CityComboBox = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            EnteranceDateTimePicker = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            DeleteJobButton = new Button();
            RegisterApplybutton = new Button();
            CancelApplaybutton = new Button();
            JobAppliedDataGridView = new DataGridView();
            label17 = new Label();
            label18 = new Label();
            BothRadioButton = new RadioButton();
            ImmediatelyCheckBox = new CheckBox();
            WithAgreeCheckBox = new CheckBox();
            UpdateJobButton = new Button();
            ((System.ComponentModel.ISupportInitialize)JobAppliedDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1639, 414);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 0;
            label1.Text = ":حوزه  کاری";
            // 
            // FieldOfJobComboBox
            // 
            FieldOfJobComboBox.BackColor = Color.FromArgb(224, 224, 224);
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
            label2.ForeColor = Color.White;
            label2.Location = new Point(1618, 494);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 2;
            label2.Text = ":عنوان شغلی";
            // 
            // JobTitelComboBox
            // 
            JobTitelComboBox.BackColor = Color.FromArgb(224, 224, 224);
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
            label3.ForeColor = Color.White;
            label3.Location = new Point(1630, 660);
            label3.Name = "label3";
            label3.Size = new Size(134, 32);
            label3.TabIndex = 4;
            label3.Text = ":ساعت کاری";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1501, 576);
            label4.Name = "label4";
            label4.Size = new Size(263, 32);
            label4.TabIndex = 5;
            label4.Text = ":حقوق ماهانه (پیشنهادی)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1664, 739);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 6;
            label5.Text = ":محل کار";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(1123, 575);
            label6.Name = "label6";
            label6.Size = new Size(70, 32);
            label6.TabIndex = 7;
            label6.Text = "تومان";
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.BackColor = Color.FromArgb(224, 224, 224);
            SalaryTextBox.Location = new Point(1203, 573);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new Size(280, 39);
            SalaryTextBox.TabIndex = 3;
            // 
            // FullTimeRadioButton
            // 
            FullTimeRadioButton.AutoSize = true;
            FullTimeRadioButton.ForeColor = Color.White;
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
            HalfTimeRadioButton.ForeColor = Color.White;
            HalfTimeRadioButton.Location = new Point(1190, 658);
            HalfTimeRadioButton.Name = "HalfTimeRadioButton";
            HalfTimeRadioButton.Size = new Size(147, 36);
            HalfTimeRadioButton.TabIndex = 5;
            HalfTimeRadioButton.TabStop = true;
            HalfTimeRadioButton.Text = "نیمه وقت ";
            HalfTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProvinceComboBox
            // 
            ProvinceComboBox.BackColor = Color.FromArgb(224, 224, 224);
            ProvinceComboBox.FormattingEnabled = true;
            ProvinceComboBox.Location = new Point(984, 739);
            ProvinceComboBox.Name = "ProvinceComboBox";
            ProvinceComboBox.Size = new Size(387, 40);
            ProvinceComboBox.TabIndex = 6;
            // 
            // CityComboBox
            // 
            CityComboBox.BackColor = Color.FromArgb(224, 224, 224);
            CityComboBox.FormattingEnabled = true;
            CityComboBox.Location = new Point(984, 799);
            CityComboBox.Name = "CityComboBox";
            CityComboBox.Size = new Size(387, 40);
            CityComboBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(1408, 739);
            label7.Name = "label7";
            label7.Size = new Size(75, 32);
            label7.TabIndex = 13;
            label7.Text = ":استان";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
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
            label9.ForeColor = Color.White;
            label9.Location = new Point(1606, 893);
            label9.Name = "label9";
            label9.Size = new Size(158, 32);
            label9.TabIndex = 15;
            label9.Text = ":شروع به کار از";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(1416, 893);
            label10.Name = "label10";
            label10.Size = new Size(74, 32);
            label10.TabIndex = 17;
            label10.Text = ":تاریخ ";
            // 
            // EnteranceDateTimePicker
            // 
            EnteranceDateTimePicker.Location = new Point(984, 893);
            EnteranceDateTimePicker.Name = "EnteranceDateTimePicker";
            EnteranceDateTimePicker.Size = new Size(387, 39);
            EnteranceDateTimePicker.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.WhiteSmoke;
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
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.WhiteSmoke;
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
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.WhiteSmoke;
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
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.WhiteSmoke;
            label16.Location = new Point(1545, 304);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.Yes;
            label16.Size = new Size(237, 48);
            label16.TabIndex = 24;
            label16.Text = "شرکت توسعه نیرو";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteJobButton
            // 
            DeleteJobButton.BackColor = Color.FromArgb(224, 224, 224);
            DeleteJobButton.Cursor = Cursors.Hand;
            DeleteJobButton.FlatAppearance.BorderColor = Color.White;
            DeleteJobButton.FlatAppearance.BorderSize = 2;
            DeleteJobButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            DeleteJobButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            DeleteJobButton.FlatStyle = FlatStyle.Flat;
            DeleteJobButton.Location = new Point(1408, 1053);
            DeleteJobButton.Name = "DeleteJobButton";
            DeleteJobButton.Size = new Size(170, 73);
            DeleteJobButton.TabIndex = 12;
            DeleteJobButton.Text = "لغو درخواست";
            DeleteJobButton.UseVisualStyleBackColor = false;
            DeleteJobButton.Click += DeleteJobButton_Click;
            // 
            // RegisterApplybutton
            // 
            RegisterApplybutton.BackColor = Color.Chartreuse;
            RegisterApplybutton.Cursor = Cursors.Hand;
            RegisterApplybutton.FlatAppearance.BorderColor = Color.White;
            RegisterApplybutton.FlatAppearance.BorderSize = 2;
            RegisterApplybutton.FlatAppearance.MouseDownBackColor = Color.Silver;
            RegisterApplybutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            RegisterApplybutton.FlatStyle = FlatStyle.Flat;
            RegisterApplybutton.Location = new Point(984, 1053);
            RegisterApplybutton.Name = "RegisterApplybutton";
            RegisterApplybutton.Size = new Size(242, 73);
            RegisterApplybutton.TabIndex = 11;
            RegisterApplybutton.Text = "ثبت درخواست";
            RegisterApplybutton.UseVisualStyleBackColor = false;
            RegisterApplybutton.Click += RegisterApplybutton_Click;
            // 
            // CancelApplaybutton
            // 
            CancelApplaybutton.BackColor = Color.FromArgb(224, 224, 224);
            CancelApplaybutton.Cursor = Cursors.Hand;
            CancelApplaybutton.FlatAppearance.BorderColor = Color.White;
            CancelApplaybutton.FlatAppearance.BorderSize = 2;
            CancelApplaybutton.FlatAppearance.MouseDownBackColor = Color.Silver;
            CancelApplaybutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            CancelApplaybutton.FlatStyle = FlatStyle.Flat;
            CancelApplaybutton.Location = new Point(1584, 1053);
            CancelApplaybutton.Name = "CancelApplaybutton";
            CancelApplaybutton.Size = new Size(159, 73);
            CancelApplaybutton.TabIndex = 13;
            CancelApplaybutton.Text = "بستن صفحه";
            CancelApplaybutton.UseVisualStyleBackColor = false;
            CancelApplaybutton.Click += CancelApplaybutton_Click;
            // 
            // JobAppliedDataGridView
            // 
            JobAppliedDataGridView.BackgroundColor = Color.Silver;
            JobAppliedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JobAppliedDataGridView.Location = new Point(35, 44);
            JobAppliedDataGridView.Name = "JobAppliedDataGridView";
            JobAppliedDataGridView.RowHeadersWidth = 82;
            JobAppliedDataGridView.Size = new Size(881, 1082);
            JobAppliedDataGridView.TabIndex = 25;
            JobAppliedDataGridView.CellClick += JobAppliedDataGridView_CellClick;
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.ForeColor = Color.White;
            label17.Location = new Point(961, 369);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.Yes;
            label17.Size = new Size(803, 41);
            label17.TabIndex = 26;
            label17.Text = "-------------------------------------------------------------------------------";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BackColor = Color.Transparent;
            label18.ForeColor = Color.White;
            label18.Location = new Point(961, 998);
            label18.Name = "label18";
            label18.RightToLeft = RightToLeft.Yes;
            label18.Size = new Size(803, 41);
            label18.TabIndex = 27;
            label18.Text = "-------------------------------------------------------------------------------";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BothRadioButton
            // 
            BothRadioButton.AutoSize = true;
            BothRadioButton.ForeColor = Color.White;
            BothRadioButton.Location = new Point(1073, 658);
            BothRadioButton.Name = "BothRadioButton";
            BothRadioButton.Size = new Size(102, 36);
            BothRadioButton.TabIndex = 28;
            BothRadioButton.TabStop = true;
            BothRadioButton.Text = "هر دو";
            BothRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImmediatelyCheckBox
            // 
            ImmediatelyCheckBox.AutoSize = true;
            ImmediatelyCheckBox.ForeColor = Color.White;
            ImmediatelyCheckBox.Location = new Point(1297, 959);
            ImmediatelyCheckBox.Name = "ImmediatelyCheckBox";
            ImmediatelyCheckBox.Size = new Size(91, 36);
            ImmediatelyCheckBox.TabIndex = 29;
            ImmediatelyCheckBox.Text = "فوراً ";
            ImmediatelyCheckBox.UseVisualStyleBackColor = true;
            // 
            // WithAgreeCheckBox
            // 
            WithAgreeCheckBox.AutoSize = true;
            WithAgreeCheckBox.ForeColor = Color.White;
            WithAgreeCheckBox.Location = new Point(984, 959);
            WithAgreeCheckBox.Name = "WithAgreeCheckBox";
            WithAgreeCheckBox.Size = new Size(199, 36);
            WithAgreeCheckBox.TabIndex = 30;
            WithAgreeCheckBox.Text = "به طور توافقی ";
            WithAgreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateJobButton
            // 
            UpdateJobButton.BackColor = Color.FromArgb(224, 224, 224);
            UpdateJobButton.Cursor = Cursors.Hand;
            UpdateJobButton.FlatAppearance.BorderColor = Color.White;
            UpdateJobButton.FlatAppearance.BorderSize = 2;
            UpdateJobButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            UpdateJobButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            UpdateJobButton.FlatStyle = FlatStyle.Flat;
            UpdateJobButton.Location = new Point(1232, 1053);
            UpdateJobButton.Name = "UpdateJobButton";
            UpdateJobButton.Size = new Size(170, 73);
            UpdateJobButton.TabIndex = 31;
            UpdateJobButton.Text = "به روز رسانی ";
            UpdateJobButton.UseVisualStyleBackColor = false;
            UpdateJobButton.Click += UpdateJobButton_Click;
            // 
            // JobManagmentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1816, 1169);
            Controls.Add(UpdateJobButton);
            Controls.Add(WithAgreeCheckBox);
            Controls.Add(ImmediatelyCheckBox);
            Controls.Add(BothRadioButton);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(JobAppliedDataGridView);
            Controls.Add(CancelApplaybutton);
            Controls.Add(RegisterApplybutton);
            Controls.Add(DeleteJobButton);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(EnteranceDateTimePicker);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(CityComboBox);
            Controls.Add(ProvinceComboBox);
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
            Text = "فرم درخواست";
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
        private ComboBox ProvinceComboBox;
        private ComboBox CityComboBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker EnteranceDateTimePicker;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button DeleteJobButton;
        private Button RegisterApplybutton;
        private Button CancelApplaybutton;
        private DataGridView JobAppliedDataGridView;
        private Label label17;
        private Label label18;
        private RadioButton BothRadioButton;
        private CheckBox ImmediatelyCheckBox;
        private CheckBox WithAgreeCheckBox;
        private Button UpdateJobButton;
    }
}