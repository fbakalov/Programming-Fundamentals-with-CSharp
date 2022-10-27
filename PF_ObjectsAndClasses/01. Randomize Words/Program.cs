using System;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
             

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randIndex = rnd.Next(0, input.Length);

                string currWord = input[i];
                string nextWord = input[randIndex];
                input[i] = nextWord;
                input[randIndex] = currWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
