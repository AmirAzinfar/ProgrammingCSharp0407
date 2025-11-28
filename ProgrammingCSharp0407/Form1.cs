using ProgrammingCSharp0407.Forms;

namespace ProgrammingCSharp0407
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = UserNameTextBox.Text;
            string Password = PasswordTextBox.Text;

            if (UserName == "admin" && Password == "1234")
            {
                this.Hide();
                User_Panel user_Panel = new User_Panel();
                user_Panel.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("The password or username is not correct. Please note that it is case-sensitive!!");
            }
        }
    }
}
