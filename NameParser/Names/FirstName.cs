using System;

namespace NameParser.Names
{
    class FirstName
    {
        private string _name;

        public string _firstName;

        public void GetName()
        {
            Console.WriteLine("Enter your first name");
            _firstName = Console.ReadLine();
        }

        public void PrintName()
        {
            foreach (var letter in _firstName)
            {
                Console.WriteLine(letter);
            }
        }

        public void GetAndPrint()
        {
            GetName();
            PrintName();
        }
    }
}
