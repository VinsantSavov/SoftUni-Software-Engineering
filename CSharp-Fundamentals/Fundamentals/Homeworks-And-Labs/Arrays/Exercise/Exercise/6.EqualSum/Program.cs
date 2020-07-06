using System;
using System.Linq;

namespace _6.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            bool isEqual = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                if (i > 0)
                {
                    for (int l = i - 1; l >= 0; l--)
                    {
                        leftSum += numbers[l];
                    }
                }
                if (i != numbers.Length - 1)
                {
                    for (int r = i + 1; r < numbers.Length; r++)
                    {
                        rightSum += numbers[r];
                    }
                }

                if(leftSum == rightSum)
                {
                    index = i;
                    isEqual = true;
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
