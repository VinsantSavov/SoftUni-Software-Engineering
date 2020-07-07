using System;
using System.Linq;

namespace _4.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> vat = n => n + n * 0.2;

            double[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => vat(n))
                .ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:F2}");
            }
        }
    }
}
