using System;
using System.Collections.Generic;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] details = input.Split();

                string serialNum = details[0];
                string itemName = details[1];
                int itemQuantity = int.Parse(details[2]);
                double itemPrice = double.Parse(details[3]);

                Box box = new Box();
                box.SerialNumber = serialNum;
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;
                box.ItemQuantity = itemQuantity;
                box.BoxPrice = itemPrice * itemQuantity;

                boxes.Add(box);
            }

            double biggestPrice = 0;
            Box biggest = new Box();
            while(boxes.Count > 0)
            {
                foreach (Box item in boxes)
                {
                    if (item.BoxPrice > biggestPrice)
                    {
                        biggestPrice = item.BoxPrice;
                        biggest = item;
                    }
                }
                Console.WriteLine(biggest.SerialNumber);
                Console.WriteLine($"-- {biggest.Item.Name} - ${biggest.Item.Price:f2}: {biggest.ItemQuantity}");
                Console.WriteLine($"-- ${biggest.BoxPrice:f2}");
                boxes.Remove(biggest);
                biggestPrice = 0;
            }           
        }
    }

    class Item 
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public double BoxPrice { get; set; }
    }
}
