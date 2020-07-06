using System;
using System.Linq;

namespace _7.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool areEqual = true;

            for(int i = 0; i < firstNums.Length; i++)
            {
                if (firstNums[i] == secondNums[i])
                {
                    sum += firstNums[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    areEqual = false;
                    break;
                }
            }
            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            
        }
    }
}
