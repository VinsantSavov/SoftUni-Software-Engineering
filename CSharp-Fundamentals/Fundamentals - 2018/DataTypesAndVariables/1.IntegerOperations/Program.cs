﻿using System;

namespace _1.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int sumOfTwo = firstNum + secondNum;
            int division = sumOfTwo / thirdNum;
            int result = division * fourthNum;

            Console.WriteLine(result);
        }
    }
}
