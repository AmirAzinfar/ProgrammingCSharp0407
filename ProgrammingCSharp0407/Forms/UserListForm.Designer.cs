namespace ProgrammingCSharp0407.Forms
{
    partial class UserJobListForm
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
            UserlistView = new ListView();
            IdColumnHeader = new ColumnHeader();
            FirstLastNameColumnHeader = new ColumnHeader();
            ApplyJobColumnHeader = new ColumnHeader();
            DocUploadColumnHeader = new ColumnHeader();
            CommentColumnHeader = new ColumnHeader();
            label1 = new Label();
            ShowListButton = new Button();
            SuspendLayout();
            // 
            // UserlistView
            // 
            UserlistView.BackColor = Color.Turquoise;
            UserlistView.Columns.AddRange(new ColumnHeader[] { IdColumnHeader, FirstLastNameColumnHeader, ApplyJobColumnHeader, DocUploadColumnHeader, CommentColumnHeader });
            UserlistView.GridLines = true;
            UserlistView.Location = new Point(0, 80);
            UserlistView.Name = "UserlistView";
            UserlistView.Size = new Size(1007, 901);
            UserlistView.TabIndex = 0;
            UserlistView.UseCompatibleStateImageBehavior = false;
            UserlistView.View = View.Details;
            // 
            // IdColumnHeader
            // 
            IdColumnHeader.Text = "Id";
            // 
            // FirstLastNameColumnHeader
            // 
            FirstLastNameColumnHeader.Text = "Name";
            FirstLastNameColumnHeader.TextAlign = HorizontalAlignment.Center;
            FirstLastNameColumnHeader.Width = 155;
            // 
            // ApplyJobColumnHeader
            // 
            ApplyJobColumnHeader.Text = "Applied";
            ApplyJobColumnHeader.TextAlign = HorizontalAlignment.Center;
            ApplyJobColumnHeader.Width = 155;
            // 
            // DocUploadColumnHeader
            // 
            DocUploadColumnHeader.Text = "Documents";
            DocUploadColumnHeader.TextAlign = HorizontalAlignment.Center;
            DocUploadColumnHeader.Width = 200;
            // 
            // CommentColumnHeader
            // 
            CommentColumnHeader.Text = "Comment";
            CommentColumnHeader.TextAlign = HorizontalAlignment.Center;
            CommentColumnHeader.Width = 500;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(374, 19);
            label1.Name = "label1";
            label1.Size = new Size(242, 45);
            label1.TabIndex = 1;
            label1.Text = "لیست متقاضیان ";
            // 
            // ShowListButton
            // 
            ShowListButton.BackColor = Color.Gainsboro;
            ShowListButton.Cursor = Cursors.Hand;
            ShowListButton.FlatAppearance.MouseOverBackColor = Color.Cyan;
            ShowListButton.FlatStyle = FlatStyle.Flat;
            ShowListButton.Location = new Point(12, 18);
            ShowListButton.Name = "ShowListButton";
            ShowListButton.Size = new Size(150, 46);
            ShowListButton.TabIndex = 2;
            ShowListButton.Text = "نمایش";
            ShowListButton.UseVisualStyleBackColor = false;
            
            // 
            // UserJobListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1002, 980);
            Controls.Add(ShowListButton);
            Controls.Add(label1);
            Controls.Add(UserlistView);
            MaximizeBox = false;
            Name = "UserJobListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "متقاضیان";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView UserlistView;
        private ColumnHeader IdColumnHeader;
        private ColumnHeader FirstLastNameColumnHeader;
        private ColumnHeader ApplyJobColumnHeader;
        private ColumnHeader DocUploadColumnHeader;
        private Label label1;
        public ColumnHeader CommentColumnHeader;
        private Button ShowListButton;
    }
}