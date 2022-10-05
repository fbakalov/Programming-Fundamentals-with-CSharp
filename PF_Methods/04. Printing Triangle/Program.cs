﻿using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                PrintLine(1, i);
            }
            for (int i = input - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int finish)
        {
            for (int i = start; i <= finish; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
