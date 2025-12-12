using ProgrammingCSharp0407.Helpers;
using ProgrammingInCshrpBaseBackend.Models;
using ProgrammingInCshrpBaseBackend.Services;


namespace ProgrammingCSharp0407.Forms;

public partial class UserManagmentForm : Form
{
    int SelectedUserId = 0;
    UserService userService;
    //List<User> users;

    //Declare The Delegate
    public delegate void ReloadData();
    //Declare Event
    public event ReloadData ReloadDataEvent; 
    public UserManagmentForm()
    {
        InitializeComponent();
        //users= new List<User>();
        userService = new UserService();

        ReloadDataEvent += RefreshUserManagmentForm; //connecting our Methode to our Event (ReloadDataEvent)
        ReloadDataEvent.Invoke(); //The event is triggered (did) immediately, and all registered methods are called.
        //RefreshUserManagmentForm();
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
        ReloadDataEvent.Invoke();
        MessageBox.Show(".ثبت نام شما با موفقیت انجام شد");

    }
    private void ResetForm()
    {
        FirstNameTextBox.Text = null;
        LastNameTextBox.Text = null;
        NationalCodeTextBox.Text = null;
        PhoneNumberTextBox.Text = null;
        SearchTextBox.Text = null;
        SelectedUserId = 0;
    }
    private void ResetRegisterbutton_Click(object sender, EventArgs e)
    {
        ResetForm();
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        string text = SearchTextBox.Text.Trim();

        if (string.IsNullOrEmpty(text))
        {
            MessageBox.Show("!کلمه مورد نظر جهت جستجو را در کادر جستجو وارد کنید");
            return;
        }
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void AdressUserButton_Click(object sender, EventArgs e)
    {
        UserAdressForm userAdressForm = new UserAdressForm();
        userAdressForm.ShowDialog();
    }

    private void UserManageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            //Get the current row
            var row = UserManageDataGridView.Rows[e.RowIndex];
            //Access the Id from rows data
            SelectedUserId = int.Parse(row.Cells["id"].Value.ToString());

            FirstNameTextBox.Text = row.Cells["FirstName"].Value?.ToString();
            LastNameTextBox.Text = row.Cells["LastName"].Value?.ToString();
            NationalCodeTextBox.Text = row.Cells["NationalCode"].Value?.ToString();
            PhoneNumberTextBox.Text = row.Cells["PhoneNumber"].Value?.ToString();
        }
    }

    private void DeleteInfoButton_Click(object sender, EventArgs e)
    {
        // I need id
        // Service call
        if (SelectedUserId == 0)
        {
            MessageBox.Show("!لطفا در ابتدا کاربر مورد نظر را انتخاب کنید");
            return;
        }
        userService.Delete(SelectedUserId);
        ReloadDataEvent.Invoke();
        MessageBox.Show(".حذف اطلاعات کاربر با موفقیت انجام شد");

    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        // Data collect from user
        string firstName = FirstNameTextBox.Text;
        string lastName = LastNameTextBox.Text;
        string nationalCode = NationalCodeTextBox.Text;
        string phonNumber = PhoneNumberTextBox.Text;
        DateTime birthday = BirthdayDateTimePicker.Value;
        DateTime createdAt = DateTime.Now;

        if (SelectedUserId == 0)
        {
            MessageBox.Show("!لطفا در ابتدا کاربر مورد نظر را انتخاب کنید");
            return;
        }

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

        User user = new User
        {
            Id = SelectedUserId,
            FirstName = firstName,
            LastName = lastName,
            NationalCode = nationalCode,
            PhoneNumber = phonNumber,
            Birthday = birthday,
        };
        //users.Add(user);
        userService.Update(user);
        ReloadDataEvent.Invoke();
        MessageBox.Show(".به روز رسانی با موفقیت انجام شد");
    }
    public void RefreshUserManagmentForm()
    {
        UserManageDataGridView.DataSource = null;
        //UserManageDataGridView.DataSource= users;
        UserManageDataGridView.DataSource = userService.GetAll();
        UserManageDataGridView.Refresh();
    }
}

