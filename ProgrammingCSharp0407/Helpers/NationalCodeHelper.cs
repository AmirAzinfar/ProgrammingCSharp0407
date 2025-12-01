namespace ProgrammingCSharp0407.Helpers
{
    internal static class NationalCodeHelper
    {
        public static bool IsValidNationalCode(string nationalCode)
        {
            if (!string.IsNullOrEmpty(nationalCode))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string FormatToValidNationalCode(string nationalCode)
        {
            return nationalCode;
        }
    }
}
