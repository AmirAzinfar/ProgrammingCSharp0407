using ProgrammingCSharp0407.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp0407.Models
{
    internal class User : BaseEntity //entities
    {
        public User(string nationalCode, string phoneNumber) 
        {
            if (string.IsNullOrEmpty(nationalCode) || string.IsNullOrEmpty(phoneNumber))
            {
                throw new Exception();
            }

            NationalCode = nationalCode;
            PhoneNumber = phoneNumber;
        }
        //Access_Modifier Dtatype Name {get; set;}
        // public int Id { get; set; } beacuse inhertance from BaseEntity
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
