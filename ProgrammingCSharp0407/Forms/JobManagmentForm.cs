using ProgrammingInCshrpBaseBackend.Models;
using ProgrammingInCshrpBaseBackend.Services;

namespace ProgrammingCSharp0407.Forms;

public partial class JobManagmentForm : Form
{

    //List<Job> jobs;
    JobService jobService;
    public JobManagmentForm()
    {
        InitializeComponent();

        //jobService = new JobService();
        //JobAppliedDataGridView.DataSource = jobService.GetAll();
        //JobAppliedDataGridView: Refresh();

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

        //List<Job> jobs = new List<Job>();
        jobService.Add(job);

        //JobAppliedDataGridView.DataSource = jobs;

        //DataGridView can not reload "refresh", beacuse of that we will read it as folow: 
        JobAppliedDataGridView.DataSource = null;
        JobAppliedDataGridView.DataSource = jobService.GetAll();
        JobAppliedDataGridView: Refresh();

        MessageBox.Show(".درخواست شغلی شما با موفقیت ثبت شد");

    }

    private void CancelApplaybutton_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
