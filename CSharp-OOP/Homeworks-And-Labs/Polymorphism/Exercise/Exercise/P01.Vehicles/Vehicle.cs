namespace P01.Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity 
        { 
            get
            {
                return this.fuelQuantity;
            }
            protected set
            {
                this.fuelQuantity = value;
            } 
        }
        public double FuelConsumption { get; protected set; }
        public double TankCapacity 
        {
            get
            {
                return this.tankCapacity;
            }
            private set
            {
                if(this.fuelQuantity > value)
                {
                    this.fuelQuantity = 0;
                }

                this.tankCapacity = value;
            }
        }

        public abstract string Drive(double distance);
        public abstract void Refuel(double liters);
    }
}
