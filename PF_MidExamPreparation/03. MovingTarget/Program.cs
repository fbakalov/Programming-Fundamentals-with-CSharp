using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequanceTarg = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commnd;
            while ((commnd = Console.ReadLine()) != "End")
            {
                string[] cmdSplit = commnd.Split();

                if (cmdSplit[0] == "Shoot")
                {
                    sequanceTarg = Shoot(sequanceTarg, int.Parse(cmdSplit[1]), int.Parse(cmdSplit[2]));
                }
                else if (cmdSplit[0] == "Add")
                {
                    sequanceTarg = Add(sequanceTarg, int.Parse(cmdSplit[1]), int.Parse(cmdSplit[2]));
                }
                else if (cmdSplit[0] == "Strike")
                {
                    sequanceTarg = Strike(sequanceTarg, int.Parse(cmdSplit[1]), int.Parse(cmdSplit[2]));
                }
            }

            Console.WriteLine(string.Join('|', sequanceTarg));
        }

        private static List<int> Strike(List<int> sequanceTarg, int index, int range)
        {
            int plusRange = index + range;
            int minusRange = index - range;

            if ((index < 0 || index > sequanceTarg.Count - 1) ||
                (plusRange < 0 || plusRange > sequanceTarg.Count - 1) ||
                (minusRange < 0 || minusRange > sequanceTarg.Count - 1))
            {
                Console.WriteLine("Strike missed!");
                return sequanceTarg;
            }
            else
            {
                sequanceTarg.RemoveRange(minusRange, plusRange);
                return sequanceTarg;
            }
        }

        private static List<int> Add(List<int> sequanceTarg, int index, int value)
        {
            if (index < 0 || index > sequanceTarg.Count - 1)
            {
                Console.WriteLine("Invalid placement!");
                return sequanceTarg;
            }
            else
            {
                sequanceTarg.Insert(index, value);
                return sequanceTarg;
            }
        }

        private static List<int> Shoot(List<int> sequanceTarg, int index, int power)
        {
            if (index > 0 && index < sequanceTarg.Count)
            {
                sequanceTarg[index] -= power;

                if (sequanceTarg[index] <= 0)
                {
                    sequanceTarg.RemoveAt(index);
                }
            }
           
            return sequanceTarg;
        }
    }
}
