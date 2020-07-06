using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            Dictionary<string, int> junkItems = new Dictionary<string, int>();
            bool isEnough = false;
            counts.Add("shards", 0);
            counts.Add("fragments", 0);
            counts.Add("motes", 0);

            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                for (int i = 0; i < input.Count; i+=2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i+1].ToLower();

                    if (material != "shards" && material != "fragments" && material != "motes")
                    {
                        if (!junkItems.ContainsKey(material))
                        {
                            junkItems.Add(material, quantity);
                        }
                        else
                        {
                            junkItems[material] += quantity;
                        }
                    }
                    else
                    {
                        if (!counts.ContainsKey(material))
                        {
                            counts.Add(material, quantity);
                        }
                        else
                        {
                            counts[material] += quantity;
                        }
                    }

                    if (material == "shards" && counts[material] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        counts[material] -= 250;
                        isEnough = true;
                        break;
                    }
                    if (material == "fragments" && counts[material] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        counts[material] -= 250;
                        isEnough = true;
                        break;
                    }
                    if (material == "motes" && counts[material] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        counts[material] -= 250;
                        isEnough = true;
                        break;
                    }
                }
                if (isEnough)
                {
                    break;
                }
            }

            foreach (var item in counts.OrderByDescending(x=>x.Value).ThenBy(n=>n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkItems.OrderBy(n=>n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
