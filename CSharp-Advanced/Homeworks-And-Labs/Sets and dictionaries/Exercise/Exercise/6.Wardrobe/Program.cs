using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new [] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = input[0];

                if (!dictionary.ContainsKey(color))
                {
                    dictionary.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < input.Length; j++)
                {
                    string garment = input[j];

                    if (!dictionary[color].ContainsKey(garment))
                    {
                        dictionary[color].Add(garment, 0);
                    }
                    dictionary[color][garment]++;
                }
            }

            string[] neededItem = Console.ReadLine().Split().ToArray();

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var dressCount in kvp.Value)
                {
                    if(kvp.Key == neededItem[0] && dressCount.Key == neededItem[1])
                    {
                        Console.WriteLine($"* {dressCount.Key} - {dressCount.Value} (found!)");
                        continue;
                    }

                    Console.WriteLine($"* {dressCount.Key} - {dressCount.Value}");
                }
            }
        }
    }
}
