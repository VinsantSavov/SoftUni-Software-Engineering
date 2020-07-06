using System;
using System.Linq;

namespace _3.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstNums = new int[n];
            int[] secondNums = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int first = nums[0];
                int second = nums[1];

                if (i % 2 == 0)
                {
                    firstNums[i-1] = second;
                    secondNums[i-1] = first;
                }
                else
                {
                    firstNums[i-1] = first;
                    secondNums[i-1] = second;
                }
            }
            foreach (var kvp in firstNums)
            {
                Console.Write(kvp + " ");
            }
            Console.WriteLine();
            foreach (var kgg in secondNums)
            {
                Console.Write(kgg + " ");
            }
        }
    }
}
