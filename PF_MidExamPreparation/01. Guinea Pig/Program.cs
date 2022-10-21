using System;

namespace _01._Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine());
            decimal hay = decimal.Parse(Console.ReadLine());
            decimal cover = decimal.Parse(Console.ReadLine());
            decimal weight = decimal.Parse(Console.ReadLine());

            decimal coverTake = weight / 3;

            for (int day = 1; day <= 30; day++)
            {
                food -= 0.3m;

                if (day % 2 == 0)
                {
                    hay -= food * 0.05m;
                }

                if (day % 3 == 0)
                {
                    cover -= coverTake;
                }

                if (food <= 0 ||
                    hay <= 0 ||
                    cover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");
        }
    }
}
