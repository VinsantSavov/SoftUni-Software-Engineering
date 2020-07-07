
namespace P06.SpeedRacing
{
    public class Car
    {
        public Car(string model)
        {
            this.Model = model;
        }
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
        }

        public string Model;
        public double FuelAmount;
        public double FuelConsumptionPerKilometer;
        public double TravelledDistance;

        public void Drive(double kilometers)
        {
            if(FuelAmount - FuelConsumptionPerKilometer * kilometers >= 0)
            {
                FuelAmount -= FuelConsumptionPerKilometer * kilometers;
                TravelledDistance += kilometers;
            }
            else
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.TravelledDistance}";
        }
    }
}
