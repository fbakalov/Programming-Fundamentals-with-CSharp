using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int number = i;
                for (int e = 0; e < i.ToString().Length; e++)
                {
                    sum += number % 10;
                    number /= 10;
                }
                
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
            
        }
    }
}
