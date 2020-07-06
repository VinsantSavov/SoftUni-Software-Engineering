using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateStatus = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warshipStatus = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            bool isBroken = false;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Retire")
                {
                    break;
                }

                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                if(command == "Fire")
                {
                    int index = int.Parse(tokens[1]);
                    int damage = int.Parse(tokens[2]);

                    if(index >=0 && index < warshipStatus.Count)
                    {
                        warshipStatus[index] -= damage;
                        if(warshipStatus[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            isBroken = true;
                            break;
                        }
                    }
                }
                else if(command == "Defend")
                {
                    int index = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int damage = int.Parse(tokens[3]);

                    if(index >=0 && index <= endIndex && endIndex >= index && endIndex < pirateStatus.Count)
                    {
                        for (int i = index; i <= endIndex; i++)
                        {
                            pirateStatus[i] -= damage;
                            if(pirateStatus[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                isBroken = true;
                                break;
                            }
                        }
                    }
                }
                else if(command == "Repair")
                {
                    int index = int.Parse(tokens[1]);
                    int health = int.Parse(tokens[2]);

                    if (index >= 0 && index < pirateStatus.Count)
                    {
                        pirateStatus[index] += health;
                        if(pirateStatus[index] > maxHealth)
                        {
                            pirateStatus[index] = maxHealth;
                        }
                    }
                }
                else if(command == "Status")
                {
                    double needRepair = maxHealth * 0.2;
                    int count = 0;

                    foreach (var section in pirateStatus)
                    {
                        if(section < needRepair)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
            }
            int pirateSum = 0;
            int warshipSum = 0;

            foreach (var section in pirateStatus)
            {
                pirateSum += section;
            }
            foreach (var section in warshipStatus)
            {
                warshipSum += section;
            }

            if (!isBroken)
            {
                Console.WriteLine($"Pirate ship status: {pirateSum}");
                Console.WriteLine($"Warship status: {warshipSum}");
            }
            
        }
    }
}
