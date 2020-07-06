using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderBy(n=>n).ToList();
            Dictionary<int, int> nums = new Dictionary<int, int>();

            foreach (var num in numbers)
            {
                if (nums.ContainsKey(num))
                {
                    nums[num]++;
                }
                else
                {
                    nums[num] = 1;
                }
            }
            
            foreach (var num in nums)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
