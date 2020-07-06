using System;

namespace _2.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            for (int j = numbers.Length-1; j >= 0; j--)
            {
                Console.Write($"{numbers[j]} ");
            }
        }
    }
}
