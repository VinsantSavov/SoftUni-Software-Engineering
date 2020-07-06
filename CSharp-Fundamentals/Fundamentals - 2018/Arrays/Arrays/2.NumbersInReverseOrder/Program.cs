using System;

namespace _2.NumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for(int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for(int y = n - 1; y >= 0; y--)
            {
                Console.Write(numbers[y]+" ");
            }
        }
    }
}
