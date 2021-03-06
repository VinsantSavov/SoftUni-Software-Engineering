﻿using P01.Vehicles.Exceptions;

namespace P01.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override string Drive(double distance)
        {
            if(this.FuelQuantity < this.FuelConsumption * distance + distance * 1.6)
            {
                throw new NotEnoughFuelException();
            }

            this.FuelQuantity -= this.FuelConsumption * distance + distance * 1.6;
            return $"Truck travelled {distance} km";
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new FuelExcpetion();
            }
            if (this.FuelQuantity + (liters * 0.95) >= this.TankCapacity)
            {
                throw new TankCapacityException();
            }

            this.FuelQuantity += (liters * 0.95);
        }
    }
}
