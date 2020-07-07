namespace P03.Raiding
{
    using System;

    public class InvalidHeroException : Exception
    {
        private const string EXC = "Invalid hero!";
        public InvalidHeroException()
            :base(EXC)
        {
        }

        public InvalidHeroException(string message)
            : base(message)
        {
        }
    }
}
