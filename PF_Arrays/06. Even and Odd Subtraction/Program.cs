using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int even = 0;
            int odd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even += array[i];
                }
                else
                {
                    odd += array[i];
                }
            }
            int sub = even - odd;
            Console.WriteLine(sub);
        }
    }
}
