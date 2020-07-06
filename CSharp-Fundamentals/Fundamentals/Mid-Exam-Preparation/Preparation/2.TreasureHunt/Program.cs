using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine().Split("|").ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Yohoho!")
                {
                    break;
                }

                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                if(command == "Loot")
                {
                    List<string> treasureLoot = new List<string>();
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        treasureLoot.Add(tokens[i]);
                    }
                    foreach (var item in treasureLoot)
                    {
                        if (!loot.Contains(item))
                        {
                            loot.Insert(0, item);
                        }
                    }
                }
                else if(command == "Drop")
                {
                    int index = int.Parse(tokens[1]);
                    
                    if(index >= 0 && index < loot.Count)
                    {
                        string item = loot[index];
                        loot.RemoveAt(index);
                        loot.Add(item);
                    }
                }
                else if(command == "Steal")
                {
                    int count = int.Parse(tokens[1]);

                    if (count > loot.Count)
                    {
                        count = loot.Count;
                    }

                    List<string> stolenItems = new List<string>();

                    for (int i = loot.Count-count; i < loot.Count; i++)
                    {
                        stolenItems.Add(loot[i]);
                    }
                    loot.RemoveRange(loot.Count - count, count);

                    Console.WriteLine(string.Join(", ", stolenItems));
                }
            }

            double averageTreasure = 0.0;
            foreach (var item in loot)
            {
                averageTreasure += item.Length;
            }
            averageTreasure /= loot.Count;

            if (loot.Any())
            {
                Console.WriteLine($"Average treasure gain: {averageTreasure:F2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
