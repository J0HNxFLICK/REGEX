namespace RegularExpression
{
    internal class UserRegistration
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validation using REGEX (Regular Expression)");

            string[] firstName = { "Arun", "charlie", "Luffy", "zoro", "Li"};

            Console.WriteLine("Inputs are ass following :");
            foreach (string s in firstName)
            {
                Console.Write(s+ " ");
            }
            Console.Write("\n");

            REGEXcore.UserNameValidation(firstName); // UC1 First name validation
        }
    }
}