using System;

namespace P04.WildFarm.Exceptions
{
    public class NotValidFoodException : Exception
    {
        public NotValidFoodException()
        {
        }

        public NotValidFoodException(string message)
            : base(message)
        {
        }
    }
}
