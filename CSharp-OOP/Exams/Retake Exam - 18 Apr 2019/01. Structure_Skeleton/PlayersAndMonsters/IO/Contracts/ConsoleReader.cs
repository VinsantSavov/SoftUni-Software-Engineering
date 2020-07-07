using System;

namespace PlayersAndMonsters.IO.Contracts
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
