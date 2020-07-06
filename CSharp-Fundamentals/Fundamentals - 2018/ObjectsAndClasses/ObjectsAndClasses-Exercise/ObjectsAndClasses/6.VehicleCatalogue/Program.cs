using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.VehicleCatalogue
{
    class Program
    {
        class Car
        {
            public Car(string model,string color,int horsepower)
            {
                Model = model;
                Color = color;
                Horsepower = horsepower;
            }

            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }
        }

        class Truck
        {
            public Truck(string model, string color, int horsepower)
            {
                Model = model;
                Color = color;
                Horsepower = horsepower;
            }

            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }
        }

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string type = string.Empty;
            double avHorseCar = 0;
            double avHorseTruck = 0;

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if(input[0] == "End")
                {
                    break;
                }

                type = input[0];
                string model = input[1];
                string color = input[2];
                int horsepower = int.Parse(input[3]);

                if(type == "car")
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
            while (true)
            {
                string[] line = Console.ReadLine().Split();
                string modelOne = line[0];

                if(modelOne == "Close")
                {
                    break;
                }

                if (cars.Any(x => x.Model == modelOne))
                {
                    int indexCar = cars.FindIndex(x => x.Model == modelOne);
                    foreach (var kvp in cars)
                    {
                        Console.WriteLine($"Type: {type}");
                        Console.WriteLine($"Model: {kvp.Model}");
                        Console.WriteLine($"Color: {kvp.Color}");
                        Console.WriteLine($"Horsepower: {kvp.Horsepower}");
                        avHorseCar += kvp.Horsepower;
                    }
                }
                else if(trucks.Any(x => x.Model == modelOne))
                {
                    foreach (var kvp in trucks)
                    {
                        Console.WriteLine($"Type: {type}");
                        Console.WriteLine($"Model: {kvp.Model}");
                        Console.WriteLine($"Color: {kvp.Color}");
                        Console.WriteLine($"Horsepower: {kvp.Horsepower}");
                        avHorseTruck += kvp.Horsepower;
                    }
                }
            }
            Console.WriteLine($"Cars have average horsepower of: {avHorseCar/cars.Count}");
            Console.WriteLine($"Trucks have average horsepower of: {avHorseTruck/trucks.Count}");
        }
    }
}
