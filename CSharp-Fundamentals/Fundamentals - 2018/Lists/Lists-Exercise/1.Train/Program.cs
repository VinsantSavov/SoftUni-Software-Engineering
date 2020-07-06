using System;
using System.Linq;
using System.Collections.Generic;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();
                if(line == "end")
                {
                    break;
                }
                string[] tokens = line.Split();

                if (tokens[0] == "Add")
                {
                    int passengers = int.Parse(tokens[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int pass = int.Parse(tokens[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (maxCapacity - wagons[i] >= pass)
                        {
                            wagons[i] += pass;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
