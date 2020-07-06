using System;
using System.Linq;
using System.Collections.Generic;

namespace _1.CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < words.Count; i++)
            {
                string word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (!chars.ContainsKey(word[j]))
                    {
                        chars[word[j]] = 1;
                    }
                    else
                    {
                        chars[word[j]]++;
                    }
                }
            }
            foreach (var kvp in chars)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            

        }
    }
}
