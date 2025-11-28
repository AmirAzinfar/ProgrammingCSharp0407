using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgrammingCSharp0407.Forms
{
    public partial class User_Panel : Form
    {
        public User_Panel()
        {
            InitializeComponent();
        }

        private void User_Panel_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            FormRegistToolStripMenuItem = new ToolStripMenuItem();
            ApplyJobToolStripMenuItem = new ToolStripMenuItem();
            FullFormToolStripMenuItem = new ToolStripMenuItem();
            managmentToolStripMenuItem = new ToolStripMenuItem();
            ApplierJobToolStripMenuItem = new ToolStripMenuItem();
            اSubmitFormToolStripMenuItem = new ToolStripMenuItem();
            StatusApplyToolStripMenuItem = new ToolStripMenuItem();
            ContactToolStripMenuItem = new ToolStripMenuItem();
            HelpToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, ApplyJobToolStripMenuItem, managmentToolStripMenuItem, ContactToolStripMenuItem, HelpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(827, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FormRegistToolStripMenuItem });
            userToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(90, 36);
            userToolStripMenuItem.Text = "فرم‌ها";
            // 
            // FormRegistToolStripMenuItem
            // 
            FormRegistToolStripMenuItem.BackColor = Color.LightSkyBlue;
            FormRegistToolStripMenuItem.Name = "FormRegistToolStripMenuItem";
            FormRegistToolStripMenuItem.Size = new Size(359, 44);
            FormRegistToolStripMenuItem.Text = "فرم ثبت نام";
            FormRegistToolStripMenuItem.Click += FormRegistToolStripMenuItem_Click;
            // 
            // ApplyJobToolStripMenuItem
            // 
            ApplyJobToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FullFormToolStripMenuItem });
            ApplyJobToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            ApplyJobToolStripMenuItem.Name = "ApplyJobToolStripMenuItem";
            ApplyJobToolStripMenuItem.Size = new Size(206, 36);
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
            // managmentToolStripMenuItem
            // 
            managmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ApplierJobToolStripMenuItem, اSubmitFormToolStripMenuItem, StatusApplyToolStripMenuItem });
            managmentToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            managmentToolStripMenuItem.Name = "managmentToolStripMenuItem";
            managmentToolStripMenuItem.Size = new Size(110, 36);
            managmentToolStripMenuItem.Text = "مدیریت";
            // 
            // ApplierJobToolStripMenuItem
            // 
            ApplierJobToolStripMenuItem.BackColor = Color.LightSkyBlue;
            ApplierJobToolStripMenuItem.Name = "ApplierJobToolStripMenuItem";
            ApplierJobToolStripMenuItem.Size = new Size(359, 44);
            ApplierJobToolStripMenuItem.Text = "متقاضیان";
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
            // ContactToolStripMenuItem
            // 
            ContactToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            ContactToolStripMenuItem.Name = "ContactToolStripMenuItem";
            ContactToolStripMenuItem.Size = new Size(145, 36);
            ContactToolStripMenuItem.Text = "تماس با ما ";
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size = new Size(92, 36);
            HelpToolStripMenuItem.Text = "راهنما";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Test;
            pictureBox1.Location = new Point(-2, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(829, 733);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // User_Panel
            // 
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(827, 767);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            MainMenuStrip = menuStrip1;
            Name = "User_Panel";
            Text = "پنل کاربری ";
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
    }
}
