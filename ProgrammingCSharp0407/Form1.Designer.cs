namespace ProgrammingCSharp0407
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 141);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 0;
            label1.Text = "نام کاربری:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(37, 205);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 1;
            label2.Text = "رمز عبور:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(162, 141);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(250, 39);
            UserNameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(162, 205);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(250, 39);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSlateGray;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(162, 279);
            button1.Name = "button1";
            button1.Size = new Size(250, 68);
            button1.TabIndex = 4;
            button1.Text = "ورود";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(483, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(457, 435);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(103, 23);
            label3.Name = "label3";
            label3.Size = new Size(374, 66);
            label3.TabIndex = 6;
            label3.Text = "شرکت توسعه نیرو";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(929, 421);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ورود به صفحه ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
