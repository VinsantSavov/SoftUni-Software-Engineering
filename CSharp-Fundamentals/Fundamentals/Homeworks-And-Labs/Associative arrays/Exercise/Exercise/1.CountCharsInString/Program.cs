using System;
using System.Collections.Generic;

namespace _1.CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var c in text)
            {
                if(c != ' ')
                {
                    if (counts.ContainsKey(c))
                    {
                        counts[c]++;
                    }
                    else
                    {
                        counts.Add(c, 1);
                    }
                }
            }

            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
