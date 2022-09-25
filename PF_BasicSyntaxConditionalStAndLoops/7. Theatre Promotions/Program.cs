using System;

namespace _7._Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string Day = Console.ReadLine();
            int Age = int.Parse(Console.ReadLine());
            int money = 0;

            if (Age < 0 || Age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                if (Day == "Weekday")
                {
                    if (Age >= 0 && Age <= 18)
                    {
                        money = 12;
                        
                    }
                    else if (Age > 18 && Age <= 64)
                    {
                        money = 18;
                    }
                    else if (Age > 64 && Age <= 122)
                    {
                        money = 12;
                    }
                }
                else if (Day == "Weekend")
                {
                    if (Age >= 0 && Age <= 18)
                    {
                        money = 15;
                    }
                    else if (Age > 18 && Age <= 64)
                    {
                        money = 20;
                    }
                    else if (Age > 64 && Age <= 122)
                    {
                        money = 15;
                    }
                }
                else if (Day == "Holiday")
                {
                    if (Age >= 0 && Age <= 18)
                    {
                        money = 5;
                    }
                    else if (Age > 18 && Age <= 64)
                    {
                        money = 12;
                    }
                    else if (Age > 64 && Age <= 122)
                    {
                        money = 10;
                    }
                }
                Console.WriteLine($"{money}");
            }
        }
    }
}
