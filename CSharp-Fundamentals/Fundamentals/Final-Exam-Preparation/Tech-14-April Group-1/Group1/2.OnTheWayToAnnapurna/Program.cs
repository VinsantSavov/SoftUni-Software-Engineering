using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.OnTheWayToAnnapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> diary = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "END")
                {
                    break;
                }

                string[] tokens = input.Split("->");
                string command = tokens[0];

                if(command == "Add")
                {
                    string store = tokens[1];
                    List<string> items = tokens[2].Split(",").ToList();

                    if (!diary.ContainsKey(store))
                    {
                        diary.Add(store, new List<string>());
                    }

                    diary[store].AddRange(items);
                }
                else if(command == "Remove")
                {
                    string store = tokens[1];

                    if (diary.ContainsKey(store))
                    {
                        diary.Remove(store);
                    }
                }
            }

            diary = diary.OrderByDescending(x => x.Value.Count).ThenByDescending(s => s.Key).ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine("Stores list:");

            foreach (var kvp in diary)
            {
                Console.WriteLine(kvp.Key);
                foreach (var item in diary[kvp.Key])
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
