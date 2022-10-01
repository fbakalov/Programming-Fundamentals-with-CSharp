using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWagons = int.Parse(Console.ReadLine());

            int[] passangers = new int[numOfWagons];

            for (int i = 0; i < numOfWagons; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < numOfWagons; i++)
            {
                Console.Write(passangers[i] + " ");
                sum += passangers[i];
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
