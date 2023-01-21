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
        }
    }
}