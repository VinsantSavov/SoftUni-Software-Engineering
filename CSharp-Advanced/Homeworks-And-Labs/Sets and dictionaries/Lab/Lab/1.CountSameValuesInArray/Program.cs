using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var numCount = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!numCount.ContainsKey(input[i]))
                {
                    numCount.Add(input[i], 0);
                }

                numCount[input[i]]++;
            }

            foreach (var kvp in numCount)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
