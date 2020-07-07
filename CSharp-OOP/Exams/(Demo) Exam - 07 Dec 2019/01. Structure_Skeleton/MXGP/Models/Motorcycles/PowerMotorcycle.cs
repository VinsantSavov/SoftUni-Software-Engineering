using MXGP.Utilities.Messages;
using System;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        private const int CUBIC_CENTIMETERS = 450;
        private const int MINIMUM_HORSEPOWER = 70;
        private const int MAXIMUM_HORSEPOWER = 100;

        private int horsePower;

        public PowerMotorcycle(string model, int horsePower)
            : base(model, horsePower, CUBIC_CENTIMETERS)
        {
            this.HorsePower = horsePower;
        }

        public override int HorsePower
        {
            get => this.horsePower;

            protected set
            {
                if (value < MINIMUM_HORSEPOWER || value > MAXIMUM_HORSEPOWER)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidHorsePower, value));
                }

                this.horsePower = value;
            }
        }
    }
}
