using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();
            int pumpCounter = 0;

            for (int i = 0; i < petrolPumps; i++)
            {
                int[] arg = Console.ReadLine().Split().Select(int.Parse).ToArray();

                queue.Enqueue(arg);
            }

            while (true)
            {
                int fuelNeeded = 0;
                bool negative = true;
                for (int i = 0; i < queue.Count; i++)
                {
                    int[] pump = queue.Dequeue();
                    int fuel = pump[0];
                    int distance = pump[1];

                    fuelNeeded += fuel;
                    fuelNeeded -= distance;
                    if(fuelNeeded < 0)
                    {
                        negative = false;
                    }

                    queue.Enqueue(pump);
                }

                if (negative)
                {
                    break;
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                    pumpCounter++;
                }
            }

            Console.WriteLine(pumpCounter);
        }
    }
}
