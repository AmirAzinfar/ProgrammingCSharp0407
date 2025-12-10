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
        MessageBox.Show(".متن شما با موفقیت ارسال شد");
    }
}
