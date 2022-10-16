using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputSplit = input.Split();

                if (inputSplit[0] == "Add")
                {
                    numbers = Add(numbers, inputSplit[1]);
                }
                else if (inputSplit[0] == "Insert")
                {
                    numbers = Insert(numbers, inputSplit[1], inputSplit[2]);
                }
                else if (inputSplit[0] == "Remove")
                {
                    numbers = Remove(numbers, inputSplit[1]);
                }
                else if (inputSplit[0] == "Shift")
                {
                    int count = int.Parse(inputSplit[2]);

                    if (inputSplit[1] == "left")
                    {
                        numbers = ShfLeft(numbers, count);
                    }
                    else if (inputSplit[1] == "right")
                    {
                        numbers = ShfRight(numbers, count);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> ShfRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
            return numbers;
        }

        static List<int> ShfLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
            return numbers;
        }

        static List<int> Remove(List<int> numbers, string v)
        {
            int index = int.Parse(v);

            if (index < 0 || index > numbers.Count)
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }

            numbers.RemoveAt(index);
            return numbers;
        }

        static List<int> Insert(List<int> numbers, string v1, string v2)
        {
            int num = int.Parse(v1);
            int index = int.Parse(v2);

            if (index < 0 || index > numbers.Count)
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }

            numbers.Insert(index, num);
            return numbers;
        }

        static List<int> Add(List<int> numbers, string input)
        {
            int num = int.Parse(input);
            numbers.Add(num);
            return numbers;
        }
    }
}
