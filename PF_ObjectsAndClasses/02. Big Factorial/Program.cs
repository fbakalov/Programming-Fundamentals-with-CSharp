using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;

            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
