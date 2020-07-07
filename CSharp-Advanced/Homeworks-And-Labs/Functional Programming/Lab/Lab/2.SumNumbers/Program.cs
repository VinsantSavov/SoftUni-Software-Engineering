using System;
using System.Linq;

namespace _2.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = numbers.Count();
            int sum = numbers.Sum();

            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
