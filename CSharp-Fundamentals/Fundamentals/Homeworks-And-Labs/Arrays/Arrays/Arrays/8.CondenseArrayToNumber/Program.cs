using System;
using System.Linq;

namespace _8.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            while (numbers.Length > 1)
            {
                int[] sumOfAdjacent = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    sumOfAdjacent[i] = numbers[i] + numbers[i + 1];
                }
                numbers = sumOfAdjacent;
            }

            Console.WriteLine(numbers[0]);

        }
    }
}
