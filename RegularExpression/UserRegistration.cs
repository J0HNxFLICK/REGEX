namespace RegularExpression
{
    internal class UserRegistration
    {
        public static void Printer(string[] data)
        {
            foreach (string s in data)
            {
                Console.Write(s + ", ");
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Validation using REGEX (Regular Expression)");

            string[] firstName = { "Arun", "charlie", "D Luffy", "zoro", "Li"};
            Console.WriteLine("First name inputs are as following :");
            Printer(firstName);
            REGEXcore.UserNameValidation(firstName); // UC1 First name validation
            Console.Write("\n\n");

            string[] lastName = { "Ashish", "puth", "Monkey", "roronoa", "sa" };
            Console.WriteLine("Last name inputs are as following :");
            Printer(lastName);
            REGEXcore.UserNameValidation(lastName); // UC2 Last name validation
            Console.Write("\n\n");

            string[] email = { "abc.xyz@bl.co", "abc.xyz@bl.co.in", "abc.x@bl.co.in","ac.hahaha@bl.co.in", "gagaga@gmail.com", "dog.cat@bl.co.in"};
            Console.WriteLine("Email inputs are ass follows : ");
            Printer(email);
            REGEXcore.EmailValidation(email);
            Console.Write("\n\n");

            string[] phoneNumbers = { "91 6578235489", "915789341587", "2145698755", "6541247893124", "5465221" };
            Console.WriteLine("Phone number inputs are as following :");
            Printer(phoneNumbers);
            REGEXcore.PhoneNumberVerification(phoneNumbers); // UC4 Phone number validation
            Console.Write("\n\n");

            string[] passwords = { "ahey$^*6", "alkjsdaaaakwj", "_-.!*$#-" };
            Console.WriteLine("Password inputs are :");
            Printer(passwords);
            REGEXcore.PasswordValidator(passwords);
            Console.Write("\n\n");
        }
    }
}