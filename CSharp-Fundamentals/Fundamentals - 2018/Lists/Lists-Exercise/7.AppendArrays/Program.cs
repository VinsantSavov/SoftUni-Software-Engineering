using System;
using System.Linq;
using System.Collections.Generic;

namespace _7.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrays = Console.ReadLine().Split(" ", '|',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> array = arrays.Split('|');
        }
    }
}
