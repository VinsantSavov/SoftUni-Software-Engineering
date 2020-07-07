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
            string[] words = File.ReadAllLines("words.txt");
            string[] lines = File.ReadAllLines("text.txt");
            var wordsCount = new Dictionary<string, int>();

            string pattern = @"[A-Za-z']+";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < words.Length; i++)
            {
                string lowerCase = words[i].ToLower();

                if (!wordsCount.ContainsKey(lowerCase))
                {
                    wordsCount.Add(lowerCase, 0);
                }
            }

            foreach (var line in lines)
            {
                foreach (Match match in regex.Matches(line))
                {
                    string word = match.Value.ToLower();
                    if (wordsCount.ContainsKey(word))
                    {
                        wordsCount[word]++;
                    }
                }
            }

            foreach (var kvp in wordsCount)
            {
                File.AppendAllText("actualResults.txt", $"{kvp.Key} - {kvp.Value}");
                File.AppendAllText("actualResults.txt", Environment.NewLine);
            }

            wordsCount = wordsCount.OrderByDescending(x => x.Value).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in wordsCount)
            {
                File.AppendAllText("expectedResult.txt", $"{kvp.Key} - {kvp.Value}");
                File.AppendAllText("expectedResult.txt", Environment.NewLine);
            }
        }
    }
}
