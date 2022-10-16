using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string comm;
            while ((comm = Console.ReadLine()) != "course start")
            {
                string[] commands = comm.Split(':');

                bool hasEx = false;

                if (commands[0] == "Add")
                {
                    string lesson = commands[1];
                    schedule = Add(schedule, lesson);
                }
                else if (commands[0] == "Insert")
                {
                    string lesson = commands[1];
                    int index = int.Parse(commands[2]);
                    schedule = Insert(schedule, lesson, index);
                }
                else if (commands[0] == "Remove")
                {
                    string lesson = commands[1];
                    schedule = Remove(schedule, lesson);
                }
                else if (commands[0] == "Swap")
                {
                    string lessonOne = commands[1];
                    string lessonTwo = commands[2];

                    schedule = Swap(schedule, lessonOne, lessonTwo);
                }
                else if (commands[0] == "Exercise")
                {
                    string lesson = commands[1];
                    hasEx = HasEx(schedule, lesson);
                    schedule = Exercise(schedule, lesson, hasEx);
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }

        private static bool HasEx(List<string> schedule, string lesson)
        {        
            int indexOfLess = schedule.IndexOf(lesson);
            if (indexOfLess < schedule.Count - 1)
            {
                string[] check = schedule[indexOfLess + 1].Split('-');

                int checkLength = check.Length;

                if (checkLength == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }         
            else
            {
                return false;
            }
        }

        private static List<string> Exercise(List<string> schedule, string lesson, bool hasEx)
        {        
            if (schedule.Contains(lesson) && hasEx == false)
            {
                int indexOfLess = schedule.IndexOf(lesson);
                schedule.Insert(indexOfLess + 1, $"{lesson}-Exercise");
                return schedule;
            }
            else if(schedule.Contains(lesson) == false)
            {
                schedule.Add(lesson);
                schedule.Add($"{lesson}-Exercise");
                return schedule;
            }
            return schedule;
        }

        private static List<string> Swap(List<string> schedule, string lessonOne, string lessonTwo)
        {
            bool oneHasEx = HasEx(schedule, lessonOne);
            bool twoHasEx = HasEx(schedule, lessonTwo);

            int indexOfOne = schedule.IndexOf(lessonOne);
            int indexOfTwo = schedule.IndexOf(lessonTwo);

            if (schedule.Contains(lessonOne) && schedule.Contains(lessonTwo) && 
                oneHasEx == false && twoHasEx == false)
            {   
                schedule[indexOfOne] = lessonTwo;
                schedule[indexOfTwo] = lessonOne;
                return schedule;
            }
            else if (schedule.Contains(lessonOne) && schedule.Contains(lessonTwo) && 
                oneHasEx == true && twoHasEx == false)
            {
                schedule[indexOfOne] = lessonTwo;
                schedule[indexOfTwo] = lessonOne;
                schedule.Remove($"{lessonOne}-Exercise");
                schedule.Insert(indexOfTwo + 1, $"{lessonOne}-Exercise");

                return schedule;
            }
            else if (schedule.Contains(lessonOne) && schedule.Contains(lessonTwo) &&
                oneHasEx == false && twoHasEx == true)
            {
                schedule[indexOfOne] = lessonTwo;
                schedule[indexOfTwo] = lessonOne;
                schedule.Remove($"{lessonTwo}-Exercise");
                schedule.Insert(indexOfOne + 1, $"{lessonTwo}-Exercise");
                
                return schedule;
            }
            else if (schedule.Contains(lessonOne) && schedule.Contains(lessonTwo) &&
                oneHasEx == true && twoHasEx == true)
            {
                schedule[indexOfOne] = lessonTwo;
                schedule[indexOfTwo] = lessonOne;
                schedule.Remove($"{lessonOne}-Exercise");
                schedule.Remove($"{lessonTwo}-Exercise");
                schedule.Insert(indexOfTwo + 1, $"{lessonTwo}-Exercise");
                schedule.Insert(indexOfOne + 1, $"{lessonOne}-Exercise");

                return schedule;
            }
            else 
            {                              
                return schedule;
            }
        }

        private static List<string> Remove(List<string> schedule, string lesson)
        {
            if (schedule.Contains(lesson))
            {
                schedule.Remove(lesson);
                return schedule;
            }
            else
            {              
                return schedule;
            }
        }

        private static List<string> Insert(List<string> schedule, string lesson, int index)
        {
            if (schedule.Contains(lesson))
            {
                return schedule;
            }
            else
            {
                schedule.Insert(index, lesson);
                return schedule;
            }
        }

        private static List<string> Add(List<string> schedule, string lesson)
        {
            if (schedule.Contains(lesson))
            {
                return schedule;
            }
            else
            {
                schedule.Add(lesson);
                return schedule;
            }
        }
    }
}
