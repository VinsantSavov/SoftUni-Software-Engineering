using System;

namespace P07.MilitaryElite.Exceptions
{
    public class InvalidMissionException : Exception
    {
        private const string DEF_EXC = "Invalid mission!";

        public InvalidMissionException()
            :base(DEF_EXC)
        {
        }

        public InvalidMissionException(string message)
            : base(message)
        {
        }
    }
}
