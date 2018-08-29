using System;

namespace NameParser.Names
{
    class MiddleName
    {
        private readonly FirstName _firstName;

        public string Name { get; private set; } = "";

        public MiddleName(FirstName firstName)
        {
            Name = "";
            _firstName = firstName;
        }

        public void GetName()
        {
            if (UserHasMiddleName())
            {
                Console.WriteLine("What is your middle name?");
                Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($@"Well, {_firstName}, that really sucks for you.");
            }
        }

        bool UserHasMiddleName()
        {
            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();

            return hasMiddleName == "y";
        }

        public void PrintName()
        {
            var i = 0;

            foreach (var letter in Name)
            {
                Console.WriteLine(letter.ToString().PadLeft(++i));
            }
        }
    }
}
