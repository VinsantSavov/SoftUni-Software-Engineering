using System;
using System.Linq;

namespace _8.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[numbers.Length - 1];

            while (numbers.Length > 1)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }
                for(int i=0;i< condensed.Length; i++)
                {
                    numbers[i] = condensed[i];
                }
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
