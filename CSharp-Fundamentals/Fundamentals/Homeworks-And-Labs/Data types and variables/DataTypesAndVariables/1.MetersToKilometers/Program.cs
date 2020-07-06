using System;

namespace _1.MetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double kilometers = meters / 1000;

            Console.WriteLine($"{kilometers:F2}");
            
        }
    }
}
