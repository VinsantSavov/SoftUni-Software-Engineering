﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _4.LargestThreeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x=>x).Take(3).ToList();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
