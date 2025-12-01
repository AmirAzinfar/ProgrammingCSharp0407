namespace ProgrammingCSharp0407.Helpers
{
    internal static class PhoneNumberHelper
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

        public static string FormatToValidPhoneNumber (string phoneNumber)
        {  
            return phoneNumber; 
        }

        

    }
}
