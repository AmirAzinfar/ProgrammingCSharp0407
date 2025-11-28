using ProgrammingCSharp0407.Helpers;
using ProgrammingCSharp0407.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgrammingCSharp0407.Forms
{
    public partial class UserManagmentForm : Form
    {
        public UserManagmentForm()
        {
            InitializeComponent();
        }

        private void RegisterUserbutton_Click(object sender, EventArgs e)
        {
            // Data collect from user
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string nationalCode = NationalCodeTextBox.Text;
            string phonNumber = PhoneNumberTextBox.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                return;
            }

            if (PhoneNumberHelper.IsValidPhoneNumber(phonNumber))
            {
                
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

            User user = new User(nationalCode: nationalCode, phoneNumber: phonNumber)
            {
                FirstName = firstName,
                LastName = lastName,
                NationalCode = nationalCode,
                PhoneNumber = phonNumber
            };

            List<User> users = new List<User>();
            users.Add(user);


        }

        private void ResetForm()
        {
            FirstNameTextBox.Text =null;
            LastNameTextBox.Text=null;
            NationalCodeTextBox.Text = null;
            PhoneNumberTextBox.Text = null;
        }
        private void DeleteRegisterbutton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
