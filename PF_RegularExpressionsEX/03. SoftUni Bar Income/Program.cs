using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<name>[A-Z][a-z]+)%[^%\$\|\.]*\<(?<product>\w+)\>[^%\$\|\.]*\|(?<count>\d+)\|[^%\$\|\.\d]*(?<price>\d+(\.\d+)?)\$[^%\$\|\.]*$";
            Regex regex = new Regex(pattern);

            double totalIncome = 0;
            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double priceForOne = double.Parse(match.Groups["price"].Value);

                    double wholePrice = priceForOne * count;
                    Console.WriteLine($"{name}: {product} - {wholePrice:f2}");

                    totalIncome += wholePrice;
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
