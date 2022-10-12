using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int products = int.Parse(Console.ReadLine());

            List<string> listOfProducts= new List<string>();

            for (int i = 0; i < products; i++)
            {
                listOfProducts.Add(Console.ReadLine());
            }
            listOfProducts.Sort();

            for (int i = 0; i < listOfProducts.Count; i++)
            {
                Console.WriteLine(i + 1 + "." + listOfProducts[i]);
            }
        }
    }
}
