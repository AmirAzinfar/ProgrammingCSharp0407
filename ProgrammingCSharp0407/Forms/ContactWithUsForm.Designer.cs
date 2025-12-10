namespace ProgrammingCSharp0407.Forms
{
    partial class ContactWithUsForm
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
            TextContacTextBox = new TextBox();
            SendContactButton = new Button();
            DeleteContactButton = new Button();
            ExitContactButton = new Button();
            FirstNameContactTextBox = new TextBox();
            LastNameContactTextBox = new TextBox();
            SubjectContactTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(522, 48);
            label1.Name = "label1";
            label1.Size = new Size(56, 32);
            label1.TabIndex = 0;
            label1.Text = ":نام ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(432, 112);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 1;
            label2.Text = ":نام خانوادگی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(481, 179);
            label3.Name = "label3";
            label3.Size = new Size(97, 32);
            label3.TabIndex = 2;
            label3.Text = ":موضوع";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(204, 253);
            label4.Name = "label4";
            label4.Size = new Size(374, 32);
            label4.TabIndex = 3;
            label4.Text = ":متن خود را در قسمت پایین وارد کنید";
            // 
            // TextContacTextBox
            // 
            TextContacTextBox.BackColor = Color.WhiteSmoke;
            TextContacTextBox.ForeColor = Color.Black;
            TextContacTextBox.Location = new Point(54, 298);
            TextContacTextBox.Multiline = true;
            TextContacTextBox.Name = "TextContacTextBox";
            TextContacTextBox.ScrollBars = ScrollBars.Both;
            TextContacTextBox.Size = new Size(522, 331);
            TextContacTextBox.TabIndex = 4;
            // 
            // SendContactButton
            // 
            SendContactButton.Cursor = Cursors.Hand;
            SendContactButton.FlatAppearance.MouseOverBackColor = Color.Cyan;
            SendContactButton.FlatStyle = FlatStyle.Flat;
            SendContactButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendContactButton.ForeColor = Color.Black;
            SendContactButton.Location = new Point(415, 658);
            SendContactButton.Name = "SendContactButton";
            SendContactButton.Size = new Size(161, 62);
            SendContactButton.TabIndex = 5;
            SendContactButton.Text = "ارسال متن";
            SendContactButton.UseVisualStyleBackColor = true;
            SendContactButton.Click += SendContactButton_Click;
            // 
            // DeleteContactButton
            // 
            DeleteContactButton.Cursor = Cursors.Hand;
            DeleteContactButton.FlatAppearance.MouseOverBackColor = Color.Cyan;
            DeleteContactButton.FlatStyle = FlatStyle.Flat;
            DeleteContactButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteContactButton.Location = new Point(234, 658);
            DeleteContactButton.Name = "DeleteContactButton";
            DeleteContactButton.Size = new Size(161, 62);
            DeleteContactButton.TabIndex = 6;
            DeleteContactButton.Text = "حذف ";
            DeleteContactButton.UseVisualStyleBackColor = true;
            // 
            // ExitContactButton
            // 
            ExitContactButton.Cursor = Cursors.Hand;
            ExitContactButton.FlatAppearance.MouseOverBackColor = Color.Cyan;
            ExitContactButton.FlatStyle = FlatStyle.Flat;
            ExitContactButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitContactButton.Location = new Point(54, 658);
            ExitContactButton.Name = "ExitContactButton";
            ExitContactButton.Size = new Size(161, 66);
            ExitContactButton.TabIndex = 7;
            ExitContactButton.Text = "بستن صفحه";
            ExitContactButton.UseVisualStyleBackColor = true;
            ExitContactButton.Click += ExitContactButton_Click;
            // 
            // FirstNameContactTextBox
            // 
            FirstNameContactTextBox.BackColor = Color.White;
            FirstNameContactTextBox.ForeColor = Color.Black;
            FirstNameContactTextBox.Location = new Point(54, 48);
            FirstNameContactTextBox.Name = "FirstNameContactTextBox";
            FirstNameContactTextBox.Size = new Size(365, 39);
            FirstNameContactTextBox.TabIndex = 8;
            // 
            // LastNameContactTextBox
            // 
            LastNameContactTextBox.BackColor = Color.White;
            LastNameContactTextBox.ForeColor = Color.Black;
            LastNameContactTextBox.Location = new Point(54, 112);
            LastNameContactTextBox.Name = "LastNameContactTextBox";
            LastNameContactTextBox.Size = new Size(365, 39);
            LastNameContactTextBox.TabIndex = 9;
            // 
            // SubjectContactTextBox
            // 
            SubjectContactTextBox.BackColor = Color.White;
            SubjectContactTextBox.ForeColor = Color.Black;
            SubjectContactTextBox.Location = new Point(54, 176);
            SubjectContactTextBox.Name = "SubjectContactTextBox";
            SubjectContactTextBox.Size = new Size(365, 39);
            SubjectContactTextBox.TabIndex = 10;
            // 
            // ContactWithUsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(633, 759);
            Controls.Add(SubjectContactTextBox);
            Controls.Add(LastNameContactTextBox);
            Controls.Add(FirstNameContactTextBox);
            Controls.Add(ExitContactButton);
            Controls.Add(DeleteContactButton);
            Controls.Add(SendContactButton);
            Controls.Add(TextContacTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ContactWithUsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تماس با ما";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TextContacTextBox;
        private Button SendContactButton;
        private Button DeleteContactButton;
        private Button ExitContactButton;
        private TextBox FirstNameContactTextBox;
        private TextBox LastNameContactTextBox;
        private TextBox SubjectContactTextBox;
    }
}