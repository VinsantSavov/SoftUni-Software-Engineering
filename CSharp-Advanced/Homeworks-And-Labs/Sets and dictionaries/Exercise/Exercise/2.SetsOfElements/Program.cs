using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstSet = new List<int>();
            var secondSet = new List<int>();
            var uniqueElements = new HashSet<int>();

            for (int i = 0; i < sets[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                firstSet.Add(number);
            }

            for (int i = 0; i < sets[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                secondSet.Add(number);
            }

            for (int i = 0; i < firstSet.Count; i++)
            {
                for (int j = 0; j < secondSet.Count; j++)
                {
                    if(firstSet[i] == secondSet[j])
                    {
                        uniqueElements.Add(firstSet[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",uniqueElements));
        }
    }
}
