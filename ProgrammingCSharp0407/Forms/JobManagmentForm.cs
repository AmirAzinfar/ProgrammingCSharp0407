using ProgrammingCSharp0407.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgrammingCSharp0407.Forms
{
    public partial class JobManagmentForm : Form
    {

        List<Job> jobs;
        public JobManagmentForm()
        {
            InitializeComponent();

            string[] FieldOfJoboptionen = { "پزشک و متخصص", "فنی و مهندسی", "معلم", "مربی و دستیار" };
            FieldOfJobComboBox.Items.AddRange(FieldOfJoboptionen);

            string[] JobTiteloptionen = { "دندانپزشک", "مهندس فرایند", "مهندس مکانیک", "مهندس ساختمان", "ریاضی و فیزیک", "پرستار" };
            JobTitelComboBox.Items.AddRange(JobTiteloptionen);

            string[] Provinzoptionen = { "تهران ", "اصفهان", "فارس ", "البرز", "هرمزگان" };
            ProvinzComboBox.Items.AddRange(Provinzoptionen);

            string[] Cityoptionen = { "تهران ", "اصفهان", "شیراز", "فسا", "کرج", "بندرعباس" };
            CityComboBox.Items.AddRange(Cityoptionen);

            jobs = new List<Job>();
        }


        private void RegisterApplybutton_Click(object sender, EventArgs e)
        {
            //data collect
            string fieldOfJob = FieldOfJobComboBox.Text;
            string titelOfJob = JobTitelComboBox.Text;
            string provinzWorkPlace = ProvinzComboBox.Text;
            string cityWorkplace = CityComboBox.Text;
            string salaryJob = SalaryTextBox.Text;

            Job job = new Job();
            job.FieldOfJob = fieldOfJob;
            job.TitelOfJob = titelOfJob;
            job.ProvinzWorkplace = provinzWorkPlace;
            job.CityWorkplace = cityWorkplace;
            job.Salary= salaryJob;

            //List<Job> jobs = new List<Job>();
            jobs.Add(job);

            //JobAppliedDataGridView.DataSource = jobs;

            //DataGridView can not reload "refresh", beacuse of that we will read it as folow: 
            JobAppliedDataGridView.DataSource = null;
            JobAppliedDataGridView.DataSource= jobs;
            JobAppliedDataGridView:Refresh();

        }
    }
}
