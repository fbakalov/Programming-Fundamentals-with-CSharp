using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passangersInWaggons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxPassangers = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArr = input.Split();

                if (inputArr[0] == "Add")
                {
                    passangersInWaggons.Add(int.Parse(inputArr[1]));
                }
                else
                {
                    int addingPassengers = int.Parse(input);
                    bool isFilled = false;
                    for (int i = 0; i < passangersInWaggons.Count; i++)
                    {
                        if (passangersInWaggons[i] + addingPassengers <= maxPassangers && isFilled == false)
                        {
                            passangersInWaggons[i] += addingPassengers;
                            isFilled = true;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", passangersInWaggons));
        }
    }
}
