using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                string phrase = ChoseRandWord(phrases);
                string evennt = ChoseRandWord(events);
                string author = ChoseRandWord(authors);
                string city = ChoseRandWord(cities);

                Console.WriteLine($"{phrase} {evennt} {author} - {city}.");
            }          
        }

        static string ChoseRandWord(string[] words)
        {
            Random rnd = new Random();
            int randIndex = rnd.Next(0, words.Length);

            return words[randIndex];
        }
    }  
}
