using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                bool isSmOrBigg = false;
                if (index < 0)
                {
                    numbers[0] = numbers[numbers.Count - 1];
                    index = 0;
                    isSmOrBigg = true;
                }
                else if (index > numbers.Count - 1)
                {
                    numbers[numbers.Count - 1] = numbers[0];
                    index = numbers.Count - 1;
                    isSmOrBigg = true;
                }

                if (index >= 0 && index < numbers.Count)
                {
                    int valueForIndex = numbers[index];
                    sum += valueForIndex;

                    if (isSmOrBigg == false)
                    {
                        numbers.RemoveAt(index);
                    }
                    
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= valueForIndex)
                        {
                            numbers[i] += valueForIndex;
                        }
                        else if (numbers[i] > valueForIndex)
                        {
                            numbers[i] -= valueForIndex;
                        }
                    }
                }
                
            }

            Console.WriteLine(sum);
        }


    }
}
