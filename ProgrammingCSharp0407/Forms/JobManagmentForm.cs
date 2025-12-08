using ProgrammingInCshrpBaseBackend.Models;
using ProgrammingInCshrpBaseBackend.Services;

namespace ProgrammingCSharp0407.Forms;

public partial class JobManagmentForm : Form
{
    int SelectedJobId = 0;
    JobService jobService;
    public JobManagmentForm()
    {
        InitializeComponent();

        jobService = new JobService();
        JobAppliedDataGridView.DataSource = jobService.GetAll();
    JobAppliedDataGridView: Refresh();
        FullTimeRadioButton.Checked = true;

        jobService = new JobService();

        string[] FieldOfJoboptionen = { "پزشک و متخصص", "فنی و مهندسی", "معلم", "مربی و دستیار" };
        FieldOfJobComboBox.Items.AddRange(FieldOfJoboptionen);

        string[] JobTiteloptionen = { "دندانپزشک", "مهندس فرایند", "مهندس مکانیک", "مهندس ساختمان", "ریاضی و فیزیک", "پرستار" };
        JobTitelComboBox.Items.AddRange(JobTiteloptionen);

        string[] Provinceoptionen = { "تهران ", "اصفهان", "فارس ", "البرز", "هرمزگان" };
        ProvinceComboBox.Items.AddRange(Provinceoptionen);

        string[] Cityoptionen = { "تهران ", "اصفهان", "شیراز", "فسا", "کرج", "بندرعباس" };
        CityComboBox.Items.AddRange(Cityoptionen);

        //jobs = new List<Job>();
    }

    private void RegisterApplybutton_Click(object sender, EventArgs e)
    {
        //data collect
        string fieldOfJob = FieldOfJobComboBox.Text;
        string titelOfJob = JobTitelComboBox.Text;
        string provinceWorkplace = ProvinceComboBox.Text;
        string cityWorkplace = CityComboBox.Text;
        string salary = SalaryTextBox.Text;
        string timeWorkingHours;
        DateTime dateOfStart;
        string choiceStart;


        Job job = new Job(fieldOfJob: fieldOfJob, titelOfJob: titelOfJob, salary: salary, provinceWorkplace: provinceWorkplace, cityWorkplace: cityWorkplace);


        // definition TimeWorkingHours
        if (FullTimeRadioButton.Checked)
        {
            job.TimeWorkingHours = "تمام وقت";
        }
        else if (HalfTimeRadioButton.Checked)
        {
            job.TimeWorkingHours = "نیمه وقت";
        }
        else if (BothRadioButton.Checked)
        {
            job.TimeWorkingHours = "نیمه/تمام وقت";
        }
        else
        {
            MessageBox.Show(".لطفا ساعت کاری دلخواه خود را انتخاب نمایید");
        }

        // defintion DateTimePicker
        if (EnteranceDateTimePicker.Checked)
        {
            job.DateOfStart = EnteranceDateTimePicker.Value;
        }
        else job.DateOfStart = null;

        //defintion list of and differnt state for CheckBoxes
        List<string> Choices = new List<string>();
        if (ImmediatelyCheckBox.Checked)
        {
            Choices.Add("فورا");
        }
        if (WithAgreeCheckBox.Checked)
        {
            Choices.Add("توافقی");
        }
        else if (!ImmediatelyCheckBox.Checked && !WithAgreeCheckBox.Checked)
        {
            Choices.Add("/");
        }

        job.ChoiceStart = string.Join(",", Choices);


        jobService.Add(job);

        JobAppliedDataGridView.DataSource = null;
        JobAppliedDataGridView.DataSource = jobService.GetAll();
        JobAppliedDataGridView: Refresh();

        MessageBox.Show(".درخواست شغلی شما با موفقیت ثبت شد");

    }

    private void CancelApplaybutton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void JobAppliedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            //Get the current row
            var row = JobAppliedDataGridView.Rows[e.RowIndex];
            //Access the Id from rows data
            SelectedJobId = int.Parse(row.Cells["id"].Value.ToString());

            FieldOfJobComboBox.Text = row.Cells["FieldOfJob"].Value?.ToString();
            JobTitelComboBox.Text = row.Cells["TitelOfJob"].Value?.ToString();
            SalaryTextBox.Text = row.Cells["Salary"].Value?.ToString();
            ProvinceComboBox.Text = row.Cells["ProvinceWorkplace"].Value?.ToString();
            CityComboBox.Text = row.Cells["CityWorkplace"].Value?.ToString();

