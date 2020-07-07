﻿using System;

namespace P01.GenericBoxOfStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                Box<string> box = new Box<string>(value);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
