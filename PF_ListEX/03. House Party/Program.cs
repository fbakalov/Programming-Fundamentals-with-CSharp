using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCommands = int.Parse(Console.ReadLine());

            List<string> namesGoing = new List<string>();

            for (int i = 0; i < numCommands; i++)
            {
                string input = Console.ReadLine();
                string[] sentanse = input.Split();
                string name = sentanse[0];

                if (sentanse[2] == "not")
                {
                    if (namesGoing.Contains(name))
                    {
                        namesGoing.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (namesGoing.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        namesGoing.Add(name);
                    }
                }
            }

            foreach (string item in namesGoing)
            {
                Console.WriteLine(item);
            }
        }

    }
}
