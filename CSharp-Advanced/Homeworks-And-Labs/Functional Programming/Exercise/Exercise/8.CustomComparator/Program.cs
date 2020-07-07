using System;
using System.Linq;

namespace _8.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int[], int[]> evenFunc = nums => nums.Where(n => n % 2 == 0).ToArray();
            Func<int[], int[]> oddFunc = nums => nums.Where(n => n % 2 != 0).ToArray();

            int[] even = evenFunc(numbers);
            Array.Sort(even);
            int[] odd = oddFunc(numbers);
            Array.Sort(odd);

            foreach (var num in even)
            {
                Console.Write(num + " ");
            }
            foreach (var num in odd)
            {
                Console.Write(num + " ");
            }
        }
    }
}
