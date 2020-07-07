using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<Car> cars = new HashSet<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerKilometer = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                string[] inputInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = inputInfo[1];
                double kilometers = double.Parse(inputInfo[2]);

                if (cars.Any(c=>c.Model == carModel))
                {
                    foreach (Car car in cars)
                    {
                        if(car.Model == carModel)
                        {
                            car.Drive(kilometers);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
