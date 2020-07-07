using MortalEngines.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace MortalEngines.IO
{
    public class ConsoleReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
