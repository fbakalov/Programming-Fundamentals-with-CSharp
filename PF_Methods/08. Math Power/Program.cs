using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(number, power));
        }

        static double Power(double number, int power)
        {
            double result = Math.Pow(number, power);
            return result;
        }

    }
}
