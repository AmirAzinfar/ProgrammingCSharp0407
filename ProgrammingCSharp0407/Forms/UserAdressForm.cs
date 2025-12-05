using ProgrammingInCshrpBaseBackend.Models;
using ProgrammingInCshrpBaseBackend.Services;

namespace ProgrammingCSharp0407.Forms
{
    public partial class UserAdressForm : Form
    {
        AdressService adressService;
        public UserAdressForm()
        {
            InitializeComponent();
            adressService = new AdressService();
            AdressDataGridView.DataSource = adressService.GetAll();
            AdressDataGridView.Refresh();
        }

        private void RegistAdressButton_Click(object sender, EventArgs e)
        {
            UserAdressForm userAdressForm = new UserAdressForm();
            string Street = StreetTextBox.Text;
            string HouseNumber = HousNumberTextBox.Text;
            string PostalCod = PostalCodeTextBox.Text;

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
            if (string.IsNullOrEmpty(PostalCod))
            {
                MessageBox.Show("!لطفآ کد پستی را وارد کنید");
                return;
            }

            Adress adress = new Adress(street:Street,houseNumber:HouseNumber,postalCode:PostalCod);
            adressService.Add(adress);
            AdressDataGridView.DataSource = null;
            AdressDataGridView.DataSource= adressService.GetAll();  
            AdressDataGridView.Refresh();   
                    
        }
        public void ResetAdressInfo()
        {
            StreetTextBox.Text = null;
            HousNumberTextBox.Text = null;
            PostalCodeTextBox.Text = null;
        }

        private void DeleteAdressInfoButton_Click(object sender, EventArgs e)
        {
            ResetAdressInfo();
        }

        private void CloseAdressButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
