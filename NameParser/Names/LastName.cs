using System;

namespace NameParser.Names
{
    class LastName
    {
        public object Name { get; private set; }

        public void GetName()
        {
            Console.WriteLine("Enter your last name");
            Name = Console.ReadLine();
        }

        public void PrintName()
        {
            var lastNameWithSpaces = "";

            foreach (var letter in lastName.ToUpper())
            {
                lastNameWithSpaces += letter + " ";
            }
        }
    }
}
