namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DEFAULT_CONSUMPTION = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower { get; protected set; }
        public double Fuel { get; protected set; }

        public virtual double FuelConsumption => DEFAULT_CONSUMPTION;


        public virtual void Drive(double kilometers)
        {

            this.Fuel -= kilometers * FuelConsumption;
        }
    }
}
