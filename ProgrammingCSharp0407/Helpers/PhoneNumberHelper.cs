using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp0407.Helpers
{
    internal class PhoneNumberHelper
    {
        public static bool IsValidPhoneNumber (string phoneNumber)
        {
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string FormatToValidPhoneNumber(string phoneNumber)
        {  
            return phoneNumber; 
        }

    }
}
