using System;

namespace _6.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string ready = string.Empty;

            while (true)
            {
                for (int i = 0; i < line.Length-1; i++)
                {
                    char symbol = line[i];
                    char nextSym = line[i + 1];

                    if (symbol == nextSym)
                    {
                        ready += symbol;
                    }
                }
            }
        }
    }
}
