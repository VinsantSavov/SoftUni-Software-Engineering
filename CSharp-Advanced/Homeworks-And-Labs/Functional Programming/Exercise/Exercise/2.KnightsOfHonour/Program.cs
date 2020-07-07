using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.KnightsOfHonour
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Action<string> sirName = n => Console.WriteLine($"Sir {n}");

            foreach (var name in names)
            {
                sirName(name);
            }
        }
    }
}
