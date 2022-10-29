using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int nStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < nStudents; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                Student student = new Student();
                student.FirstName = input[0];
                student.LastName = input[1];
                student.Grade = double.Parse(input[2]);

                students.Add(student);
            }

            List<Student> sortedLIst = students.OrderBy(o => o.Grade).ToList();
            sortedLIst.Reverse();
            foreach (Student student in sortedLIst)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
