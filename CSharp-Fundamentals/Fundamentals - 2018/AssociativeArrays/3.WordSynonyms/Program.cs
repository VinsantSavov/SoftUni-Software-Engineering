using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for(int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if(!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }
                words[word].Add(synonym);
            }
            foreach (var kvp in words)
            {
                string word = kvp.Key;
                List<string> syn = kvp.Value;
                Console.WriteLine($"{word} - {string.Join(", ",syn)}");
            }
        }
    }
}
