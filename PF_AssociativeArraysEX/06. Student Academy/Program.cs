using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            int pairOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < pairOfLines; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<double>());
                }
                studentsGrades[name].Add(grade);
            }

            foreach (var item in studentsGrades)
            {
                if (item.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }
        }
    }
}
