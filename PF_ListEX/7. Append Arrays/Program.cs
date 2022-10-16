using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersAsStrings = Console.ReadLine()
                                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                                .Reverse()
                                .ToList();

            List<int> numbers = new List<int>();
            foreach (var str in numbersAsStrings)
            {               
                numbers.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList()
                                     );
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
