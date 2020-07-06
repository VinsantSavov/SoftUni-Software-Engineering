using System;
using System.Linq;

namespace _6.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            foreach (var kvp in numbers)
            {
                if (kvp % 2 == 0)
                {
                    evenSum += kvp;
                }
                else
                {
                    oddSum += kvp;
                }
            }
            Console.WriteLine(evenSum-oddSum);
        }
    }
}
