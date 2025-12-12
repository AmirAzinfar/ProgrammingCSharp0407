using ProgrammingInCshrpBaseBackend.Models;
using ProgrammingInCshrpBaseBackend.Services;

namespace ProgrammingCSharp0407.Forms;

public partial class JobManagmentForm : Form
{
    int SelectedJobId = 0;
    JobService jobService;

    public delegate void ReloadJobManagmentForm();
    public event ReloadJobManagmentForm ReloadJobManagmentEvent;
    public JobManagmentForm()
    {
        InitializeComponent();

        jobService = new JobService();
        ReloadJobManagmentEvent += RefreshJobManagmentForm;
        ReloadJobManagmentEvent.Invoke();

        FullTimeRadioButton.Checked = true;

        jobService = new JobService();

        string[] FieldOfJoboptionen = { "همه شغل ها", "پزشک و متخصص", "فنی و مهندسی", "معلم", "هنرمند" };
        FieldOfJobComboBox.Items.AddRange(FieldOfJoboptionen);

        string[] JobTiteloptionen = {"دندانپزشک","رادیولوژیست","چشم پزشک", "مهندس فرایند", "مهندس مکانیک", "مهندس ساختمان",
                                    "ریاضی و فیزیک","زبان انگلیسی","پرستار","نوازنده پیانو","نوازنده دف" };
        JobTitelComboBox.Items.AddRange(JobTiteloptionen);

        string[] Provinceoptionen = {"همه استان ها", "خراسان", "تهران", "اصفهان", "فارس", "البرز", "هرمزگان" };
        ProvinceComboBox.Items.AddRange(Provinceoptionen);

        string[] Cityoptionen = {"مشهد", "تهران", "قم", "نجف آباد", "اصفهان", "شیراز", "فسا", "کرج", "بندرعباس" };
        CityComboBox.Items.AddRange(Cityoptionen);

        FieldOfJobComboBox.SelectedIndex = 0;
        FieldOfJobComboBox.SelectedIndexChanged += FieldOfJobComboBox_SelectedIndexChanged;

        ProvinceComboBox.SelectedIndex = 0;
        ProvinceComboBox.SelectedIndexChanged += ProvinceComboBox_SelectedIndexChanged;
    }
    private void FieldOfJobComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (FieldOfJobComboBox.Text)
        {
            case "همه شغل ها":
                JobTitelComboBox.Items.Clear();
                JobTitelComboBox.Items.AddRange(new string[]{"دندانپزشک","رادیولوژیست","چشم پزشک", "مهندس فرایند", "مهندس مکانیک", "مهندس ساختمان",
                                        "ریاضی و فیزیک","زبان انگلیسی","پرستار","نوازنده پیانو","نوازنده دف" });
                break;

            case "پزشک و متخصص":
                JobTitelComboBox.Items.Clear();
                JobTitelComboBox.Items.AddRange(new string[] { "دندانپزشک", "رادیولوژیست", "چشم پزشک" });
                break;

            case "فنی و مهندسی":
                JobTitelComboBox.Items.Clear();
                JobTitelComboBox.Items.AddRange(new string[] { "مهندس فرایند", "مهندس مکانیک", "مهندس ساختمان" });
                break;

            case "معلم":
                JobTitelComboBox.Items.Clear();
                JobTitelComboBox.Items.AddRange(new string[] { "ریاضی و فیزیک", "زبان انگلیسی" });
                break;

            case "هنرمند":
                JobTitelComboBox.Items.Clear();
                JobTitelComboBox.Items.AddRange(new string[] { "نوازنده پیانو", "نوازنده دف" });
                break;
        }
    }

    private void ProvinceComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (ProvinceComboBox.Text)
        {
            case "همه استان ها":
                CityComboBox.Items.Clear();
                CityComboBox.Items.AddRange(new string[] { "مشهد", "تهران", "قم", "نجف آباد", "اصفهان", "شیراز", "فسا", "کرج", "بندرعباس" });
                break;

            case "خراسان":
                CityComboBox.Items.Clear();
                CityComboBox.Items.AddRange(new string[] {"مشهد"});
                break;

            case "تهران":
                CityComboBox.Items.Clear();
                CityComboBox.Items.AddRange(new string[] {"تهران", "قم"});
                break;

            case "اصفهان":
                CityComboBox.Items.Clear();
                CityComboBox.Items.AddRange(new string[] {"نجف آباد", "اصفهان"});
                break;

            case "فارس":
                CityComboBox.Items.Clear();
                CityComboBox.Items.AddRange(new string[] {"شیراز", "فسا"});
                break;
            case "البرز":
                CityComboBox.Items.Clear();
                CityComboBox.Items.AddRange(new string[] {"کرج"});
                break;
            case "هرمزگان":
                CityComboBox.Items.Clear();
                CityComboBox.Items.AddRange(new string[] {"بندرعباس"});
                break;
        }
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
        ReloadJobManagmentEvent.Invoke();
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
        ReloadJobManagmentEvent.Invoke();
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

        if (SelectedJobId == 0)
        {
            MessageBox.Show("!لطفاً ابتدا بخش مورد نظر را انتخاب کنید");
            return;
        }

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
        ReloadJobManagmentEvent.Invoke();
        MessageBox.Show(".به روز رسانی با موفقیت انجام شد");
    }    
    public void RefreshJobManagmentForm()
    {
        JobAppliedDataGridView.DataSource = null;
        JobAppliedDataGridView.DataSource = jobService.GetAll();
        JobAppliedDataGridView: Refresh();
    }
}
