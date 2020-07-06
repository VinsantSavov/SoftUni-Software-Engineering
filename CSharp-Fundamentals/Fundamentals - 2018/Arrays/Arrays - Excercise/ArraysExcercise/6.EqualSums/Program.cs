using System;
using System.Linq;

namespace _6.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                for(int n = 0; n < i; n++)
                {
                    leftSum += numbers[n];
                }
                if(leftSum == rightSum)
                {
                    index = i;
                    Console.WriteLine(number);
                }
            }
            if (leftSum != rightSum)
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
