using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            Func<int, List<int>> sortingFunc = num => numbers.Where(n => n % num == 0).ToList();

            foreach (var divider in dividers)
            {
                numbers = sortingFunc(divider);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
