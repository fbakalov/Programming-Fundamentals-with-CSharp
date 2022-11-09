using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ");

            string text = Console.ReadLine();

            foreach (var bandWord in bannedWords)
            {
                if (text.Contains(bandWord))
                {
                    text = text.Replace(bandWord, new string('*', bandWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
