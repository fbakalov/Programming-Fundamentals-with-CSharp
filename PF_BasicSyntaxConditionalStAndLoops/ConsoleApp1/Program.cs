using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            m += 30;
            if (m > 59)
            {
                h++;
                m -= 60;
            }
            if (h > 23)
            {
                h -= 24;
            }
            Console.WriteLine($"{h}:{m:d2}");
        }
    }
}
