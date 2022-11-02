using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var counts = new Dictionary<string, int>();

            string[] words = Console.ReadLine()
                .Split();
                

            foreach (var word in words)
            {
                string lowerCaseWord = word.ToLower();
                if (!counts.ContainsKey(lowerCaseWord))
                {
                    counts.Add(lowerCaseWord, 0);
                }

                counts[lowerCaseWord] += 1;
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
