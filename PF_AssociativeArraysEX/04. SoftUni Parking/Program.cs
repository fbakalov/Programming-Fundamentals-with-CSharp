using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> validations = new Dictionary<string, string>();

            int numComms = int.Parse(Console.ReadLine());
            for (int i = 0; i < numComms; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split();

                string name = commands[1];

                if (commands[0] == "register")
                {
                    if (!DoesItExistREG(validations, name))
                    {
                        string regPlate = commands[2];
                        validations.Add(name, regPlate);
                        Console.WriteLine($"{name} registered {regPlate} successfully");
                    }                
                }
                else if (commands[0] == "unregister")
                {
                    if (validations.ContainsKey(name))
                    {
                        validations.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }

            foreach (var item in validations)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        static bool DoesItExistREG(Dictionary<string, string> validations, string name)
        {
            foreach (var item in validations)
            {
                if (item.Key == name)
                {
                    Console.WriteLine($"ERROR: already registered with plate number {item.Value}");
                    return true;
                }
            }
            return false;
        }
    }
}
