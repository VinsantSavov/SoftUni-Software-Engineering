using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
             List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

             for (int i = 0; i < numbers.Count/2; i++)
             {
                 numbers[i] += numbers[numbers.Count-1-i];
             }
             for (int i = 0; i <= numbers.Count / 2; i++)
             {
                 numbers.Remove(numbers[numbers.Count - 1]);
             }

             Console.WriteLine(string.Join(" ",numbers)); 
            
        }
    }
}
