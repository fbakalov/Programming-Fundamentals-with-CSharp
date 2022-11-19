using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<product>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            Regex regex = new Regex(pattern);

            List<string> products = new List<string>();

            double whSum = 0;
            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    whSum += quantity * price;

                    products.Add(match.Groups["product"].Value);
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (string product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine($"Total money spend: {whSum:f2}");
        }
    }
}
