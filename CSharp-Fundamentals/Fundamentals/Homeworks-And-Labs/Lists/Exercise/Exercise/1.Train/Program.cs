using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    break;
                }
                if(command[0] == "Add")
                {
                    int pass = int.Parse(command[1]);
                    train.Add(pass);
                }
                else
                {
                    int pass = int.Parse(command[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + pass <= maxCapacity)
                        {
                            train[i] += pass;
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ",train));
        }
    }
}
