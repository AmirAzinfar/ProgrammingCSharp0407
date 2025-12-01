using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp0407.Helpers
{
    internal class NationalCodeHelper
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
