using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Actionpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            Action<List<string>> print = n => n.ForEach(Console.WriteLine);

            print(names);
        }
    }
}
