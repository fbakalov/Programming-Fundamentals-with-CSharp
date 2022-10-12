using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            bool change = false;
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
                    case "Contains":
                        bool hasNumber = numbers.Contains(int.Parse(inputArray[1]));

                        if (hasNumber)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }                        
                        break;
                    case "PrintEven":
                        List<int> evenNums = new List<int>(); 

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                evenNums.Add(numbers[i]); 
                            }
                        }
                        Console.WriteLine(string.Join(" ", evenNums));
                        break;

                    case "PrintOdd":
                        List<int> oddNums = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                oddNums.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", oddNums));
                        break;

                    case "GetSum":
                        int sum = numbers.Sum();
                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        int numberFilter = int.Parse(inputArray[2]);
                        if (inputArray[1] == "<")
                        {                       
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numberFilter > numbers[i])
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                        }
                        else if (inputArray[1] == ">")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numberFilter < numbers[i])
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                        }
                        else if (inputArray[1] == "<=")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numberFilter >= numbers[i])
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                        }
                        else if (inputArray[1] == ">=")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numberFilter <= numbers[i])
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "Add":
                        numbers.Add(int.Parse(inputArray[1]));
                        change = true; break;
                    case "Remove":
                        numbers.Remove(int.Parse(inputArray[1]));
                        change = true; break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(inputArray[1]));
                        change = true; break;
                    case "Insert":
                        int number = int.Parse(inputArray[1]);
                        int index = int.Parse(inputArray[2]);
                        numbers.Insert(index, number);
                        change = true; break;
                    default:
                        break;
                }
                
            }

            if (change == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
