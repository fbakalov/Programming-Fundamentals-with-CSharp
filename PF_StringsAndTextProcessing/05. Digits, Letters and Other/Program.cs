using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            char[] lineChArr = line.ToCharArray();

            string digits = string.Empty;
            string letters = string.Empty;
            string other = string.Empty;

            foreach (var symbol in lineChArr)
            {
                if (char.IsDigit(symbol))
                {
                    digits += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    letters += symbol;
                }
                else
                {
                    other += symbol;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
