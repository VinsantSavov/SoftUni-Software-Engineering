using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, int>();
            using var reader = new StreamReader("words.txt");
            using var readerText = new StreamReader("text.txt");
            using var writer = new StreamWriter("output.txt");


            string[] words = reader.ReadLine().Split().ToArray();
            String pattern = @"[a-zA-Z']+";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < words.Length; i++)
            {
                if (!dictionary.ContainsKey(words[i]))
                {
                    dictionary.Add(words[i], 0);
                }
            }

            while (true)
            {
                string line = readerText.ReadLine();

                if (line == null)
                {
                    break;
                }

                line = line.ToLower();

                foreach (Match match in regex.Matches(line))
                {
                    if (dictionary.ContainsKey(match.Value))
                    {
                        dictionary[match.Value]++;
                    }
                }
            }

            dictionary = dictionary.OrderByDescending(c => c.Value).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in dictionary)
            {
                writer.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
