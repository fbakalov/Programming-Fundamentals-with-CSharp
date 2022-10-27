using System;
using System.Collections.Generic;

namespace _04._Students_2._0
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

                if (IsStudentExisting(students, details[0], details[1]))
                {
                    Student student = GetStudent(students, details[0], details[1]);

                    student.FirstName = details[0];
                    student.LastName = details[1];
                    student.Age = details[2];
                    student.HomeTown = details[3];
                }
                else
                {
                    Student student = new Student();

                    student.FirstName = details[0];
                    student.LastName = details[1];
                    student.Age = details[2];
                    student.HomeTown = details[3];

                    students.Add(student);
                }
            }

            string town = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static Student GetStudent(List<Student> students, string firstName, string secndName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == secndName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string secndName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == secndName)
                {
                    return true;
                }
            }

            return false;
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

