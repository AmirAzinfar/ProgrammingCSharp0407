namespace ProgrammingCSharp0407.Forms
{
    partial class UserManagmentForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            NationalCodeTextBox = new TextBox();
            PhoneNumberTextBox = new TextBox();
            RegisterUserbutton = new Button();
            ResetRegisterbutton = new Button();
            UserManageDataGridView = new DataGridView();
            SearchButton = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            BirthdayDateTimePicker = new DateTimePicker();
            DeleteInfoButton = new Button();
            UpdateButton = new Button();
            SearchTextBox = new TextBox();
            label7 = new Label();
            CloseButton = new Button();
            AdressUserButton = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)UserManageDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(128, 35);
            label1.Name = "label1";
            label1.Size = new Size(49, 32);
            label1.TabIndex = 0;
            label1.Text = "نام:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 83);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(685, 38);
            label3.Name = "label3";
            label3.Size = new Size(94, 32);
            label3.TabIndex = 2;
            label3.Text = "کد ملی:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(658, 83);
            label4.Name = "label4";
            label4.Size = new Size(128, 32);
            label4.TabIndex = 3;
            label4.Text = "تلفن همراه:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(197, 38);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(422, 39);
            FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(197, 84);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(422, 39);
            LastNameTextBox.TabIndex = 2;
            // 
            // NationalCodeTextBox
            // 
            NationalCodeTextBox.Location = new Point(790, 38);
            NationalCodeTextBox.Name = "NationalCodeTextBox";
            NationalCodeTextBox.Size = new Size(325, 39);
            NationalCodeTextBox.TabIndex = 4;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(790, 85);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(325, 39);
            PhoneNumberTextBox.TabIndex = 5;
            // 
            // RegisterUserbutton
            // 
            RegisterUserbutton.BackColor = Color.Gainsboro;
            RegisterUserbutton.Cursor = Cursors.Hand;
            RegisterUserbutton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            RegisterUserbutton.FlatStyle = FlatStyle.Flat;
            RegisterUserbutton.Location = new Point(1170, 223);
            RegisterUserbutton.Name = "RegisterUserbutton";
            RegisterUserbutton.Size = new Size(325, 64);
            RegisterUserbutton.TabIndex = 6;
            RegisterUserbutton.Text = "ثبت نام متقاضی";
            RegisterUserbutton.UseVisualStyleBackColor = false;
            RegisterUserbutton.Click += RegisterUserbutton_Click;
            // 
            // ResetRegisterbutton
            // 
            ResetRegisterbutton.BackColor = Color.Gainsboro;
            ResetRegisterbutton.Cursor = Cursors.Hand;
            ResetRegisterbutton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            ResetRegisterbutton.FlatStyle = FlatStyle.Flat;
            ResetRegisterbutton.Location = new Point(1170, 301);
            ResetRegisterbutton.Name = "ResetRegisterbutton";
            ResetRegisterbutton.Size = new Size(325, 64);
            ResetRegisterbutton.TabIndex = 7;
            ResetRegisterbutton.Text = "تنظیم مجدد فرم";
            ResetRegisterbutton.UseVisualStyleBackColor = false;
            ResetRegisterbutton.Click += ResetRegisterbutton_Click;
            // 
            // UserManageDataGridView
            // 
            UserManageDataGridView.BackgroundColor = Color.WhiteSmoke;
            UserManageDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserManageDataGridView.Location = new Point(31, 198);
            UserManageDataGridView.Name = "UserManageDataGridView";
            UserManageDataGridView.RowHeadersWidth = 82;
            UserManageDataGridView.Size = new Size(1084, 758);
            UserManageDataGridView.TabIndex = 7;
            UserManageDataGridView.CellClick += UserManageDataGridView_CellClick;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.LightGray;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Location = new Point(1170, 884);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(93, 45);
            SearchButton.TabIndex = 10;
            SearchButton.Text = "جستجو ";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSlateGray;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1196, 77);
            label5.Name = "label5";
            label5.Size = new Size(299, 45);
            label5.TabIndex = 8;
            label5.Text = "فرم ثبت نام نیروی کار";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Test2;
            pictureBox1.Location = new Point(1149, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 758);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(61, 130);
            label6.Name = "label6";
            label6.Size = new Size(116, 32);
            label6.TabIndex = 10;
            label6.Text = "تاریخ تولد:";
            // 
            // BirthdayDateTimePicker
            // 
            BirthdayDateTimePicker.Location = new Point(197, 130);
            BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            BirthdayDateTimePicker.Size = new Size(422, 39);
            BirthdayDateTimePicker.TabIndex = 3;
            // 
            // DeleteInfoButton
            // 
            DeleteInfoButton.BackColor = Color.Gainsboro;
            DeleteInfoButton.Cursor = Cursors.Hand;
            DeleteInfoButton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            DeleteInfoButton.FlatStyle = FlatStyle.Flat;
            DeleteInfoButton.Location = new Point(1170, 381);
            DeleteInfoButton.Name = "DeleteInfoButton";
            DeleteInfoButton.Size = new Size(325, 64);
            DeleteInfoButton.TabIndex = 8;
            DeleteInfoButton.Text = "حذف اطلاعات وارد شده ";
            DeleteInfoButton.UseVisualStyleBackColor = false;
            DeleteInfoButton.Click += DeleteInfoButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.Gainsboro;
            UpdateButton.Cursor = Cursors.Hand;
            UpdateButton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Location = new Point(1170, 462);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(325, 64);
            UpdateButton.TabIndex = 9;
            UpdateButton.Text = "به روز رسانی";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(1269, 884);
            SearchTextBox.Multiline = true;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(226, 45);
            SearchTextBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(696, 130);
            label7.Name = "label7";
            label7.Size = new Size(0, 32);
            label7.TabIndex = 11;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Gainsboro;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(1170, 544);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(325, 64);
            CloseButton.TabIndex = 13;
            CloseButton.Text = "بستن فرم";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // AdressUserButton
            // 
            AdressUserButton.BackColor = Color.Gainsboro;
            AdressUserButton.Cursor = Cursors.Hand;
            AdressUserButton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            AdressUserButton.FlatStyle = FlatStyle.Flat;
            AdressUserButton.ForeColor = Color.MidnightBlue;
            AdressUserButton.Location = new Point(790, 130);
            AdressUserButton.Name = "AdressUserButton";
            AdressUserButton.Size = new Size(325, 46);
            AdressUserButton.TabIndex = 14;
            AdressUserButton.Text = "آدرس کاربر را وارد کنید";
            AdressUserButton.UseVisualStyleBackColor = false;
            AdressUserButton.Click += AdressUserButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(704, 137);
            label8.Name = "label8";
            label8.Size = new Size(75, 32);
            label8.TabIndex = 15;
            label8.Text = "آدرس:";
            // 
            // UserManagmentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1558, 987);
            Controls.Add(label8);
            Controls.Add(AdressUserButton);
            Controls.Add(CloseButton);
            Controls.Add(SearchTextBox);
            Controls.Add(label7);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteInfoButton);
            Controls.Add(BirthdayDateTimePicker);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(SearchButton);
            Controls.Add(UserManageDataGridView);
            Controls.Add(ResetRegisterbutton);
            Controls.Add(RegisterUserbutton);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(NationalCodeTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "UserManagmentForm";
            Text = "ثبت نام کاربر";
            ((System.ComponentModel.ISupportInitialize)UserManageDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox NationalCodeTextBox;
        private TextBox PhoneNumberTextBox;
        private Button RegisterUserbutton;
        private Button ResetRegisterbutton;
        private DataGridView UserManageDataGridView;
        private Button SearchButton;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private DateTimePicker BirthdayDateTimePicker;
        private Button DeleteInfoButton;
        private Button UpdateButton;
        private TextBox SearchTextBox;
        private Label label7;
        private Button CloseButton;
        private Button AdressUserButton;
        private Label label8;
    }
}