using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> line = Console.ReadLine().Split().ToList();
            var random = new Random();

            for (int i = 0; i < line.Count; i++)
            {
                var ri = random.Next(0, line.Count);

                var tempValue = line[i];
                line[i] = line[ri];
                line[ri] = tempValue;
            }
            for (int i = 0; i < line.Count; i++)
            {
                Console.WriteLine(line[i]);
            }
        }
    }
}
