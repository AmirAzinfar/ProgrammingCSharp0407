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
            DeleteRegisterbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 35);
            label1.Name = "label1";
            label1.Size = new Size(47, 32);
            label1.TabIndex = 0;
            label1.Text = "نام:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 117);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(582, 35);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 2;
            label3.Text = "کد ملی:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 114);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 3;
            label4.Text = "تلفن همراه:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(197, 38);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(325, 39);
            FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(197, 117);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(325, 39);
            LastNameTextBox.TabIndex = 2;
            // 
            // NationalCodeTextBox
            // 
            NationalCodeTextBox.Location = new Point(687, 35);
            NationalCodeTextBox.Name = "NationalCodeTextBox";
            NationalCodeTextBox.Size = new Size(325, 39);
            NationalCodeTextBox.TabIndex = 3;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(687, 114);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(325, 39);
            PhoneNumberTextBox.TabIndex = 4;
            // 
            // RegisterUserbutton
            // 
            RegisterUserbutton.Location = new Point(197, 205);
            RegisterUserbutton.Name = "RegisterUserbutton";
            RegisterUserbutton.Size = new Size(325, 64);
            RegisterUserbutton.TabIndex = 5;
            RegisterUserbutton.Text = "ثبت نام متقاضی";
            RegisterUserbutton.UseVisualStyleBackColor = true;
            RegisterUserbutton.Click += RegisterUserbutton_Click;
            // 
            // DeleteRegisterbutton
            // 
            DeleteRegisterbutton.Location = new Point(687, 205);
            DeleteRegisterbutton.Name = "DeleteRegisterbutton";
            DeleteRegisterbutton.Size = new Size(325, 64);
            DeleteRegisterbutton.TabIndex = 6;
            DeleteRegisterbutton.Text = "حذف اطلاعات فرم";
            DeleteRegisterbutton.UseVisualStyleBackColor = true;
            DeleteRegisterbutton.Click += DeleteRegisterbutton_Click;
            // 
            // UserManagmentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 801);
            Controls.Add(DeleteRegisterbutton);
            Controls.Add(RegisterUserbutton);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(NationalCodeTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserManagmentForm";
            Text = "UserManagmentForm";
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
        private Button DeleteRegisterbutton;
    }
}