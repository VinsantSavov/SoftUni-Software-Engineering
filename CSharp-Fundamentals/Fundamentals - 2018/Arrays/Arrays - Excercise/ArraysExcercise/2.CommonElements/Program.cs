﻿using System;

namespace _2.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstElements = Console.ReadLine().Split();
            string[] secondElements = Console.ReadLine().Split();

            for(int i = 0; i < secondElements.Length; i++)
            {
                for(int j = 0; j < firstElements.Length; j++)
                {
                    if (firstElements[j] == secondElements[i])
                    {
                        Console.Write(secondElements[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
