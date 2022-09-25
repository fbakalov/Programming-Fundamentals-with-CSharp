using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var fiftyPerc = n * 0.50;
            int targetsPKD = 0;
            while (n >= m)
            {              
                if (n == fiftyPerc)
                {
                    if (y > 0)
                    n /= y;
                    if (n < m)
                    {
                        break;
                    }
                }
                n -= m;
                targetsPKD++;
            }
            Console.WriteLine(n);
            Console.WriteLine(targetsPKD);
        }
    }
}
