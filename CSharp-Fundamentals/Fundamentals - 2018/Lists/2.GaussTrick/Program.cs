using System;
using System.Linq;
using System.Collections.Generic;


namespace _2.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for(int i = 0; i < numbers.Count / 2; i++)
            {
                int sum = numbers[i] + numbers[numbers.Count - 1 - i];
                result.Add(sum);
            }
            if (numbers.Count % 2 != 0)
            {
                int middle = numbers.Count / 2;
                result.Add(numbers[middle]);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
