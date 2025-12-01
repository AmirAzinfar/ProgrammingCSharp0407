using ProgrammingCSharp0407.Helpers;
using ProgrammingCSharp0407.Utilities;
using ProgrammingInCshrpBaseBackend.Models;
using ProgrammingInCshrpBaseBackend.Services;


namespace ProgrammingCSharp0407.Forms
{
    public partial class UserManagmentForm : Form
    {
        UserService userService;
        //List<User> users;
        public UserManagmentForm()
        {
            InitializeComponent();
            //users= new List<User>();
            userService = new UserService();

        }

        private void RegisterUserbutton_Click(object sender, EventArgs e)
        {
            // Data collect from user
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string nationalCode = NationalCodeTextBox.Text;
            string phonNumber = PhoneNumberTextBox.Text;
            DateTime birthday = BirthdayDateTimePicker.Value;
            DateTime createdAt = DateTime.Now;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show(".لطفآ نام و نام خانوادگی را به صورت صحیح وارد کنید");
                return;
            }

            if (!PhoneNumberHelper.IsValidPhoneNumber(phonNumber))
            {
                MessageBox.Show("!لطفآ شماره تلفن خود را به صورت صحیح وارد کنید");
                return;
            }

            if (!NationalCodeHelper.IsValidNationalCode(nationalCode))
            {
                MessageBox.Show("!لطفآ کد ملی خود را به صورت صحیح وارد کنید");
                return;
            }


            //Data Type name   object creation
            //-----------------------
            // "same syntax for object creation from class"
            //User user = new();
            //var user = new User();
            //User user = new User();

            //user.FirstName = firstName;
            //user.LastName = lastName;
            //user.NationalCode = nationalCode;
            //user.PhoneNumber = phonNumber;
            //-----------------------

            User user = new User(firstName: firstName, lastName: lastName, birthDay: birthday, nationalCode: nationalCode, phoneNumber: phonNumber);
            //users.Add(user);
            userService.Add(user);
            UserManageDataGridView.DataSource = null;
            //UserManageDataGridView.DataSource= users;
            UserManageDataGridView.DataSource = userService.GetAll();
            UserManageDataGridView.Refresh();

        }

        private void ResetForm()
        {
            FirstNameTextBox.Text = null;
            LastNameTextBox.Text = null;
            NationalCodeTextBox.Text = null;
            PhoneNumberTextBox.Text = null;
            SearchTextBox.Text = null;
        }
        private void ResetRegisterbutton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string TextSearch = SearchTextBox.Text.Trim();
            if (string.IsNullOrEmpty(TextSearch))
            {
                MessageBox.Show("!کلمه مورد نظر جهت جستجو را در کادر جستجو وارد کنید");
                return;
            }

           //to continue, I nees foreach and Information abaut DataGridViewCell
        }
    }
}
