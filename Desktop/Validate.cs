using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desktop
{
    class Validate
    {
        public static bool ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(email);
        }
        public static bool ValidatePassword(string password)
        {
            if (password.Length < 6) return false;
            else return true;
        }
        public static bool ValidateName(string name)
        {
            if (name.Length < 3) return false;
            else return true;
        }
    }
}
