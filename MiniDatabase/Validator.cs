using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MiniDatabase
{
    public class Validator
    {
        private static string name = @"(?i)^[a-z-ğüşçöı]+$";
        private static string username = @"(?i)^[0-9a-z]{6,10}$";
        private static string phoneNumber = @"^([+][\d]+)[\s]([\d]+)[\s]([\d]+)$";
        private static string date = @"^(19|20\d\d)[-](0[1-9]|1[012])[-](0[1-9]|[12][0-9]|3[01])$";

        public static bool validateUsername(string input)
        {
            Regex regex = new Regex(username);
            if (regex.IsMatch(input))
            {
                return true;
            }

            return false;
        }

        public static bool validateName(string input)
        {
            if (Encoding.UTF8.GetByteCount(input) > 30) { return false; }
            Regex regex = new Regex(name);
            if (!regex.IsMatch(input))
            {
                return false;
            }

            return true;
        }

        public static bool validateDepartment(string input)
        {
            if (Encoding.UTF8.GetByteCount(input) > 20) { return false; }

            return true;
        }

        public static bool validatePhoneNumber(string input)
        {
            if (input.Length > 25)
            {
                return false;
            }

            Regex regex = new Regex(phoneNumber);
            if (!regex.IsMatch(input))
            {
                return false;
            }

            return true;
        }

        public static bool validateDate(string input)
        {
            Regex regex = new Regex(date);
            if (!regex.IsMatch(input))
            {
                return false;
            }

            return true;
        }

    }
}
