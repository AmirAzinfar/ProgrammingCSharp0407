
namespace ProgrammingCSharp0407.Forms;

public partial class StartLoginForm : Form
{
    public StartLoginForm()
    {
        InitializeComponent();
        this.WindowState = FormWindowState.Maximized;
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.Dock = DockStyle.Fill;

        Form1 form1 = new Form1();
        form1.TopMost = true;
        form1.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
