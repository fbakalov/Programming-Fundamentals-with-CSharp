using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quant = int.Parse(Console.ReadLine());
            CalculatePrice(product, quant);
        }

        static void CalculatePrice(string prType, int quat)
        {   
            double price = 0;
            if (prType == "coffee")
            {
                price = quat * 1.50;
            }
            else if (prType == "water")
            {
                price = quat * 1;
            }
            else if (prType == "coke")
            {
                price = quat * 1.40;
            }
            else if (prType == "snacks")
            {
                price = quat * 2;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
