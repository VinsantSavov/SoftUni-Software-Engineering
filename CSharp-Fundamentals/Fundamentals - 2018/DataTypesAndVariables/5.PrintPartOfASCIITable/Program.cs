using System;

namespace _5.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());

            for(int i = first; i <= last; i++)
            {
                char symbol = (char)i;
                Console.Write($"{symbol} ");
            }
        }
    }
}
