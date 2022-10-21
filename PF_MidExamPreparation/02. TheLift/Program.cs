using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            List<int> liftState = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < liftState.Count; i++)
            {
                for (int j = 0; j <= people + 1; j++)
                {
                    if (liftState[i] < 4)
                    {
                        liftState[i] += 1;
                        
                        people -= 1;
                    }
                }
            }

            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");             
            }
            else
            {
                Console.WriteLine("The lift has empty spots!");
            }

            Console.WriteLine(string.Join(' ', liftState));
        }
    }
}
