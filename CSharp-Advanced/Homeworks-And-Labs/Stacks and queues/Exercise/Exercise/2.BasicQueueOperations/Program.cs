using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = operands[0];
            int s = operands[1];
            int x = operands[2];

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(nums);

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if(queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                bool isThere = false;
                int minNum = int.MaxValue;

                foreach (var num in queue)
                {
                    if(num == x)
                    {
                        Console.WriteLine("true");
                        isThere = true;
                        break;
                    }
                    else if(num < minNum)
                    {
                        minNum = num;
                    }
                }
                if (!isThere)
                {
                    Console.WriteLine(minNum);
                }
            }
        }
    }
}
