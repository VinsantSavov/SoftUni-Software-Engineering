using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.PracticeSessions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> roadRacer = new Dictionary<string, List<string>>();

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
                    string road = tokens[1];
                    string racer = tokens[2];

                    if (!roadRacer.ContainsKey(road))
                    {
                        roadRacer.Add(road, new List<string>());
                    }
                    roadRacer[road].Add(racer);
                }
                else if(command == "Move")
                {
                    string currentRoad = tokens[1];
                    string racer = tokens[2];
                    string nextRoad = tokens[3];

                    if (roadRacer[currentRoad].Contains(racer))
                    {
                        roadRacer[currentRoad].Remove(racer);
                        roadRacer[nextRoad].Add(racer);
                    }
                }
                else if(command == "Close")
                {
                    string road = tokens[1];

                    if (roadRacer.ContainsKey(road))
                    {
                        roadRacer.Remove(road);
                    }
                }
            }

            roadRacer = roadRacer.OrderByDescending(x => x.Value.Count).ThenBy(r => r.Key).ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine("Practice sessions:");
            foreach (var kvp in roadRacer)
            {
                Console.WriteLine(kvp.Key);
                foreach (var racer in roadRacer[kvp.Key])
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}
