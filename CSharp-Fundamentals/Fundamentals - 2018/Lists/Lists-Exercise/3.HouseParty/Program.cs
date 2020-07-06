using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for(int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();

                if (tokens[2] != "not")
                {
                    if (guests.Count == 0)
                    {
                        guests.Add(tokens[0]);
                    }
                    else
                    {
                        for (int j = 0; j < guests.Count; j++)
                        {
                            if (tokens[0] == guests[j])
                            {
                                Console.WriteLine($"{tokens[0]} is already in the list!");
                                break;
                            }
                            else if (tokens[0] != guests[j] && j == guests.Count-1)
                            {
                                guests.Add(tokens[0]);
                            }
                        }
                    }
                }
                else
                {
                    if (guests.Count == 0)
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                    else
                    {
                        for (int z = 0; z < guests.Count; z++)
                        {
                            if (tokens[0] == guests[z])
                            {
                                guests.Remove(guests[z]);
                                break;
                            }
                            else if (tokens[0] != guests[z] && z == guests.Count - 1)
                            {
                                Console.WriteLine($"{tokens[0]} is not in the list!");
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join("\n",guests));
        }
    }
}
