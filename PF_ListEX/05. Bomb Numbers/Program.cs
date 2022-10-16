using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            int[] bombPower = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int bomb = bombPower[0];
            int power = bombPower[1];

            

            while (numbers.Contains(bomb))
            {   
                int indexOfBomb = numbers.IndexOf(bomb);

                int startIndex = indexOfBomb - power;
                int finishIndex = indexOfBomb + power;
                while (startIndex < 0)
                {
                    startIndex++;
                }

                while (finishIndex > numbers.Count - 1)
                {
                    finishIndex--;
                }

                for (int i = startIndex; i <= finishIndex; i++)
                {
                    numbers.RemoveAt(i);
                    i--;
                    finishIndex--;
                }
            }
            
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
