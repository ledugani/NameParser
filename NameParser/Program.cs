using System;
using NameParser.Names;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            // instances
            var firstName = new FirstName();
            var lastName = new LastName();
            var middleName = new MiddleName(firstName);

            // first name
            firstName.GetName();
            firstName.PrintName();

            // last name
            lastName.GetName();
            lastName.PrintName();

            // middle name
            middleName.GetName();
            middleName.PrintName();

            // full name and goodbye
            Console.WriteLine($"Goodbye {firstName} {middleName} {lastName}. Press enter to exit.");
            Console.ReadLine();
        }
    }
}
