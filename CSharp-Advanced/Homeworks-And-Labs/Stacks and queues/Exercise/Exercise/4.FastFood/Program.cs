using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            List<int> asd = new List<int>();

            int biggestOrder = 0;

            foreach (var item in queue)
            {
                if (item > biggestOrder)
                {
                    biggestOrder = item;
                }
            }
            Console.WriteLine(biggestOrder);

            int len = queue.Count;
            for (int i = 0; i < len; i++)
            {
                int orderN = queue.Dequeue();
                if(quantityFood >= orderN)
                {
                    quantityFood -= orderN;
                }
                else if(orderN > quantityFood)
                {
                    //queue.Enqueue(orderN);
                    asd.Add(orderN);
                    break;
                }
            }

            if(asd.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                
                asd.AddRange(queue);
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(" ", asd));
            }
        }
    }
}
