
using System.ComponentModel;


namespace ProgrammingCSharp0407.Forms
{
    public partial class UserPanelForm : Form
    {
        public UserPanelForm()
        {
            InitializeComponent();
        }

        private void UserPanelForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem = new ToolStripMenuItem();
            AdminChangeToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            FormRegistToolStripMenuItem = new ToolStripMenuItem();
            ApplyJobToolStripMenuItem = new ToolStripMenuItem();
            FullFormToolStripMenuItem = new ToolStripMenuItem();
            UploadDocsToolStripMenuItem = new ToolStripMenuItem();
            managmentToolStripMenuItem = new ToolStripMenuItem();
            ApplierJobToolStripMenuItem = new ToolStripMenuItem();
            اSubmitFormToolStripMenuItem = new ToolStripMenuItem();
            StatusApplyToolStripMenuItem = new ToolStripMenuItem();
            InviteToolStripMenuItem = new ToolStripMenuItem();
            ContactToolStripMenuItem = new ToolStripMenuItem();
            HelpToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem, userToolStripMenuItem, ApplyJobToolStripMenuItem, managmentToolStripMenuItem, ContactToolStripMenuItem, HelpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(874, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AdminChangeToolStripMenuItem, ExitToolStripMenuItem });
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(121, 38);
            ToolStripMenuItem.Text = "تنظیم ها";
            // 
            // AdminChangeToolStripMenuItem
            // 
            AdminChangeToolStripMenuItem.BackColor = Color.LightSkyBlue;
            AdminChangeToolStripMenuItem.Name = "AdminChangeToolStripMenuItem";
            AdminChangeToolStripMenuItem.Size = new Size(290, 44);
            AdminChangeToolStripMenuItem.Text = "تغییر ادمین";
            AdminChangeToolStripMenuItem.Click += AdminChangeToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(290, 44);
            ExitToolStripMenuItem.Text = "خروج از برنامه ";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FormRegistToolStripMenuItem });
            userToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(90, 38);
            userToolStripMenuItem.Text = "فرم‌ها";
            // 
            // FormRegistToolStripMenuItem
            // 
            FormRegistToolStripMenuItem.BackColor = Color.LightSkyBlue;
            FormRegistToolStripMenuItem.Name = "FormRegistToolStripMenuItem";
            FormRegistToolStripMenuItem.Size = new Size(261, 44);
            FormRegistToolStripMenuItem.Text = "فرم ثبت نام";
            FormRegistToolStripMenuItem.Click += FormRegistToolStripMenuItem_Click;
            // 
            // ApplyJobToolStripMenuItem
            // 
            ApplyJobToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FullFormToolStripMenuItem, UploadDocsToolStripMenuItem });
            ApplyJobToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            ApplyJobToolStripMenuItem.Name = "ApplyJobToolStripMenuItem";
            ApplyJobToolStripMenuItem.Size = new Size(206, 38);
            ApplyJobToolStripMenuItem.Text = "درخواست شغلی ";
            // 
            // FullFormToolStripMenuItem
            // 
            FullFormToolStripMenuItem.BackColor = Color.LightSkyBlue;
            FullFormToolStripMenuItem.Name = "FullFormToolStripMenuItem";
            FullFormToolStripMenuItem.Size = new Size(359, 44);
            FullFormToolStripMenuItem.Text = "تکمیل فرم ";
            FullFormToolStripMenuItem.Click += FullFormToolStripMenuItem_Click;
            // 
            // UploadDocsToolStripMenuItem
            // 
            UploadDocsToolStripMenuItem.BackColor = Color.PaleTurquoise;
            UploadDocsToolStripMenuItem.Name = "UploadDocsToolStripMenuItem";
            UploadDocsToolStripMenuItem.Size = new Size(359, 44);
            UploadDocsToolStripMenuItem.Text = "بارگذاری مدارک";
            UploadDocsToolStripMenuItem.Click += UploadDocsToolStripMenuItem_Click;
            // 
            // managmentToolStripMenuItem
            // 
            managmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ApplierJobToolStripMenuItem, اSubmitFormToolStripMenuItem, StatusApplyToolStripMenuItem, InviteToolStripMenuItem });
            managmentToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            managmentToolStripMenuItem.Name = "managmentToolStripMenuItem";
            managmentToolStripMenuItem.Size = new Size(110, 38);
            managmentToolStripMenuItem.Text = "مدیریت";
            // 
            // ApplierJobToolStripMenuItem
            // 
            ApplierJobToolStripMenuItem.BackColor = Color.LightSkyBlue;
            ApplierJobToolStripMenuItem.Name = "ApplierJobToolStripMenuItem";
            ApplierJobToolStripMenuItem.Size = new Size(359, 44);
            ApplierJobToolStripMenuItem.Text = "متقاضیان";
            ApplierJobToolStripMenuItem.Click += ApplierJobToolStripMenuItem_Click;
            // 
            // اSubmitFormToolStripMenuItem
            // 
            اSubmitFormToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            اSubmitFormToolStripMenuItem.Name = "اSubmitFormToolStripMenuItem";
            اSubmitFormToolStripMenuItem.Size = new Size(359, 44);
            اSubmitFormToolStripMenuItem.Text = "ارسال درخواست ";
            // 
            // StatusApplyToolStripMenuItem
            // 
            StatusApplyToolStripMenuItem.BackColor = Color.SkyBlue;
            StatusApplyToolStripMenuItem.Name = "StatusApplyToolStripMenuItem";
            StatusApplyToolStripMenuItem.Size = new Size(359, 44);
            StatusApplyToolStripMenuItem.Text = "وضعیت درخواست";
            // 
            // InviteToolStripMenuItem
            // 
            InviteToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            InviteToolStripMenuItem.Name = "InviteToolStripMenuItem";
            InviteToolStripMenuItem.Size = new Size(359, 44);
            InviteToolStripMenuItem.Text = "دعوت به مصاحبه";
            // 
            // ContactToolStripMenuItem
            // 
            ContactToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            ContactToolStripMenuItem.Name = "ContactToolStripMenuItem";
            ContactToolStripMenuItem.Size = new Size(145, 38);
            ContactToolStripMenuItem.Text = "تماس با ما ";
            ContactToolStripMenuItem.Click += ContactToolStripMenuItem_Click;
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size = new Size(92, 38);
            HelpToolStripMenuItem.Text = "راهنما";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Background;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(874, 714);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // UserPanelForm
            // 
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(874, 714);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            MainMenuStrip = menuStrip1;
            Name = "UserPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پنل کاربری ";
            TopMost = true;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void FormRegistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagmentForm userManagmentForm = new UserManagmentForm();
            userManagmentForm.ShowDialog();
        }

        private void FullFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobManagmentForm jobManagmentForm1 = new JobManagmentForm();
            jobManagmentForm1.ShowDialog();
        }

        private void UploadDocsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadDocsForm uploadDocsForm1 = new UploadDocsForm();
            uploadDocsForm1.ShowDialog();
        }
        private void AdminChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactWithUsForm contactForm = new ContactWithUsForm();
            contactForm.ShowDialog();
        }

        private void ApplierJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserJobListForm userJobListForm = new UserJobListForm();
            userJobListForm.ShowDialog();
        }
    }
}
