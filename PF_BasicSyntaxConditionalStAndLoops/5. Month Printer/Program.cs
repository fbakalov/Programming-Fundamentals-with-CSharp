using System;

namespace _5._Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int mNum = int.Parse(Console.ReadLine());
            if (mNum == 1)
            {
                Console.WriteLine("January");
            }
            if (mNum == 2)
            {
                Console.WriteLine("February");
            }
            if (mNum == 3)
            {
                Console.WriteLine("March");
            }
            if (mNum == 4)
            {
                Console.WriteLine("April");
            }
            if (mNum == 5)
            {
                Console.WriteLine("May");
            }
            if (mNum == 6)
            {
                Console.WriteLine("June");
            }
            if (mNum == 7)
            {
                Console.WriteLine("July");
            }
            if (mNum == 8)
            {
                Console.WriteLine("August");
            }
            if (mNum == 9)
            {
                Console.WriteLine("September");
            }
            if (mNum == 10)
            {
                Console.WriteLine("October");
            }
            if (mNum == 11)
            {
                Console.WriteLine("November");
            }
            if (mNum == 12)
            {
                Console.WriteLine("December");
            }
            if (mNum < 1 || mNum > 12)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
