using System;

namespace P01.Vehicles.Exceptions
{
    public class NotEnoughFuelException : Exception
    {
        private const string EXC = "{0} needs refueling";
        public NotEnoughFuelException()
            :base(EXC)
        {
        }

        public NotEnoughFuelException(string message)
            : base(message)
        {
        }
    }
}
