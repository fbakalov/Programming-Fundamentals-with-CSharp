using System;

namespace _01.Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            double km = (double)m / 1000;
            Console.WriteLine($"{km:f2}");
        }
    }
}
