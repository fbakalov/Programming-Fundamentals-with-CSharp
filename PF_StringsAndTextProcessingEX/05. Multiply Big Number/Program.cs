using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multyplier = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            int reminer = 0;

            if (input == "0" || multyplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currendDigit = int.Parse(input[i].ToString());
                int product = currendDigit * multyplier + reminer;
                int result = product % 10;
                reminer = product / 10;
                sb.Insert(0, result);
            }

            if (reminer > 0)
            {
                sb.Insert(0, reminer);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
