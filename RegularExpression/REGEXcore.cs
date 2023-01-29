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

        public static void PasswordValidator(string[] password)
        {
            //string pattern = "^[a-zA-Z0-9!#$^&*_`~.-]{8}$"; // UC5 Password with atleast 8 characters 

            string pattern = @"^(?=.+[A-Z])[a-zA-Z0-9\W]{8,}$"; // UC6 Password with minimum 1 capital letter

            Checker(password, pattern);
        }
    }
}
