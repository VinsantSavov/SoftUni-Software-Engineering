using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.GreedyTimes
{
    public class Program
    {
        public const string gold = "Gold";
        public const string gem = "Gem";
        public const string cash = "Cash";

        static void Main(string[] args)
        {
            int bagCapacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, Dictionary<string, long>> specialItems = new Dictionary<string, Dictionary<string, long>>();

            AddSpecialItems(specialItems);

            for (int i = 0; i < input.Length; i+=2)
            {
                string item = input[i];
                long quantity = long.Parse(input[i + 1]);

                if(item.Length == 3)
                {
                    if (specialItems[cash].Values.Sum() + quantity <= specialItems[gem].Values.Sum() 
                        && EnoughFreeSpace(specialItems, bagCapacity))
                    {
                        if (!specialItems[cash].ContainsKey(item))
                        {
                            specialItems[cash][item] = 0;
                        }
                        specialItems[cash][item] += quantity;
                    }
                }
                else if(input[i].ToLower() == "gold")
                {
                    if(specialItems[gold].Values.Sum() + quantity >= specialItems[gem].Values.Sum()
                        && EnoughFreeSpace(specialItems, bagCapacity))
                    {
                        if (!specialItems[gold].ContainsKey(item))
                        {
                            specialItems[gold][item] = 0;
                        }
                        specialItems[gold][item] += quantity;
                    }
                }
                else if (input[i].ToLower().EndsWith("gem"))
                {
                    if (specialItems[gem].Values.Sum() + quantity >= specialItems[cash].Values.Sum()
                        && EnoughFreeSpace(specialItems, bagCapacity))
                    {
                        if (!specialItems[gem].ContainsKey(item))
                        {
                            specialItems[gem][item] = 0;
                        }
                        specialItems[gem][item] += quantity;
                    }
                }
            }

            PrintTheBag(specialItems);
        }

        public static void AddSpecialItems(Dictionary<string, Dictionary<string, long>> specialItems)
        {
            specialItems.Add(gold, new Dictionary<string, long>());
            specialItems.Add(cash, new Dictionary<string, long>());
            specialItems.Add(gem, new Dictionary<string, long>());
        }

        public static bool EnoughFreeSpace(Dictionary<string, Dictionary<string, long>> specialItems, int capacity)
        {
            bool isEnough = specialItems[cash].Values.Sum() + specialItems[gold].Values.Sum() 
                + specialItems[gem].Values.Sum() < capacity;

            return isEnough;
        }

        public static void PrintTheBag(Dictionary<string, Dictionary<string, long>> specialItems)
        {
            foreach (var type in specialItems.OrderByDescending(a=>a.Value.Values.Sum()))
            {
                Console.WriteLine($"<{type.Key}> ${specialItems[type.Key].Values.Sum()}");

                foreach (var kvp in type.Value.OrderByDescending(a=>a.Key).ThenBy(n=>n.Value))
                {
                    Console.WriteLine($"##{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}
