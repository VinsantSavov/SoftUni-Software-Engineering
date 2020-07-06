﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().Where(w=>w.Length%2==0).ToList();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