            if (row.Cells["TimeWorkingHours"].Value.ToString() == "تمام وقت")
            {
                FullTimeRadioButton.Checked = true;
            }
            else if (row.Cells["TimeWorkingHours"].Value.ToString() == "نیمه وقت")
            {
                HalfTimeRadioButton.Checked = true;
            }
            else if (row.Cells["TimeWorkingHours"].Value.ToString() == "نیمه/تمام وقت")
            {
                BothRadioButton.Checked = true;
            }

            //forDataTimePicker
            if (row.Cells["dateOfStart"].Value is DateTime dateTime)
            {
                EnteranceDateTimePicker.Value = dateTime;
                EnteranceDateTimePicker.Checked = true;
            }
            else
            {
                EnteranceDateTimePicker.Checked = false;
            }
              
            //for CheckBoxes

            if (row.Cells["ChoiceStart"].Value.ToString() == "فورا")
            {
                ImmediatelyCheckBox.Checked = true;
            }
            else if (row.Cells["ChoiceStart"].Value.ToString() == "توافقی")
            {
                WithAgreeCheckBox.Checked = true;
            }
            else if (row.Cells["ChoiceStart"].Value.ToString() == "فورا,توافقی")
            {
                WithAgreeCheckBox.Checked = true;
                ImmediatelyCheckBox.Checked = true;
            }
            else
            {
                WithAgreeCheckBox.Checked = false;
                ImmediatelyCheckBox.Checked = false;
            }
            
        }
    }
    private void DeleteJobButton_Click(object sender, EventArgs e)
    {
        if (SelectedJobId == 0)
        {
            MessageBox.Show("!لطفا در ابتدا شغل مورد نظر را انتخاب کنید");
            return;
        }
        jobService.Delete(SelectedJobId);
        JobAppliedDataGridView.DataSource = jobService.GetAll();
        JobAppliedDataGridView.Refresh();

        MessageBox.Show(".لغو درخواست با موفقیت انجام شد");
    }

    private void UpdateJobButton_Click(object sender, EventArgs e)
    {
        string fieldOfJob = FieldOfJobComboBox.Text;
        string titelOfJob = JobTitelComboBox.Text;
        string provinceWorkplace = ProvinceComboBox.Text;
        string cityWorkplace = CityComboBox.Text;
        string salary = SalaryTextBox.Text;
        string timeWorkingHours;
        DateTime dateOfStart;
        string choiceStart;


        Job job = new Job
        {
            Id = SelectedJobId,
            FieldOfJob = fieldOfJob,
            TitelOfJob = titelOfJob,
            Salary = salary,
            ProvinceWorkplace = provinceWorkplace,
            CityWorkplace = cityWorkplace,
        };


        // definition TimeWorkingHours
        if (FullTimeRadioButton.Checked)
        {
            job.TimeWorkingHours = "تمام وقت";
        }
        else if (HalfTimeRadioButton.Checked)
        {
            job.TimeWorkingHours = "نیمه وقت";
        }
        else if (BothRadioButton.Checked)
        {
            job.TimeWorkingHours = "نیمه/تمام وقت";
        }
        else
        {
            MessageBox.Show(".لطفا ساعت کاری دلخواه خود را انتخاب نمایید");
        }

        // defintion DateTimePicker
        if (EnteranceDateTimePicker.Checked)
        {
            job.DateOfStart = EnteranceDateTimePicker.Value;
        }
        else job.DateOfStart = null;

        //defintion list of and differnt state for CheckBoxes
        List<string> Choices = new List<string>();
        if (ImmediatelyCheckBox.Checked)
        {
            Choices.Add("فورا");
        }
        if (WithAgreeCheckBox.Checked)
        {
            Choices.Add("توافقی");
        }
        else if (!ImmediatelyCheckBox.Checked && !WithAgreeCheckBox.Checked)
        {
            Choices.Add("/");
        }

        job.ChoiceStart = string.Join(",", Choices);


        jobService.Update(job);

        JobAppliedDataGridView.DataSource = null;
        JobAppliedDataGridView.DataSource = jobService.GetAll();
        JobAppliedDataGridView: Refresh();

        MessageBox.Show(".به روز رسانی با موفقیت انجام شد");
    }

    
}
