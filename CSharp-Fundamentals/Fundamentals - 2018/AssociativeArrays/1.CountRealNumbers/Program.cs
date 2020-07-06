using System;
using System.Linq;
using System.Collections.Generic;

namespace _1.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            SortedDictionary<int, int> nums = new SortedDictionary<int, int>();

            foreach (var num in numbers)
            {
                if (!nums.ContainsKey(num))
                {
                    nums.Add(num, 1);
                }
                else
                {
                    nums[num]++;
                }
            }
            foreach (var number in nums)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
