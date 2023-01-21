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
        public static void UserNameValidation(string[] username) 
        {
            string pattern = "^[A-Z]{1}[a-zA-Z]{2,}$";

            foreach (string s in username)
            {
                if (Regex.IsMatch(s, pattern))
                {
                    Console.WriteLine("\n{0} is valid format." , s);
                }
                else
                    Console.WriteLine("\n{0} is not a valid format.", s);
            }
        }
    }
}
