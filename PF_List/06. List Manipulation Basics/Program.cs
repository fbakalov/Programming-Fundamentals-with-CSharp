using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] inputArray = input.Split();

                switch (inputArray[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(inputArray[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(inputArray[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(inputArray[1]));
                        break;
                    case "Insert":
                        int number = int.Parse(inputArray[1]);
                        int index = int.Parse(inputArray[2]);
                        numbers.Insert(index, number);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
