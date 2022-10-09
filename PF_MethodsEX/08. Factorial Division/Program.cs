using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double result = CalcFactorial(a) / CalcFactorial(b);
            Console.WriteLine($"{result:f2}");
        }

        static double CalcFactorial(int n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        } 
    }
}
