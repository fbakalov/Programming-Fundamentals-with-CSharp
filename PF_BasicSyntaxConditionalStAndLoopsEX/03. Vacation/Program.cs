using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double priceNoDis = 0;
            double discount = 0;
            double CalcedDis = 0;
            double totalPrice = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    priceNoDis = count * 8.45;
                }
                else if (day == "Saturday")
                {
                    priceNoDis = count * 9.80;
                }
                else if (day == "Sunday")
                {
                    priceNoDis = count * 10.46;
                }

                if (count >= 30)
                {
                    discount = 0.15;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    priceNoDis = count * 10.90;

                    if (count >= 100)
                    {
                        priceNoDis = priceNoDis - (10 * 10.90);
                    }
                }
                else if (day == "Saturday")
                {
                    priceNoDis = count * 15.60;

                    if (count >= 100)
                    {
                        priceNoDis = priceNoDis - (10 * 15.60);
                    }
                }
                else if (day == "Sunday")
                {
                    priceNoDis = count * 16;

                    if (count >= 100)
                    {
                        priceNoDis = priceNoDis - (10 * 16);
                    }
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    priceNoDis = count * 15;
                }
                else if (day == "Saturday")
                {
                    priceNoDis = count * 20;
                }
                else if (day == "Sunday")
                {
                    priceNoDis = count * 22.50;
                }

                if (count >= 10 && count <= 20)
                {
                    discount = 0.05;
                }
            }

            CalcedDis = priceNoDis * discount;
            totalPrice = priceNoDis - CalcedDis;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
