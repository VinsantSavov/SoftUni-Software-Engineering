﻿using System;

namespace _2.BiggerNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                Console.WriteLine(firstNum);
            }
            else
            {
                Console.WriteLine(secondNum);
            }
        }
    }
}