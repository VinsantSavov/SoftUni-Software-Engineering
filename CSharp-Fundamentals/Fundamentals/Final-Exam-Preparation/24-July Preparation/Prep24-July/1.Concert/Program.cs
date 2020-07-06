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

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "start of concert")
                {
                    break;
                }

                string[] tokens = input.Split("; ");
                string command = tokens[0];

                if(command == "Add")
                {
                    string bandName = tokens[1];
                    string mems = tokens[2];
                    List<string> temp = mems.Split(", ").ToList();
                    List<string> members = temp.Select(x => x).Distinct().ToList();


                    if (!bandMembers.ContainsKey(bandName))
                    {
                        bandMembers.Add(bandName, members);
                        bandTime.Add(bandName, 0);
                    }
                    else
                    {
                        List<string> newList = new List<string>();
                        foreach (var item in members)
                        {
                            for (int i = 0; i < bandMembers[bandName].Count; i++)
                            {
                                if(item != bandMembers[bandName][i] && i == bandMembers[bandName].Count - 1)
                                {
                                    newList.Add(item);
                                }
                                else if(item == bandMembers[bandName][i])
                                {
                                    break;
                                }
                            }
                        }
                        bandMembers[bandName].AddRange(newList);
                    }
                }
                else if(command == "Play")
                {
                    string bandName = tokens[1];
                    int time = int.Parse(tokens[2]);

                    if (!bandMembers.ContainsKey(bandName))
                    {
                        bandMembers.Add(bandName, new List<string>());
                        bandTime.Add(bandName, time);
                    }
                    else
                    {
                        bandTime[bandName] += time;
                    }
                }
            }

            string lastBand = Console.ReadLine();

            bandTime = bandTime.OrderByDescending(t => t.Value).ThenBy(n => n).ToDictionary(a => a.Key, b => b.Value);
            int fullTime = 0;
            foreach (var band in bandTime)
            {
                fullTime += band.Value;
            }

            Console.WriteLine($"Total time: {fullTime}");
            foreach (var band in bandTime)
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            Console.WriteLine(lastBand);
            foreach (var members in bandMembers[lastBand])
            {
                Console.WriteLine($"=> {members}");
            }
        }
    }
}
