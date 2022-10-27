using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] details = input.Split();

                Student student = new Student();

                student.FirstName = details[0];
                student.LastName = details[1];
                student.Age = details[2];
                student.HomeTown = details[3];

                students.Add(student);
            }

            string town = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.A} years old.");
                }
            }
        }
    }


    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }
    }
}
