using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            string inputStr;
            while ((inputStr = Console.ReadLine()) != "buy")
            {
                string[] comnArgs = inputStr.Split();

                string name = comnArgs[0];
                double price = double.Parse(comnArgs[1]);
                int quantity = int.Parse(comnArgs[2]);               

                bool exists = false;
                foreach (var item in products)
                {
                    if (item.Name == name)
                    {
                        item.Price = price;
                        item.Quantity += quantity;
                        exists = true;
                    }
                }

                if (!exists)
                {
                    Product product = new Product();
                    product.Name = name;
                    product.Price = price;
                    product.Quantity = quantity;

                    products.Add(product);
                }
            }

            foreach (var item in products)
            {
                double whPrice = item.Price * item.Quantity;
                Console.WriteLine($"{item.Name} -> {whPrice:f2}");
            }
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
