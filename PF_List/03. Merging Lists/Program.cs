using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> newList = new List<int>();
            List<int> bigger = new List<int>();
            List<int> smaller = new List<int>();

            if (firstList.Count > secondList.Count)
            {
                bigger = firstList;
                smaller = secondList;
            }
            else
            {
                bigger = secondList;
                smaller = firstList;
            }

            for (int i = 0; i < bigger.Count; i++)
            {   
                if (i >= smaller.Count)
                {
                    newList.Add(bigger[i]);
                }
                else
                {
                    newList.Add(firstList[i]);
                    newList.Add(secondList[i]);  
                }

                   
            }

            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
