using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 0;
            while (true)
            {
                string input = Console.ReadLine();
                               
                if (input == "Start")
                {
                    break;
                }

                double coin = double.Parse(input);
                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    coin = 0;
                }
                money += coin;
            }

            while (true)
            {
                string input2 = Console.ReadLine();

                if (input2 == "Nuts")
                {
                    
                    if (money < 2.0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased nuts");
                        money -= 2.0;
                    }
                }
                else if (input2 == "Water")
                {
                    
                    if (money < 0.7)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased water");
                        money -= 0.7;
                    }
                }
                else if (input2 == "Crisps")
                {
                    
                    if (money < 1.5)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased crisps");
                        money -= 1.5;
                    }
                }
                else if (input2 == "Soda")
                {
                   
                    if (money < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased soda");
                        money -= 0.8;
                    }
                }
                else if (input2 == "Coke")
                {
                    
                    if (money < 1.0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased coke");
                        money -= 1.0;
                    }
                }
                else if (input2 == "End")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }

            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
