using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int input = int.Parse(Console.ReadLine());

            if (input > 7 || input < 1)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            Console.WriteLine(array[input - 1]);
        }
    }
}
