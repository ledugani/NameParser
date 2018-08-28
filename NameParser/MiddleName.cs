using System;

namespace NameParser.Names
{
    class MiddleName
    {
        public string Name { get; private set; }

        bool ConfirmMiddleName()
        {
            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();

            return hasMiddleName == "y";
        }

        public void GetName(string firstName)
        {
            if (ConfirmMiddleName())
            {
                Console.WriteLine("What is your middle name?");
                Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($@"Well, {firstName}, that really sucks for you.");
            }
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
