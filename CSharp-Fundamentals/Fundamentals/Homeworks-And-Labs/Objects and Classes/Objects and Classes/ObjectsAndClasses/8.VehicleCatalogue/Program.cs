using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.VehicleCatalogue
{
    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    public class Catalogue
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                List<string> tokens = input.Split("/").ToList();
                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];

                if(type == "Car")
                {
                    int horsePower = int.Parse(tokens[3]);
                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    };
                    cars.Add(car);
                }
                else if(type == "Truck")
                {
                    int weight = int.Parse(tokens[3]);
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };
                    trucks.Add(truck);
                }
            }
            cars = cars.OrderBy(x => x.Brand).ToList();
            trucks = trucks.OrderBy(x => x.Brand).ToList();

            Catalogue catalogue = new Catalogue()
            {
                Cars = cars,
                Trucks = trucks
            };

            Console.WriteLine("Cars:");
            foreach (var carsInCatalogue in catalogue.Cars)
            {
                Console.WriteLine($"{carsInCatalogue.Brand}: {carsInCatalogue.Model} - {carsInCatalogue.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var trucksInCatalogue in catalogue.Trucks)
            {
                Console.WriteLine($"{trucksInCatalogue.Brand}: {trucksInCatalogue.Model} - {trucksInCatalogue.Weight}kg");
            }
        }
    }
}
