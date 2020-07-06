using System;

namespace _1.SmallestOfThreeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int result = FindingSmallestNumber(first, second, third);
            Console.WriteLine(result);
        }

        public static int FindingSmallestNumber(int first,int second,int third)
        {
            int result = 0;
            if (first <= second && first <= third)
            {
                result = first;
            }
            else if (second <= first && second <= third)
            {
                result = second;
            }
            else if(third<=first&& third <= second)
            {
                result = third;
            }
            return result;
        }
    }
}
