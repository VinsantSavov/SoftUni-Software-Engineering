using System;

namespace P01.Vehicles.Exceptions
{
    public class FuelExcpetion : Exception
    {
        private const string EXC = "Fuel must be a positive number";

        public FuelExcpetion()
            : base(EXC)
        {
        }

        public FuelExcpetion(string message)
            : base(message)
        {
        }
    }
}
