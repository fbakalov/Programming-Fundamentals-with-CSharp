using System;
using System.Collections.Generic;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] comnArgs = input.Split(" : ");

                string cours = comnArgs[0];
                string name = comnArgs[1];

                if (!courses.ContainsKey(cours))
                {
                    courses.Add(cours, new List<string>());                 
                }
                
                courses[cours].Add(name);                
            }

            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                Console.Write("-- ");
                Console.Write(string.Join($"{Environment.NewLine}-- ", item.Value));
                Console.WriteLine();
            }
        }
    }
}
