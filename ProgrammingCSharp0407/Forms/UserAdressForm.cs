using ProgrammingInCshrpBaseBackend.Models;
using ProgrammingInCshrpBaseBackend.Services;

namespace ProgrammingCSharp0407.Forms;

public partial class UserAdressForm : Form
{
    int SelectedAdressId = 0;
    AdressService adressService;

    public delegate void ReloadAdress();
    public event ReloadAdress ReloadAdressEvent;
    public UserAdressForm()
    {
        InitializeComponent();
        adressService = new AdressService();

        ReloadAdressEvent += RefreshUserAdressForm;
        ReloadAdressEvent.Invoke();
    }

    private void RegistAdressButton_Click(object sender, EventArgs e)
    {
        UserAdressForm userAdressForm = new UserAdressForm();
        string Street = StreetTextBox.Text;
        string HouseNumber = HouseNumberTextBox.Text;
        string PostalCode = PostalCodeTextBox.Text;

        if (string.IsNullOrEmpty(Street))
        {
            MessageBox.Show("!لطفآ آدرس خیابان را وارد کنید");
            return;
        }
        if (string.IsNullOrEmpty(HouseNumber))
        {
            MessageBox.Show("!لطفآ پلاک محل را وارد کنید");
            return;
        }
        if (string.IsNullOrEmpty(PostalCode))
        {
            MessageBox.Show("!لطفآ کد پستی را وارد کنید");
            return;
        }

        Adress adress = new Adress(street: Street, houseNumber: HouseNumber, postalCode: PostalCode);
        adressService.Add(adress);
        ReloadAdressEvent.Invoke();
        MessageBox.Show(".آدرس کاربر با موفقیت ثبت شد");

    }
    public void ResetAdressInfo()
    {
        StreetTextBox.Text = null;
        HouseNumberTextBox.Text = null;
        PostalCodeTextBox.Text = null;
        SelectedAdressId = 0;
    }

    private void EditAdressInfoButton_Click(object sender, EventArgs e)
    {
        ResetAdressInfo();
    }

    private void CloseAdressButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void AdressDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            //Get the current row
            var row = AdressDataGridView.Rows[e.RowIndex];
            //Access the Id from rows data
            SelectedAdressId = int.Parse(row.Cells["id"].Value.ToString());

            StreetTextBox.Text = row.Cells["Street"].Value?.ToString();
            HouseNumberTextBox.Text = row.Cells["HouseNumber"].Value?.ToString();
            PostalCodeTextBox.Text = row.Cells["PostalCode"].Value?.ToString();
        }
    }

    private void UpdateAdressButton_Click(object sender, EventArgs e)
    {
        UserAdressForm userAdressForm = new UserAdressForm();
        string Street = StreetTextBox.Text;
        string HouseNumber = HouseNumberTextBox.Text;
        string PostalCode = PostalCodeTextBox.Text;

        if (string.IsNullOrEmpty(Street))
        {
            MessageBox.Show("!لطفآ آدرس خیابان را وارد کنید");
            return;
        }
        if (string.IsNullOrEmpty(HouseNumber))
        {
            MessageBox.Show("!لطفآ پلاک محل را وارد کنید");
            return;
        }
        if (string.IsNullOrEmpty(PostalCode))
        {
            MessageBox.Show("!لطفآ کد پستی را وارد کنید");
            return;
        }

        Adress adress = new Adress
        {
            Id = SelectedAdressId,
            Street = Street,
            HouseNumber = HouseNumber,
            PostalCode = PostalCode,
        };
        adressService.Update(adress);
        ReloadAdressEvent.Invoke();
        MessageBox.Show(".به روز رسانی با موفقیت انجام شد");
    }

    private void DeleteAdressButton_Click(object sender, EventArgs e)
    {
        // I need id
        // Service call
        if (SelectedAdressId == 0)
        {
            MessageBox.Show("!لطفا در ابتدا آدرس مورد نظر را انتخاب کنید");
            return;
        }
        adressService.Delete(SelectedAdressId);
        ReloadAdressEvent.Invoke();
        MessageBox.Show(".حذف اطلاعات کاربر با موفقیت انجام شد");
    }
    public void RefreshUserAdressForm()
    {
        AdressDataGridView.DataSource = null;
        AdressDataGridView.DataSource = adressService.GetAll();
        AdressDataGridView.Refresh();
    }
}
