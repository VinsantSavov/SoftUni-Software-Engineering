﻿using System;

namespace _1.NumbersFromNto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
