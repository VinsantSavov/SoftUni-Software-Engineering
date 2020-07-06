using System;
using System.Linq;
using System.Collections.Generic;

namespace _5.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToList();

            foreach (var kvp in words)
            {
                Console.WriteLine(kvp);
            }
        }
    }
}
