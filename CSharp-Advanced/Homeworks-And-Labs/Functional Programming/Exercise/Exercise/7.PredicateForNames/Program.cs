using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(n => n.Length <= len)
                .ToList();

            Action<string> printFunc = n => Console.WriteLine(n);

            foreach (var name in names)
            {
                printFunc(name);
            }
        }
    }
}
