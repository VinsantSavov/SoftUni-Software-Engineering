using System;
using System.Linq;
using System.Collections.Generic;

namespace _2.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerCase = word.ToLower();
                if (!counts.ContainsKey(lowerCase))
                {
                    counts[lowerCase] = 1;
                }
                else
                {
                    counts[lowerCase]++;
                }
            }
            foreach (var kvp in counts)
            {
                if (kvp.Value % 2 != 0)
                {
                    Console.Write(kvp.Key + " ");
                }
            }

        }

    }
}
