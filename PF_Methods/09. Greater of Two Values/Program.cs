using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (input == "int")
            {
                Console.WriteLine(Compare(int.Parse(a), int.Parse(b)));
            }
            else if (input == "char")
            {
                Console.WriteLine(Compare(char.Parse(a), char.Parse(b)));
            }
            else if (input == "string")
            {
                Console.WriteLine(Compare(a, b));
            }
        }

        static int Compare(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                result = a;
            }
            else if (b > a)
            {
                result = b;
            }
            return result;
        }

        static char Compare(char a, char b)
        {
            char result = ' ';
            if (a > b)
            {
                result = a;
            }
            else if (b > a)
            {
                result = b;
            }
            return result;
        }

        static string Compare(string a, string b)
        {
            string result = null;
            int comparison = a.CompareTo(b);
            if (comparison > 0)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }
    }
}
