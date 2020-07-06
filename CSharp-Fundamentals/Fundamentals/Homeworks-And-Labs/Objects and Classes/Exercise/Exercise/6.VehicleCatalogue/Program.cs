using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.VehicleCatalogue
{
    public class Car
    {
        public Car(string model, string color, int horsepower)
        {
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
    }

    public class Truck
    {
        public Truck(string model, string color, int horsepower)
        {
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
    }

    public class Catalogue
    {
        public Catalogue(List<Car> cars, List<Truck> trucks)
        {
            this.Cars = cars;
            this.Trucks = trucks;
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            double carSum = 0.0;
            double truckSum = 0.0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                string[] tokens = input.Split().ToArray();

                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                int horsepower = int.Parse(tokens[3]);

                if (type == "car")
                {
                    Car car = new Car(model, color, horsepower);
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(model, color, horsepower);
                    trucks.Add(truck);
                }
            }
            Catalogue catalogue = new Catalogue(cars, trucks);

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Close the Catalogue")
                {
                    break;
                }

                foreach (var car in catalogue.Cars)
                {
                    carSum += car.Horsepower;

                    if (input == car.Model)
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.Horsepower}");
                    }
                }
                foreach (var truck in catalogue.Trucks)
                {
                    truckSum += truck.Horsepower;

                    if (input == truck.Model)
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.Horsepower}");
                    }
                }
            }
            double carResult = carSum*1.0 / cars.Count;
            double truckResult = truckSum*1.0 / trucks.Count;

            Console.WriteLine($"Cars have average horsepower of: {carResult:F2}");
            Console.WriteLine($"Trucks have average horsepower of: {truckResult:F2}");
        }
    }
}
