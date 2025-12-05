namespace ProgrammingCSharp0407.Forms
{
    partial class UserAdressForm
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
            StreetTextBox = new TextBox();
            HousNumberTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PostalCodeTextBox = new TextBox();
            RegistAdressButton = new Button();
            CloseAdressButton = new Button();
            DeleteAdressInfoButton = new Button();
            AdressDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AdressDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(668, 44);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 0;
            label1.Text = ":خیابان";
            // 
            // StreetTextBox
            // 
            StreetTextBox.BackColor = Color.LightSteelBlue;
            StreetTextBox.Location = new Point(264, 41);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(398, 39);
            StreetTextBox.TabIndex = 1;
            // 
            // HousNumberTextBox
            // 
            HousNumberTextBox.BackColor = Color.LightSteelBlue;
            HousNumberTextBox.Location = new Point(27, 41);
            HousNumberTextBox.Name = "HousNumberTextBox";
            HousNumberTextBox.Size = new Size(162, 39);
            HousNumberTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(195, 44);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 2;
            label2.Text = ":پلاک ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(668, 101);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 2;
            label3.Text = ":کد پستی  ";
            // 
            // PostalCodeTextBox
            // 
            PostalCodeTextBox.BackColor = Color.LightSteelBlue;
            PostalCodeTextBox.Location = new Point(264, 98);
            PostalCodeTextBox.Name = "PostalCodeTextBox";
            PostalCodeTextBox.Size = new Size(398, 39);
            PostalCodeTextBox.TabIndex = 3;
            // 
            // RegistAdressButton
            // 
            RegistAdressButton.BackColor = Color.FromArgb(224, 224, 224);
            RegistAdressButton.Cursor = Cursors.Hand;
            RegistAdressButton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            RegistAdressButton.FlatStyle = FlatStyle.Flat;
            RegistAdressButton.Location = new Point(140, 190);
            RegistAdressButton.Name = "RegistAdressButton";
            RegistAdressButton.Size = new Size(168, 59);
            RegistAdressButton.TabIndex = 6;
            RegistAdressButton.Text = "ثبت آدرس";
            RegistAdressButton.UseVisualStyleBackColor = false;
            RegistAdressButton.Click += RegistAdressButton_Click;
            // 
            // CloseAdressButton
            // 
            CloseAdressButton.BackColor = Color.FromArgb(224, 224, 224);
            CloseAdressButton.Cursor = Cursors.Hand;
            CloseAdressButton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            CloseAdressButton.FlatStyle = FlatStyle.Flat;
            CloseAdressButton.Location = new Point(314, 190);
            CloseAdressButton.Name = "CloseAdressButton";
            CloseAdressButton.Size = new Size(168, 59);
            CloseAdressButton.TabIndex = 5;
            CloseAdressButton.Text = "بستن صفحه";
            CloseAdressButton.UseVisualStyleBackColor = false;
            CloseAdressButton.Click += CloseAdressButton_Click;
            // 
            // DeleteAdressInfoButton
            // 
            DeleteAdressInfoButton.BackColor = Color.FromArgb(224, 224, 224);
            DeleteAdressInfoButton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            DeleteAdressInfoButton.FlatStyle = FlatStyle.Flat;
            DeleteAdressInfoButton.Location = new Point(488, 190);
            DeleteAdressInfoButton.Name = "DeleteAdressInfoButton";
            DeleteAdressInfoButton.Size = new Size(168, 59);
            DeleteAdressInfoButton.TabIndex = 4;
            DeleteAdressInfoButton.Text = "حذف اطلاعات";
            DeleteAdressInfoButton.UseVisualStyleBackColor = false;
            DeleteAdressInfoButton.Click += DeleteAdressInfoButton_Click;
            // 
            // AdressDataGridView
            // 
            AdressDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            AdressDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdressDataGridView.Location = new Point(27, 298);
            AdressDataGridView.Name = "AdressDataGridView";
            AdressDataGridView.RowHeadersWidth = 82;
            AdressDataGridView.Size = new Size(749, 465);
            AdressDataGridView.TabIndex = 7;
            // 
            // UserAdressForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(805, 791);
            Controls.Add(AdressDataGridView);
            Controls.Add(DeleteAdressInfoButton);
            Controls.Add(CloseAdressButton);
            Controls.Add(RegistAdressButton);
            Controls.Add(PostalCodeTextBox);
            Controls.Add(label3);
            Controls.Add(HousNumberTextBox);
            Controls.Add(label2);
            Controls.Add(StreetTextBox);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "UserAdressForm";
            Text = "آدرس";
            ((System.ComponentModel.ISupportInitialize)AdressDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox StreetTextBox;
        private TextBox HousNumberTextBox;
        private Label label2;
        private Label label3;
        private TextBox PostalCodeTextBox;
        private Button RegistAdressButton;
        private Button CloseAdressButton;
        private Button DeleteAdressInfoButton;
        private DataGridView AdressDataGridView;
    }
}