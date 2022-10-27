using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogeVehiecle catalog = new CatalogeVehiecle();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] details = input.Split("/");

                string type = details[0];

                string brand = details[1];
                string model = details[2];

                if (type == "Car")
                {
                    Car car = new Car();
                    string horsePower = details[3];

                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;

                    catalog.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck();
                    string weight = details[3];

                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;

                    catalog.Trucks.Add(truck);
                }
            }

            catalog.Trucks = catalog.Trucks.OrderBy(x => x.Brand).ToList();
            catalog.Cars = catalog.Cars.OrderBy(x => x.Brand).ToList();

            if (catalog.Cars.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }                  
            }
            if (catalog.Trucks.Count != 0)
            { 
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }                    
            }
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }

    class CatalogeVehiecle
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
        public CatalogeVehiecle()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }

    }
}
