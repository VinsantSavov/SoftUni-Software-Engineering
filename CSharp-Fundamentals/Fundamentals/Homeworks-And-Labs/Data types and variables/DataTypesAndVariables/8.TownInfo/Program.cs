using System;

namespace _8.TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {name} has population of {population} and area {area} square km.");
        }
    }
}
