using System;

namespace P07.MilitaryElite.Exceptions
{
    public class InvalidCorpsException : Exception
    {
        private const string DEF_EXC = "Invalid corps!";
        public InvalidCorpsException()
            : base(DEF_EXC)
        {

        }

        public InvalidCorpsException(string message) 
            : base(message)
        {
        }
    }
}
