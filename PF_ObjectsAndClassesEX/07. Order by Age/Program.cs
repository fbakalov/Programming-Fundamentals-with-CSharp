using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputTokens = input.Split();

                string name = inputTokens[0];
                string id = inputTokens[1];
                int age = int.Parse(inputTokens[2]);

                Person person = new Person();
                person.Name = name;
                person.ID = id;
                person.Age = age;

                foreach (var item in people)
                {
                    if (id == item.ID)
                    {
                        people.Remove(item);
                    }
                }

                people.Add(person);
            }

            List<Person> sortedPeople = people.OrderBy(x => x.Age).ToList();

            foreach (var item in sortedPeople)
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
