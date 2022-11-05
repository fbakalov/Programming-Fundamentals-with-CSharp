using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();

            while (true)
            {
                string resours = Console.ReadLine();

                if (resours == "stop")
                    break;

                int value = int.Parse(Console.ReadLine());
                if (!resourses.ContainsKey(resours))
                {
                    resourses.Add(resours, value);
                }
                else
                {
                    resourses[resours] += value;
                }                              
            }

            foreach (var item in resourses)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
