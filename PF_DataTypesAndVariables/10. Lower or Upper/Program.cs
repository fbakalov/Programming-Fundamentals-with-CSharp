using System;
using System.Linq;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch = Console.ReadLine();

            if (ch.Any(char.IsUpper))
            {
                Console.WriteLine("upper-case");
            }
            else if (ch.Any(char.IsLower))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
