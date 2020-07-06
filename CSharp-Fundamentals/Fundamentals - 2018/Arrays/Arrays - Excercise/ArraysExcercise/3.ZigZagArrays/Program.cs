using System;
using System.Linq;

namespace _3.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for(int i = 1; i <= n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 != 0)
                {
                    firstArray[i-1]= nums[0];
                    secondArray[i-1] = nums[1];
                }
                else
                {
                    firstArray[i - 1] = nums[1];
                    secondArray[i - 1] = nums[0];
                }
            }
            for(int j = 0; j < n; j++)
            {
                Console.Write(firstArray[j]+" ");
            }
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                Console.Write(secondArray[j] + " ");
            }
        }
    }
}
