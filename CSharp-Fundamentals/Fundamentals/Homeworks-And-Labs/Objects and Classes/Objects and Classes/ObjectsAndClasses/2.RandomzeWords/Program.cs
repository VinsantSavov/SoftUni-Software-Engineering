using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.RandomzeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Random rnd = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                string temp = words[i];
                int n = rnd.Next(words.Count);
                words[i] = words[n];
                words[n] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine,words));
        }
    }
}
