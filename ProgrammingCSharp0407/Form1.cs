using Newtonsoft.Json;
using ProgrammingCSharp0407.Forms;
using ProgrammingCSharp0407.Wrappers;

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

            // work with json file
            string Pathfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "UserLogin.json");
            if (!File.Exists(Pathfile))
            {
                MessageBox.Show("!لطفا مطمئن شوید آدرس فایل صحیح وارد شده باشد");
                return;
            }

            string content = File.ReadAllText(Pathfile);

            //we need contents of json file (string,int,bool,...) change to a C#_Object with property
            //--> therfor, we need pakage installation that names Newtonssoft.json
            //Installation: rigth click on project file-->NuGet Paket managment-->
            //browse-->search:Newtonsoft-->install
            //DeserializeObject-->string to Object
            //SerializeObject--> Object to string

            List<UserLogin> userLogins = JsonConvert.DeserializeObject<List<UserLogin>>(content);

            var login = userLogins.Where(item => item.UserName == UserName && item.PassWord == Password).FirstOrDefault();

            if (login != null)
            {
                this.Hide();
                UserPanelForm userPanelForm = new UserPanelForm();
                userPanelForm.ShowDialog();
                return;
            }

            //for (int i = 0; i < userLogins.Count; i++)
            //{

            //    if (UserName == userLogins[i].UserName && Password == userLogins[i].PassWord)
            //    {
            //        this.Hide();
            //        UserPanelForm userPanelForm = new UserPanelForm();
            //        userPanelForm.ShowDialog();
            //        return;
            //    }
            //}
            MessageBox.Show("نام کاربری یا کلمه عبور شما صحیح نمی باشد");
            ResetFields();
        }
        public void ResetFields()
        {
            UserNameTextBox.Text = null;
            PasswordTextBox.Text = null;
        }


        //----------------------first, I started with these Codes

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string UserName = UserNameTextBox.Text;
        //    string Password = PasswordTextBox.Text;

        //    string Pathfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "UserLogin.txt");
        //    if (!File.Exists(Pathfile))
        //    {
        //        MessageBox.Show("!لطفا مطمئن شوید آدرس فایل صحیح وارد شده باشد");
        //        return;
        //    }

        //    //If user and Password are on first line
        //    //string [] Line = File.ReadAllLines(Pathfile);
        //    //string Firstline = Line[0]; //admin,1234
        //    //string [] Login = Firstline.Split(",");

        //    string[] Line = File.ReadAllLines(Pathfile);


        //    for (int i = 0; i < Line.Length; i++)
        //    {
        //        string Currentline = Line[i];
        //        string[] Login = Currentline.Split(",");
        //        if (UserName == Login[0] && Password == Login[1])
        //        {
        //            this.Hide();
        //            UserPanelForm userPanelForm = new UserPanelForm();
        //            userPanelForm.ShowDialog();
        //            return;
        //        }
        //    }
        //    MessageBox.Show("نام کاربری یا کلمه عبور شما صحیح نمی باشد");
        //    ResetFields();
        //}
        ////if (UserName == "admin" && Password == "1234")
        ////if (UserName == Login[0] && Password == Login[1])
        ////{
        ////    this.Hide();
        ////    UserPanelForm userPanelForm = new UserPanelForm();
        ////    userPanelForm.ShowDialog();
        ////}
        ////else
        ////{
        ////    MessageBox.Show("نام کاربری یا کلمه عبور شما صحیح نمی باشد");
        ////}
        //public void ResetFields()
        //{
        //    UserNameTextBox.Text = null;
        //    PasswordTextBox.Text = null;
        //}
    }
}
