using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                char beforeLetter = inputs[i][0];
                char afterLetter = inputs[i][inputs[i].Length - 1];
                string numStr = new string(inputs[i].Where(c => char.IsDigit(c)).ToArray());
                double number = double.Parse(numStr);

                int indexBefore = (int)beforeLetter % 32;
                int indexAfter = (int)afterLetter % 32;

                if (char.IsLower(beforeLetter))
                {
                    number *= indexBefore;
                }
                else
                {
                    number /= indexBefore;
                }

                if (char.IsLower(afterLetter))
                {
                    number += indexAfter;
                }
                else
                {
                    number -= indexAfter;
                }

                sum += number;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
