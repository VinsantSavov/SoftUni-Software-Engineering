using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int enginesCount = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < enginesCount; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = info[0];
                int power = int.Parse(info[1]);
                Engine engine;
                
                if(info.Length == 4)
                {
                    int displacement = int.Parse(info[2]);
                    engine = new Engine(model, power, displacement, info[3]);
                }
                else if(info.Length == 3)
                {
                    int displacement = 0;
                    if(Int32.TryParse(info[2], out displacement))
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, info[2]);
                    }
                }
                else
                {
                    engine = new Engine(model, power);
                }

                engines.Add(engine);
            }

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] info = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = info[0];
                string engineModel = info[1];
                Engine engine = engines.Find(e => e.Model == engineModel);
                Car car;
                
                if(info.Length == 4)
                {
                    int weight = int.Parse(info[2]);
                    string color = info[3];
                    car = new Car(model, engine, weight, color);
                }
                else if(info.Length == 3)
                {
                    int weight = 0;

                    if(Int32.TryParse(info[2], out weight))
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        car = new Car(model, engine, info[2]);
                    }
                }
                else
                {
                    car = new Car(model, engine);
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
