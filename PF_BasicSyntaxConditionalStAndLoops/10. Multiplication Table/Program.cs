using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = 1;
            int output = 0;
            while (multiplier <= 10)
            {
                output = n * multiplier;
                Console.WriteLine($"{n} X {multiplier} = {output}");
                multiplier++;
            }
        }
    }
}
