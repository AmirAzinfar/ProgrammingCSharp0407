using ProgrammingInCshrpBaseBackend.Models;
using ProgrammingInCshrpBaseBackend.Services;


namespace ProgrammingCSharp0407.Forms;
public partial class UploadDocsForm : Form
{
    int SelectedFileId = 0;
    UploadDocService uploadDocService;

    public byte[] motivationFileData;
    public byte[] educationFileData;
    public byte[] jobExperienceFileData;
    public byte[] cvFileData;
    public byte[] employmentReferenceFileData;

    public UploadDocsForm()
    {
        InitializeComponent();
        uploadDocService = new UploadDocService();
        LoadListView();
    }
    private void LoadListView()
    {
        UploadDocListView.Items.Clear();
        var uploadDocs = uploadDocService.GetAll();

        var docs = uploadDocService.GetAll();

        foreach (var doc in docs)
        {
            ListViewItem item = new ListViewItem(doc.Id.ToString());
            item.SubItems.Add(doc.Motivation != null && doc.Motivation.Length > 0 ? "✔" : "x");
            item.SubItems.Add(doc.Education != null && doc.Education.Length > 0 ? "✔" : "x");
            item.SubItems.Add(doc.JobExperience != null && doc.JobExperience.Length > 0 ? "✔" : "x");
            item.SubItems.Add(doc.CV != null && doc.CV.Length > 0 ? "✔" : "x");
            item.SubItems.Add(doc.EmploymentReference != null && doc.EmploymentReference.Length > 0 ? "✔" : "x");
            item.SubItems.Add(doc.CreatedAt.ToString("yyyy-MM-dd"));

            UploadDocListView.Items.Add(item);
        }
    }

    private void ConfirmButton_Click(object sender, EventArgs e)
    {
        if (motivationFileData == null &&
            educationFileData == null &&
            jobExperienceFileData == null &&
            cvFileData == null &&
            employmentReferenceFileData == null)
        {
            MessageBox.Show("!لطفاً حداقل یک فایل را بارگذاری کنید");
            return;
        }
        UploadDoc doc = new UploadDoc
        {
            Motivation = motivationFileData,
            Education = educationFileData,
            JobExperience = jobExperienceFileData,
            CV = cvFileData,
            EmploymentReference = employmentReferenceFileData,
            CreatedAt = DateTime.Now
        };

        uploadDocService.Add(doc);
        LoadListView();
        ResetLabel();
        motivationFileData = null;
        educationFileData = null;
        jobExperienceFileData =null;
        cvFileData = null;
        employmentReferenceFileData = null;

    }
    public void LoadFile(out byte[] fileData)
    {
        OpenFileDialog openFile = new OpenFileDialog();
        openFile.Filter = "PDF Files (*.pdf)|*.pdf";

        if (openFile.ShowDialog() == DialogResult.OK)
        {
            fileData = File.ReadAllBytes(openFile.FileName);
        }
        else
        {
            fileData = null;
        }
    }
    private void MotivationButton_Click(object sender, EventArgs e)
    {
        LoadFile(out motivationFileData);
        if (motivationFileData != null)
        {
            MotivationStatusLabel.Text = "\u2714 بارگذاری شد";
            MessageBox.Show(".فایل شما با موفقیت بارگذاری شد");
        }
    }
    private void CVButton_Click(object sender, EventArgs e)
    {
        LoadFile(out cvFileData);
        if (cvFileData != null)
        {
            CVStatusLabel.Text = "\u2714 بارگذاری شد";
            MessageBox.Show(".فایل شما با موفقیت بارگذاری شد");
        }
    }

    private void EducationButton_Click(object sender, EventArgs e)
    {
        LoadFile(out educationFileData);
        if (educationFileData != null)
        {
            EducationStatusLabel.Text = "\u2714 بارگذاری شد";
            MessageBox.Show(".فایل شما با موفقیت بارگذاری شد");
        }
    }
    private void JobExperiencButton_Click(object sender, EventArgs e)
    {
        LoadFile(out jobExperienceFileData);
        if (jobExperienceFileData != null)
        {
            JobExperiencStatusLabel.Text = "\u2714 بارگذاری شد";
            MessageBox.Show(".فایل شما با موفقیت بارگذاری شد");
        }
    }
    private void EmploymentReferenceButton_Click(object sender, EventArgs e)
    {
        LoadFile(out employmentReferenceFileData);
        if (employmentReferenceFileData != null)
        {
            EmploymentReferenceLabel.Text = "\u2714 بارگذاری شد";
            MessageBox.Show(".فایل شما با موفقیت بارگذاری شد");
        }
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void DeleteFileButton_Click(object sender, EventArgs e)
    {
        if (SelectedFileId == 0)
        {
            MessageBox.Show("!لطفا در ابتدا فایل مورد نظر را انتخاب کنید");
            return;
        }
        uploadDocService.Delete(SelectedFileId);
        LoadListView();

        MessageBox.Show(".حذف فایل با موفقیت انجام شد");
    }

    private void UploadDocListView_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (UploadDocListView.SelectedItems.Count > 0)
        {
            SelectedFileId = int.Parse(UploadDocListView.SelectedItems[0].Text);
        }
    }
    public void ResetLabel()
    {
        CVStatusLabel.Text = "بارگذاری نشده";
        MotivationStatusLabel.Text = "بارگذاری نشده";
        EmploymentReferenceLabel.Text = "بارگذاری نشده";
        EducationStatusLabel.Text = "بارگذاری نشده";
        JobExperiencStatusLabel.Text = "بارگذاری نشده";
    }
}
