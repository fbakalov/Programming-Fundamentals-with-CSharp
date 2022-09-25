using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lName = Console.ReadLine();
            string deli = Console.ReadLine();

            Console.WriteLine(name + deli + lName);
        }
    }
}
