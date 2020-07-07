using System;

namespace P01.Vehicles.Exceptions
{
    public class TankCapacityException : Exception
    {
        private const string EXC = "Cannot fit {0} fuel in the tank";

        public TankCapacityException()
            :base(EXC)
        {
        }

        public TankCapacityException(string message) 
            : base(message)
        {
        }
    }
}
