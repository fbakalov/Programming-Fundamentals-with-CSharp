using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string toBeRepeated = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            
            Console.WriteLine(RepeatStr(toBeRepeated, n));
        }

        static string RepeatStr(string str, int count)
        {
            string result =  "";

            for (int i = 1; i <= count; i++)
            {
                result += str;
            }

            return result;
        }
    }
}
