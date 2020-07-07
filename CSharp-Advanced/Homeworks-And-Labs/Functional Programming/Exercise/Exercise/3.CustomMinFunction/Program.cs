﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> minNumber = nums => nums.Min();

            Console.WriteLine(minNumber(numbers));
        }
    }
}
