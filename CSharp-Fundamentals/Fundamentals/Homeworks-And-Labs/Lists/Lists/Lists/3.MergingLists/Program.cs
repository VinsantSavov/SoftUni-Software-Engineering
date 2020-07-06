using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> shorter = new List<int>();
            List<int> result = new List<int>();

            if (first.Count < second.Count)
            {
                shorter = first;

                for (int i = 0; i < shorter.Count; i++)
                {
                    result.Add(first[i]);
                    result.Add(second[i]);
                }
                for (int i = shorter.Count; i < second.Count; i++)
                {
                    result.Add(second[i]);
                }
            }
            else
            {
                shorter = second;

                for (int i = 0; i < shorter.Count; i++)
                {
                    result.Add(first[i]);
                    result.Add(second[i]);
                }
                for (int i = shorter.Count; i < first.Count; i++)
                {
                    result.Add(first[i]);
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
