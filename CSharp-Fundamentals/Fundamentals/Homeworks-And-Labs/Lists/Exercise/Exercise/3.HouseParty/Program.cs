using System;
using System.Collections.Generic;

namespace _3.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string name = commands[0];

                if (commands[2] == "not")
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
