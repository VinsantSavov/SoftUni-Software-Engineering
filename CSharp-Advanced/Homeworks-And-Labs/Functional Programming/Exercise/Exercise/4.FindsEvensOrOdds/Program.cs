using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FindsEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int first = numbers[0];
            int last = numbers[1];
            List<int> numsCondition = new List<int>();

            for (int i = first; i <= last; i++)
            {
                numsCondition.Add(i);
            }

            Func<string, List<int>, List<int>> myFunc = (condition, nums) => condition switch
              {
                  "odd" => nums.Where(n => n % 2 != 0).ToList(),
                  "even" => nums.Where(n => n % 2 == 0).ToList(),
                  _ => nums,
              };

            string condition = Console.ReadLine();

            numsCondition = myFunc(condition, numsCondition);

            foreach (var num in numsCondition)
            {
                Console.Write(num + " ");
            }
        }
    }
}
