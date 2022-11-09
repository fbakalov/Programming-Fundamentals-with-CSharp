using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineStr = Console.ReadLine()
                .Split();

            string endReslt = "";
            for (int i = 0; i < lineStr.Length; i++)
            {
                for (int j = 0; j < lineStr[i].Length; j++)
                {
                    endReslt += lineStr[i];
                }
            }

            Console.WriteLine(endReslt);
        }
    }
}
