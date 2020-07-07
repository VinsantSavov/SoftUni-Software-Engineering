using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> queue = new Queue<string>(songs);

            while (queue.Any())
            {
                string command = Console.ReadLine();

                if(command == "Play")
                {
                    queue.Dequeue();
                }
                else if(command.Contains("Add"))
                {
                    string song = command.Substring(4);

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else if(command == "Show")
                {
                    Console.WriteLine(string.Join(", ",queue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
