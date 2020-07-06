using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.OddOccurances
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            //List<string> ordered = new List<string>();

            foreach (var word in words)
            {
                string wordLower = word.ToLower();
                if (counts.ContainsKey(wordLower))
                {
                    counts[wordLower]++;
                }
                else
                {
                    counts.Add(wordLower, 1);
                }

            }
            foreach (var word in counts)
            {
                if(word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
            /*foreach (var word in ordered)
            {
                Console.Write(word + " ");
            }*/
        }
    }
}
