using P01.Vehicles.Exceptions;
using System;

namespace P01.Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double carfuelQuantity = double.Parse(carInfo[1]);
            double carConsumption = double.Parse(carInfo[2]);
            double carTank = double.Parse(carInfo[3]);

            string[] truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckConsumption = double.Parse(truckInfo[2]);
            double truckTank = double.Parse(truckInfo[3]);

            string[] busInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double busFuelQuantity = double.Parse(busInfo[1]);
            double busConsumption = double.Parse(busInfo[2]);
            double busTank = double.Parse(busInfo[3]);

            Vehicle car = new Car(carfuelQuantity, carConsumption, carTank);
            Vehicle truck = new Truck(truckFuelQuantity, truckConsumption, truckTank);
            Bus bus = new Bus(busFuelQuantity, busConsumption, busTank);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string action = inputInfo[0];
                string type = inputInfo[1];

                if(action == "Drive")
                {
                    double distance = double.Parse(inputInfo[2]);

                    try
                    {
                        if(type == "Car")
                        {
                            Console.WriteLine(car.Drive(distance));
                        }
                        else if(type == "Truck")
                        {
                            Console.WriteLine(truck.Drive(distance));
                        }
                        else
                        {
                            Console.WriteLine(bus.Drive(distance));
                        }
                    }
                    catch(NotEnoughFuelException ex)
                    {
                        Console.WriteLine(ex.Message,type);
                    }
                }
                else if(action == "DriveEmpty")
                {
                    double distance = double.Parse(inputInfo[2]);

                    try
                    {
                        Console.WriteLine(bus.DriveEmpty(distance));
                    }
                    catch (NotEnoughFuelException ex)
                    {
                        Console.WriteLine(ex.Message, type);
                    }
                }
                else if(action == "Refuel")
                {
                    double liters = double.Parse(inputInfo[2]);

                    try
                    {
                        if (type == "Car")
                        {
                            car.Refuel(liters);
                        }
                        else if (type == "Truck")
                        {
                            truck.Refuel(liters);
                        }
                        else
                        {
                            bus.Refuel(liters);
                        }
                    }
                    catch(TankCapacityException ex)
                    {
                        Console.WriteLine(ex.Message,liters);
                    }
                    catch(FuelExcpetion fex)
                    {
                        Console.WriteLine(fex.Message);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
