using System;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            // first name
            Console.WriteLine("Enter your first name");
            var firstName = Console.ReadLine();

            foreach(var letter in firstName)
            {
                Console.WriteLine(letter);
            }

            // last name
            Console.WriteLine("Enter your last name");
            var lastName = Console.ReadLine();
            var lastNameWithSpaces = "";

            foreach(var letter in lastName.ToUpper())
            {
                lastNameWithSpaces += letter + " ";
            }

            Console.WriteLine(lastNameWithSpaces.Trim());

            // middle name
            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();

            if (hasMiddleName == "y")
            {
                Console.WriteLine("What is your middle name?");
                var middleName = Console.ReadLine();
                var i = 0;

                foreach(var letter in middleName)
                {
                    Console.WriteLine(letter.ToString().PadLeft(++i));
                }
            }
            else
            {
                Console.WriteLine("Well, that sucks.");
            }

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
