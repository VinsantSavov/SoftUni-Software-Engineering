using System;
using System.Collections.Generic;

namespace _5.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var symbolCount = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!symbolCount.ContainsKey(text[i]))
                {
                    symbolCount.Add(text[i], 0);
                }

                symbolCount[text[i]]++;
            }

            foreach (var kvp in symbolCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
