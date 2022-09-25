using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int littrsIn = 0;
            for (int i = 1; i <= n; i++)
            {
                int pour = int.Parse(Console.ReadLine());
                littrsIn += pour;
                if (littrsIn > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    littrsIn -= pour;
                }
            }
            Console.WriteLine(littrsIn);
        }
    }
}
