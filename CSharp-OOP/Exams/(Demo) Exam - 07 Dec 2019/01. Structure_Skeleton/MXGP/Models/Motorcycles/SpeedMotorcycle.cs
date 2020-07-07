using MXGP.Utilities.Messages;
using System;

namespace MXGP.Models.Motorcycles
{
    public class SpeedMotorcycle : Motorcycle
    {
        private const int CUBIC_CENTIMETERS = 125;
        private const int MINIMUM_HORSEPOWER = 50;
        private const int MAXIMUM_HORSEPOWER = 69;

        private int horsePower;

        public SpeedMotorcycle(string model, int horsePower)
            : base(model, horsePower, CUBIC_CENTIMETERS)
        {
        }

        public override int HorsePower 
        {
            get => this.horsePower;

            protected set
            {
                if(value < MINIMUM_HORSEPOWER || value > MAXIMUM_HORSEPOWER)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidHorsePower, value));
                }

                this.horsePower = value;
            }
        }
    }
}
