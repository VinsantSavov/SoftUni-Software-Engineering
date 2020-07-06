using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int minCount = Math.Min(firstList.Count, secondList.Count);

            for(int i = 0; i < minCount; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            List<int> biggerList;
            if(minCount == firstList.Count)
            {
                biggerList = secondList;
            }
            else
            {
                biggerList = firstList;
            }

            for(int j = minCount; j < biggerList.Count; j++)
            {
                result.Add(biggerList[j]);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
