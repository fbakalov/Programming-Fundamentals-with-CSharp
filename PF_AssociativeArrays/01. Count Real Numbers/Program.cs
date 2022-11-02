using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOcc = new SortedDictionary<double, int>();

            double[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var currNum in inputNumbers)
            {
                if (!numberOcc.ContainsKey(currNum))
                {
                    numberOcc.Add(currNum, 0);
                }

                numberOcc[currNum] += 1;
            }

            foreach (var item in numberOcc)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
