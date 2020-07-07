using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.RawData
{
    public class InformationParser
    {
        public void Parse(string input, List<Car> cars)
        {
            string[] inputInfo = input.Split().ToArray();
            string model = inputInfo[0];
            int engineSpeed = int.Parse(inputInfo[1]);
            int enginePower = int.Parse(inputInfo[2]);
            int cargoWeight = int.Parse(inputInfo[3]);
            string cargoType = inputInfo[4];
            double tire1Pressure = double.Parse(inputInfo[5]);
            int tire1Age = int.Parse(inputInfo[6]);
            double tire2Pressure = double.Parse(inputInfo[7]);
            int tire2Age = int.Parse(inputInfo[8]);
            double tire3Pressure = double.Parse(inputInfo[9]);
            int tire3Age = int.Parse(inputInfo[10]);
            double tire4Pressure = double.Parse(inputInfo[11]);
            int tire4Age = int.Parse(inputInfo[12]);

            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            Tire[] tires = new Tire[4];
            Tire tire1 = new Tire(tire1Pressure, tire1Age);
            Tire tire2 = new Tire(tire2Pressure, tire2Age);
            Tire tire3 = new Tire(tire3Pressure, tire3Age);
            Tire tire4 = new Tire(tire4Pressure, tire4Age);
            tires[0] = tire1;
            tires[1] = tire2;
            tires[2] = tire3;
            tires[3] = tire4;

            Car car = new Car(model, engine, cargo, tires);
            cars.Add(car);
        }
    }
}
