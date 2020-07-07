using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                string[] inputInfo = input.Split(", ").ToArray();
                string direction = inputInfo[0];
                string carNumber = inputInfo[1];

                if(direction == "IN")
                {
                    cars.Add(carNumber);
                }
                else if(direction == "OUT")
                {
                    cars.Remove(carNumber);
                }
            }

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
