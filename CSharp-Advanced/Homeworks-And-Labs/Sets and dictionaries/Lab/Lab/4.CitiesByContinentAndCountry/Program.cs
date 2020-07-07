using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }

                continents[continent][country].Add(city);
            }

            foreach (var kvp in continents)
            {
                Console.WriteLine($"{kvp.Key}: ");

                foreach (var (key, value) in kvp.Value)
                {
                    Console.Write($"  {key} -> ");
                    Console.WriteLine(string.Join(", ", value));
                }
            }
        }
    }
}
