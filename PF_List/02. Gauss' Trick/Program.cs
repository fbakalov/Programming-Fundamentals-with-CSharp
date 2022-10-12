using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            int i = 0;
            while (i < numbers.Count - 1)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                i++;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
