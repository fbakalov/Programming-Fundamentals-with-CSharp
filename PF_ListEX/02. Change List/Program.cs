using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input.Split();

                if (inputArr[0] == "Delete")
                {
                    int numberToDel = int.Parse(inputArr[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == numberToDel)
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                }
                else if (inputArr[0] == "Insert")
                {
                    int index = int.Parse(inputArr[2]);
                    int numberToInsr = int.Parse(inputArr[1]);
                    numbers.Insert(index, numberToInsr);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
