using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumFact = 0;

            int numCopy = n;
            while (numCopy > 0)
            {
                int fact = 1;
                int lastDigit = numCopy % 10;
                for (int i = 1; i <= lastDigit; i++)
                {
                    fact *= i;
                }
                sumFact += fact;
                numCopy /= 10;                
            }
            if (sumFact == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
