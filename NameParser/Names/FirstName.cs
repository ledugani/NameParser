using System;

namespace NameParser.Names
{
    class FirstName : NameBase
    {
        public FirstName() : base("first")
        {} 

        public void PrintName()
        {
            foreach (var letter in Name)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
