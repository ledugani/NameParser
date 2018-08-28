using System;
using NameParser.Names;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            // first name
            var firstName = new FirstName();
            firstName.GetName();
            firstName.PrintName();

            // last name
            var lastName = new LastName();
            lastName.GetName();
            lastName.PrintName();

            // middle name
            var middleName = new MiddleName();
            middleName.GetName(firstName.Name);
            middleName.PrintName();

            // full name and goodbye
            Console.WriteLine($"Goodbye {firstName} {middleName} {lastName}. Press enter to exit.");
            Console.ReadLine();
        }
    }
}
