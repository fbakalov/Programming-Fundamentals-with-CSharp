using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nSnows = int.Parse(Console.ReadLine());

            var maxSS = 0;
            var maxST = 0;
            var maxSQ = 0;
            BigInteger maxSV = 0;
            for (int i = 1; i <= nSnows; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                int caclced = (snowballSnow / snowballTime);
                BigInteger snowballValue = BigInteger.Pow(caclced, snowballQuality);

                if (maxSV < snowballValue)
                {
                    maxSV = snowballValue;
                    maxSS = snowballSnow;
                    maxST = snowballTime;
                    maxSQ = snowballQuality;
                }
            }
            Console.WriteLine($"{maxSS} : {maxST} = {maxSV} ({maxSQ})");
        }
    }
}
