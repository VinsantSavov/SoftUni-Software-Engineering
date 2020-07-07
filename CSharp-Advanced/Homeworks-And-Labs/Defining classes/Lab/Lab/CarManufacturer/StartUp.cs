using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "No more tires")
                {
                    break;
                }

                string[] inputInfo = input.Split();
                int firstYear = int.Parse(inputInfo[0]);
                double firstPressure = double.Parse(inputInfo[1]);
                int secondYear = int.Parse(inputInfo[2]);
                double secondPressure = double.Parse(inputInfo[3]);
                int thirdYear = int.Parse(inputInfo[4]);
                double thirdPressure = double.Parse(inputInfo[5]);
                int fourthYear = int.Parse(inputInfo[6]);
                double fourthPressure = double.Parse(inputInfo[7]);
                Tire[] tire = new Tire[4]{ 
                new Tire(firstYear, firstPressure),
                new Tire(secondYear,secondPressure),
                new Tire(thirdYear,thirdPressure),
                new Tire(fourthYear,fourthPressure),
                };

                tires.Add(tire);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Engines done")
                {
                    break;
                }

                string[] inputInfo = input.Split();
                int horsePower = int.Parse(inputInfo[0]);
                double cubicCapacity = double.Parse(inputInfo[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);

                engines.Add(engine);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Show special")
                {
                    break;
                }

                string[] inputInfo = input.Split();
                string make = inputInfo[0];
                string model = inputInfo[1];
                int year = int.Parse(inputInfo[2]);
                double fuelQuantity = double.Parse(inputInfo[3]);
                double fuelConsumption = double.Parse(inputInfo[4]);
                int engineIndex = int.Parse(inputInfo[5]);
                int tiresIndex = int.Parse(inputInfo[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(car);
            }

            for (int i = 0; i < cars.Count; i++)
            {
                double sumOfTirePressure = 0;
                foreach (var tirePressure in cars[i].Tires)
                {
                    sumOfTirePressure += tirePressure.Pressure;
                }

                if(cars[i].Year >= 2017 && cars[i].Engine.HorsePower > 330 && sumOfTirePressure >= 9 && sumOfTirePressure <= 10)
                {
                    cars[i].Drive(20);
                    Console.WriteLine($"Make: {cars[i].Make}");
                    Console.WriteLine($"Model: {cars[i].Model}");
                    Console.WriteLine($"Year: {cars[i].Year}");
                    Console.WriteLine($"HorsePowers: {cars[i].Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {cars[i].FuelQuantity}");
                }
            }
        }
    }
}
