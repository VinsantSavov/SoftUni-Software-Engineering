using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            List<int> numbers = new List<int>();

            foreach (var str in arrays)
            {
                numbers.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
