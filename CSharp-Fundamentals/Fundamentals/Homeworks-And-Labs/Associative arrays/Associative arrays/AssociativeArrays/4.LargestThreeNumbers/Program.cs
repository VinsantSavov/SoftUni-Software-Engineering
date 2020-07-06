using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x=>x).ToList();
            int n = 0;
            if(numbers.Count >= 3)
            {
                n = 3;
            }
            else
            {
                n = numbers.Count;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
