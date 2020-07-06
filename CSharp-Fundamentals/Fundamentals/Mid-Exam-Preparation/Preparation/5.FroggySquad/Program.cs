using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.FroggySquad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogs = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];

                if(command == "Join")
                {
                    string name = input[1];
                    frogs.Add(name);
                }
                else if(command == "Jump")
                {
                    string name = input[1];
                    int index = int.Parse(input[2]);

                    if(index >=0 && index < frogs.Count)
                    {
                        frogs.Insert(index, name);
                    }
                }
                else if(command == "Dive")
                {
                    int index = int.Parse(input[1]);

                    if (index >= 0 && index < frogs.Count)
                    {
                        frogs.RemoveAt(index);
                    }
                }
                else if(command == "First")
                {
                    int count = int.Parse(input[1]);

                    if(count >= frogs.Count)
                    {
                        count = frogs.Count;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(frogs[i] + " ");
                    }
                    Console.WriteLine();
                }
                else if(command == "Last")
                {
                    int count = int.Parse(input[1]);

                    if (count >= frogs.Count)
                    {
                        count = frogs.Count;
                    }
                    for (int i = frogs.Count-count; i < frogs.Count; i++)
                    {
                        Console.Write(frogs[i] + " ");
                    }
                    Console.WriteLine();
                }
                else if(command == "Print")
                {
                    string type = input[1];

                    if(type == "Normal")
                    {
                        Console.Write("Frogs: ");
                        foreach (var frog in frogs)
                        {
                            Console.Write(frog + " ");
                        }
                    }
                    else if(type == "Reversed")
                    {
                        frogs.Reverse();
                        Console.Write("Frogs: ");
                        foreach (var frog in frogs)
                        {
                            Console.Write(frog + " ");
                        }
                    }
                    break;
                }
                
            }
        }
    }
}
