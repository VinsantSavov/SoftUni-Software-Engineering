using System;

namespace _5.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            for (int i = 0; i < line.Length; i++)
            {
                char digit = line[i];

                if (char.IsDigit(digit))
                {
                    Console.Write(digit);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < line.Length; i++)
            {
                char letter = line[i];

                if (char.IsLetter(letter))
                {
                    Console.Write(letter);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < line.Length; i++)
            {
                char symbol = line[i];

                if (char.IsLetter(symbol)==false&&char.IsDigit(symbol)==false)
                {
                    Console.Write(symbol);
                }
            }
            Console.WriteLine();
        }
    }
}
