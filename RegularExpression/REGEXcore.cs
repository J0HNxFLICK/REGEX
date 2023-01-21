using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class REGEXcore
    {
        private static void Checker(string[] values, string pattern)
        {

            foreach (string s in values)
            {
                if (Regex.IsMatch(s, pattern))
                {
                    Console.WriteLine("\n{0} is valid format.", s);
                }
                else
                    Console.WriteLine("\n{0} is not a valid format.", s);
            }
        }
        public static void UserNameValidation(string[] username) 
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}$";

            Checker(username, pattern);
        }

        public static void EmailValidation(string[] email)
        {
            string pattern = @"^abc\.[a-z]*@bl\.co(\.in)?$"; // UC2 pattern to check example wise

            Checker(email, pattern);
        }

        public static void PhoneNumberVerification(string[] phoneNumbers)
        {
            string pattern = "^(91)[ ][0-9]{10}$";

            Checker(phoneNumbers, pattern);
        }
    }
}
