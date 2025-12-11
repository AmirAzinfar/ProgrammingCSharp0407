namespace ProgrammingCSharp0407.Forms;

public partial class ContactWithUsForm : Form
{
    public ContactWithUsForm()
    {
        InitializeComponent();
    }

    private void ExitContactButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void SendContactButton_Click(object sender, EventArgs e)
    {
        //data collect
        string firstnameContact = FirstNameContactTextBox.Text;
        string lastNameContact = LastNameContactTextBox.Text;
        string subjectContact = SubjectContactTextBox.Text;
        string textContact = TextContacTextBox.Text;

        string messageContact = "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "]" + Environment.NewLine +
        "Firstname: " + firstnameContact + Environment.NewLine +
        "Lastname: " + lastNameContact + Environment.NewLine +
        "Subject: " + subjectContact + Environment.NewLine +
        "Your Message: " + Environment.NewLine +
        textContact + Environment.NewLine +
        "------------------------" + Environment.NewLine;

        if (firstnameContact =="" && lastNameContact =="" && subjectContact == "" && textContact == "")
        {
            MessageBox.Show("!لطفا بخش های ستاره دار را کامل کنید");
            return;
        }
        string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DOCs", "AddTextToFile.txt");

        if (File.Exists(filepath))
        {
            //contents write on file (write on file) using AppendAllText(path:filepath, contents:"someting");

            File.AppendAllText(path: filepath, contents: messageContact);
            //now, read new added Text
            string ShowAddedAllText = File.ReadAllText(filepath);

            MessageBox.Show(ShowAddedAllText);
            //if use File.WriteAllText-->overwrite all of text on file with my contents
            //File.WriteAllText(filepath,"Hier ist mein zweiets Codeline");
            MessageBox.Show(".متن شما با موفقیت ارسال شد");
        }
        else
        {
            MessageBox.Show("فایل مورد نظر در این آدرس وجود ندارد \n !لطفا مطمئن شوید آدرس فایل صحیح وارد شده باشد");
            //MessageBox.Show(filepath);
        }

    }

    private void DeleteContactButton_Click(object sender, EventArgs e)
    {
        FirstNameContactTextBox.Text = null;
        LastNameContactTextBox.Text = null;
        SubjectContactTextBox.Text = null;
        TextContacTextBox .Text = null;
    }
}
