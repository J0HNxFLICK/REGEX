namespace RegularExpression
{
    internal class UserRegistration
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validation using REGEX (Regular Expression)");

            string[] firstName = { "Arun", "charlie", "D Luffy", "zoro", "Li"};
            Console.WriteLine("First name inputs are as following :");
            foreach (string s in firstName)
            {
                Console.Write(s+ ", ");
            }
            Console.Write("\n");
            REGEXcore.UserNameValidation(firstName); // UC1 First name validation
            Console.Write("\n\n");

            string[] lastName = { "Ashish", "puth", "Monkey", "roronoa", "sa" };
            Console.WriteLine("Last name inputs are as following :");
            foreach (string u in lastName)
            {
                Console.Write(u+ ", ");
            }
            Console.Write("\n");
            REGEXcore.UserNameValidation(lastName); // UC2 Last name validation
            Console.Write("\n\n");

            string[] email = { "abc.xyz@bl.co", "abc.xyz@bl.co.in", "abc.x@bl.co.in","ac.hahaha@bl.co.in", "gagaga@gmail.com", "dog.cat@bl.co.in"};
            Console.WriteLine("Email inputs are ass follows : ");
            foreach (string p in email)
            {
                Console.Write(p+ ", ");
            }
            Console.Write("\n");
            REGEXcore.EmailValidation(email);
            Console.Write("\n\n");

            string[] phoneNumbers = { "91 6578235489", "915789341587", "2145698755", "6541247893124", "5465221" };
            Console.WriteLine("Phone number inputs are as following :");
            foreach (string e in phoneNumbers)
            {
                Console.Write(e+ ", ");
            }
            Console.Write("\n");
            REGEXcore.PhoneNumberVerification(phoneNumbers); // UC4 Phone number validation
            Console.Write("\n\n");
        }
    }
}