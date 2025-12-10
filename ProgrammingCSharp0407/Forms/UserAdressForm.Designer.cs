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
            HouseNumberTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PostalCodeTextBox = new TextBox();
            RegistAdressButton = new Button();
            CloseAdressButton = new Button();
            EditAdressInfoButton = new Button();
            AdressDataGridView = new DataGridView();
            UpdateAdressButton = new Button();
            DeleteAdressButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AdressDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(649, 44);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 0;
            label1.Text = ":خیابان";
            // 
            // StreetTextBox
            // 
            StreetTextBox.BackColor = Color.LightSteelBlue;
            StreetTextBox.Location = new Point(245, 41);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(398, 39);
            StreetTextBox.TabIndex = 1;
            // 
            // HouseNumberTextBox
            // 
            HouseNumberTextBox.BackColor = Color.LightSteelBlue;
            HouseNumberTextBox.Location = new Point(33, 41);
            HouseNumberTextBox.Name = "HouseNumberTextBox";
            HouseNumberTextBox.Size = new Size(137, 39);
            HouseNumberTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(176, 44);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 2;
            label2.Text = ":پلاک ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(649, 101);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 2;
            label3.Text = ":کد پستی  ";
            // 
            // PostalCodeTextBox
            // 
            PostalCodeTextBox.BackColor = Color.LightSteelBlue;
            PostalCodeTextBox.Location = new Point(245, 98);
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
            RegistAdressButton.Location = new Point(353, 160);
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
            CloseAdressButton.Location = new Point(36, 253);
            CloseAdressButton.Name = "CloseAdressButton";
            CloseAdressButton.Size = new Size(168, 59);
            CloseAdressButton.TabIndex = 5;
            CloseAdressButton.Text = "بستن صفحه";
            CloseAdressButton.UseVisualStyleBackColor = false;
            CloseAdressButton.Click += CloseAdressButton_Click;
            // 
            // EditAdressInfoButton
            // 
            EditAdressInfoButton.BackColor = Color.FromArgb(224, 224, 224);
            EditAdressInfoButton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            EditAdressInfoButton.FlatStyle = FlatStyle.Flat;
            EditAdressInfoButton.Location = new Point(558, 253);
            EditAdressInfoButton.Name = "EditAdressInfoButton";
            EditAdressInfoButton.Size = new Size(168, 59);
            EditAdressInfoButton.TabIndex = 4;
            EditAdressInfoButton.Text = " تنظیم مجدد ";
            EditAdressInfoButton.UseVisualStyleBackColor = false;
            EditAdressInfoButton.Click += EditAdressInfoButton_Click;
            // 
            // AdressDataGridView
            // 
            AdressDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            AdressDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdressDataGridView.Location = new Point(33, 318);
            AdressDataGridView.Name = "AdressDataGridView";
            AdressDataGridView.RowHeadersWidth = 82;
            AdressDataGridView.Size = new Size(693, 574);
            AdressDataGridView.TabIndex = 7;
            AdressDataGridView.CellClick += AdressDataGridView_CellClick;
            // 
            // UpdateAdressButton
            // 
            UpdateAdressButton.BackColor = Color.FromArgb(224, 224, 224);
            UpdateAdressButton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            UpdateAdressButton.FlatStyle = FlatStyle.Flat;
            UpdateAdressButton.Location = new Point(210, 253);
            UpdateAdressButton.Name = "UpdateAdressButton";
            UpdateAdressButton.Size = new Size(168, 59);
            UpdateAdressButton.TabIndex = 8;
            UpdateAdressButton.Text = "به روز رسانی";
            UpdateAdressButton.UseVisualStyleBackColor = false;
            UpdateAdressButton.Click += UpdateAdressButton_Click;
            // 
            // DeleteAdressButton
            // 
            DeleteAdressButton.BackColor = Color.FromArgb(224, 224, 224);
            DeleteAdressButton.FlatAppearance.MouseOverBackColor = Color.Aquamarine;
            DeleteAdressButton.FlatStyle = FlatStyle.Flat;
            DeleteAdressButton.Location = new Point(384, 253);
            DeleteAdressButton.Name = "DeleteAdressButton";
            DeleteAdressButton.Size = new Size(168, 59);
            DeleteAdressButton.TabIndex = 9;
            DeleteAdressButton.Text = "حذف آدرس";
            DeleteAdressButton.UseVisualStyleBackColor = false;
            DeleteAdressButton.Click += DeleteAdressButton_Click;
            // 
            // UserAdressForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(770, 923);
            Controls.Add(DeleteAdressButton);
            Controls.Add(UpdateAdressButton);
            Controls.Add(AdressDataGridView);
            Controls.Add(EditAdressInfoButton);
            Controls.Add(CloseAdressButton);
            Controls.Add(RegistAdressButton);
            Controls.Add(PostalCodeTextBox);
            Controls.Add(label3);
            Controls.Add(HouseNumberTextBox);
            Controls.Add(label2);
            Controls.Add(StreetTextBox);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "UserAdressForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "آدرس";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)AdressDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox StreetTextBox;
        private TextBox HouseNumberTextBox;
        private Label label2;
        private Label label3;
        private TextBox PostalCodeTextBox;
        private Button RegistAdressButton;
        private Button CloseAdressButton;
        private Button EditAdressInfoButton;
        private DataGridView AdressDataGridView;
        private Button UpdateAdressButton;
        private Button DeleteAdressButton;
    }
}