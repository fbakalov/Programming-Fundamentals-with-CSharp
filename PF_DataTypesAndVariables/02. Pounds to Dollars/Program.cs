using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pound = double.Parse(Console.ReadLine());
            decimal dollars = (decimal)pound * (decimal)1.31;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
