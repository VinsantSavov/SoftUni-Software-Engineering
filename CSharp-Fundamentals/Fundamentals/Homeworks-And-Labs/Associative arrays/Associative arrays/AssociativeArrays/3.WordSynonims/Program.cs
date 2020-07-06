using System;
using System.Collections.Generic;

namespace _3.WordSynonims
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordSynonym = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (wordSynonym.ContainsKey(word))
                {
                    wordSynonym[word].Add(synonym);
                }
                else
                {
                    wordSynonym.Add(word, new List<string>());
                    wordSynonym[word].Add(synonym);
                }
            }

            foreach (var word in wordSynonym)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            }
        }
    }
}
