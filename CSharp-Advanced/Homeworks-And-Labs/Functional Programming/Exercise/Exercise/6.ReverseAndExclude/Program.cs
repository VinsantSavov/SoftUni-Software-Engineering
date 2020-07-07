using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            numbers = numbers.Where(num => num % n != 0).Reverse().ToList();

            Action<int> printFunc = n => Console.Write(n + " ");

            foreach (var num in numbers)
            {
                printFunc(num);
            }
        }
    }
}
