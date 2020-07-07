using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            InformationParser parser = new InformationParser();

            for (int i = 0; i < carsCount; i++)
            {
                string input = Console.ReadLine();
                parser.Parse(input, cars);
            }

            string command = Console.ReadLine();

            if(command == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == command)
                    {
                        foreach (var tire in car.Tires)
                        {
                            if(tire.Pressure < 1)
                            {
                                Console.WriteLine(car.Model);
                                break;
                            }
                        }
                    }
                }
            }
            else if(command == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == command)
                    {
                        if(car.Engine.Power > 250)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                }
            }
        }
    }
}
