﻿using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<string> scale = new EqualityScale<string>("Pesho","Liam");

            Console.WriteLine(scale.AreEqual());
        }
    }
}
