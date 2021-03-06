﻿using System;
using System.Numerics;

namespace _3.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoralOfN = 1;

            for (int i = 1; i <= n; i++)
            {
                factoralOfN *= i;
            }

            Console.WriteLine(factoralOfN);
        }
    }
}
