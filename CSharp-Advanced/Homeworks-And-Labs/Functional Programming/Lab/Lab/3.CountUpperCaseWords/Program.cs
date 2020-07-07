using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.CountUpperCaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> myFunc = l => char.IsUpper(l[0]);

            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(n => myFunc(n))
                .ToList();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
