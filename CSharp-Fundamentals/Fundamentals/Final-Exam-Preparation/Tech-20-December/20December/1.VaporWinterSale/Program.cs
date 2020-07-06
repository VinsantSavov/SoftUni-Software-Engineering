using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1.VaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();

            Dictionary<string, double> gamesPrices = new Dictionary<string, double>();
            Dictionary<string, string> gamesDLCs = new Dictionary<string, string>();
            Regex regex = new Regex(@"[A-Za-z0-9 ]");

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].Contains("-"))
                {
                    string[] tokens = input[i].Split('-');
                    Match match = regex.Match(tokens[0]);

                    if (match.Success)
                    {
                        gamesPrices.Add(tokens[0], double.Parse(tokens[1]));
                    }
                }
                else if (input[i].Contains(":"))
                {
                    string[] tokens = input[i].Split(':');

                    if (gamesPrices.ContainsKey(tokens[0]))
                    {
                        gamesDLCs.Add(tokens[0], tokens[1]);
                        double newPrice = gamesPrices[tokens[0]] + gamesPrices[tokens[0]] * 0.2;
                        gamesPrices[tokens[0]] = newPrice;
                    }
                }
            }
            Dictionary<string, double> withDLCs = new Dictionary<string, double>();
            Dictionary<string, double> withoutDLCs = new Dictionary<string, double>();

            foreach (var game in gamesPrices)
            {
                    if (gamesDLCs.ContainsKey(game.Key))
                    {
                        double price = gamesPrices[game.Key] - gamesPrices[game.Key] * 0.5;
                        withDLCs.Add(game.Key, price);
                    }
                    else if(!gamesDLCs.ContainsKey(game.Key))
                    {
                        double price = gamesPrices[game.Key] - gamesPrices[game.Key] * 0.2;
                        withoutDLCs.Add(game.Key, price);
                    }

            }
       

            withDLCs = withDLCs.OrderBy(k => k.Value).ToDictionary(a => a.Key, b => b.Value);
            withoutDLCs = withoutDLCs.OrderByDescending(k=>k.Value).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in withDLCs)
            {
                foreach (var dlc in gamesDLCs)
                {
                    if(kvp.Key == dlc.Key)
                    {
                        Console.WriteLine($"{kvp.Key} - {dlc.Value} - {kvp.Value:F2}");
                    }
                }
            }
            foreach (var kvp in withoutDLCs)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value:F2}");
            }

        }
    }
}
