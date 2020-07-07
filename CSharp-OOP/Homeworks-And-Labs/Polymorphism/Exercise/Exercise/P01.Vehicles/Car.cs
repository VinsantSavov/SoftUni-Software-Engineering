using P01.Vehicles.Exceptions;

namespace P01.Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override string Drive(double distance)
        {
            if(this.FuelQuantity < this.FuelConsumption * distance + distance * 0.9)
            {
                throw new NotEnoughFuelException();
            }

            this.FuelQuantity -= this.FuelConsumption * distance + distance * 0.9;
            return $"Car travelled {distance} km";
        }

        public override void Refuel(double liters)
        {
            if(liters <= 0)
            {
                throw new FuelExcpetion();
            } 
            if(this.FuelQuantity + liters >= this.TankCapacity)
            {
                throw new TankCapacityException();
            }
            this.FuelQuantity += liters;
        }
    }
}
