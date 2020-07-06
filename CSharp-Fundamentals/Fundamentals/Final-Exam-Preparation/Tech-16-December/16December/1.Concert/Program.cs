using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bandMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandTime = new Dictionary<string, int>();
            int totalTime = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "start of concert")
                {
                    break;
                }
                string[] tokens = input.Split("; ");
                string command = tokens[0];
                string band = tokens[1];

                if(command == "Add")
                {
                    List<string> members = tokens[2].Split(", ").ToList();
                    members = members.Distinct().ToList();

                    if (!bandMembers.ContainsKey(band))
                    {
                        bandMembers.Add(band, new List<string>());
                        bandMembers[band].AddRange(members);
                    }
                    else
                    {
                        foreach (var member in members)
                        {
                            if (!bandMembers[band].Contains(member))
                            {
                                bandMembers[band].Add(member);
                            }
                        }
                        
                    }
                }
                else if(command == "Play")
                {
                    int time = int.Parse(tokens[2]);
                    if (!bandTime.ContainsKey(band))
                    {
                        bandTime.Add(band, 0);
                    }
                    bandTime[band] += time;
                    totalTime += time;
                }
            }

            string bandName = Console.ReadLine();

            Console.WriteLine($"Total time: {totalTime}");
            bandTime = bandTime.OrderByDescending(t => t.Value).ThenBy(n => n.Key).ToDictionary(a => a.Key, b => b.Value);
            foreach (var kvp in bandTime)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            Console.WriteLine(bandName);
            foreach (var member in bandMembers[bandName])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
