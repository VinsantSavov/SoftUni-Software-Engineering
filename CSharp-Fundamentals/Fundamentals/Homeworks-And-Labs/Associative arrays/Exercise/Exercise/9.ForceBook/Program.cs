using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sideUser = new Dictionary<string, List<string>>();
            Dictionary<string, string> userSide = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Lumpawaroo")
                {
                    break;
                }

                string[] tokens = input.Split(new[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input.Contains("|"))
                {
                    string side = tokens[0];
                    string user = tokens[1];

                    if (!sideUser.ContainsKey(side))
                    {
                        if (!userSide.ContainsKey(user))
                        {
                            sideUser.Add(side, new List<string>());
                            sideUser[side].Add(user);
                            userSide.Add(user, side);
                        }
                    }
                    else
                    {
                        if (!userSide.ContainsKey(user))
                        {
                            sideUser[side].Add(user);
                            userSide.Add(user, side);
                        }
                    }

                }
                else if (input.Contains("->"))
                {
                    string user = tokens[0];
                    string side = tokens[1];

                    if (!sideUser.ContainsKey(side))
                    {
                        if (!userSide.ContainsKey(user))
                        {
                            sideUser.Add(side, new List<string>());
                            sideUser[side].Add(user);
                            userSide.Add(user, side);
                        }
                        else
                        {
                            string temp = userSide[user];
                            sideUser[side].Add(user);
                            userSide.Remove(user);
                            sideUser[temp].Remove(user);
                        }
                    }
                    else
                    {
                        if (!userSide.ContainsKey(user))
                        {
                            sideUser[side].Add(user);
                            userSide.Add(user, side);
                        }
                        else
                        {
                            string temp = userSide[user];
                            sideUser[side].Add(user);
                            userSide.Remove(user);
                            sideUser[temp].Remove(user);
                        }
                    }
                    Console.WriteLine($"{user} joins the {side} side!");

                }
            }

            foreach (var kvp in sideUser.OrderByDescending(m=>m.Value.Count).ThenBy(n=>n.Key))
            {
                if(kvp.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                    foreach (var member in kvp.Value.OrderBy(n => n))
                    {
                        Console.WriteLine($"! {member}");
                    }
                }
            }
        }
    }
}
