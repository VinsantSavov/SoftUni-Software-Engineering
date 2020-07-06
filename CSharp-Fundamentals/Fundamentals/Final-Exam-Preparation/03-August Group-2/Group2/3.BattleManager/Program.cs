using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.BattleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nameHealth = new Dictionary<string, int>();
            Dictionary<string, int> nameEnergy = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Results")
                {
                    break;
                }

                string[] tokens = input.Split(':');
                string command = tokens[0];

                if(command == "Add")
                {
                    string person = tokens[1];
                    int health = int.Parse(tokens[2]);
                    int energy = int.Parse(tokens[3]);

                    if (!nameHealth.ContainsKey(person))
                    {
                        nameHealth.Add(person, 0);
                        nameEnergy.Add(person, energy);
                    }
                    nameHealth[person] += health;
                }
                else if(command == "Attack")
                {
                    string attacker = tokens[1];
                    string defender = tokens[2];
                    int damage = int.Parse(tokens[3]);

                    if(nameHealth.ContainsKey(attacker) && nameHealth.ContainsKey(defender))
                    {
                        nameHealth[defender] -= damage;
                        if(nameHealth[defender] <= 0)
                        {
                            nameHealth.Remove(defender);
                            nameEnergy.Remove(defender);
                            Console.WriteLine($"{defender} was disqualified!");
                        }
                        nameEnergy[attacker] -= 1;
                        if (nameEnergy[attacker] <= 0)
                        {
                            nameEnergy.Remove(attacker);
                            nameHealth.Remove(attacker);
                            Console.WriteLine($"{attacker} was disqualified!");
                        }
                    }
                }
                else if(command == "Delete")
                {
                    string username = tokens[1];

                    if (username == "All")
                    {
                        nameHealth.Clear();
                        nameEnergy.Clear();
                    }
                    else
                    {
                        nameHealth.Remove(username);
                        nameEnergy.Remove(username);
                    }
                }
            }

            Console.WriteLine($"People count: {nameHealth.Count}");
            nameHealth = nameHealth.OrderByDescending(x => x.Value).ThenBy(n => n.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in nameHealth)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} - {nameEnergy[kvp.Key]}");
            }
        }
    }
}
