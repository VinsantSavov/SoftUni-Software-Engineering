using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Func<List<int>, List<int>> addFunc = nums => nums.Select(n => n + 1).ToList();
            Func<List<int>, List<int>> multiplyFunc = nums => nums.Select(n => n * 2).ToList();
            Func<List<int>, List<int>> subtractFunc = nums => nums.Select(n => n - 1).ToList();
            Action<List<int>> printFunc = nums =>
            {
                Console.WriteLine(string.Join(" ",nums));
            };

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "end")
                {
                    break;
                }

                if(command == "add")
                {
                    numbers = addFunc(numbers);
                }
                else if(command == "multiply")
                {
                    numbers = multiplyFunc(numbers);
                }
                else if(command == "subtract")
                {
                    numbers = subtractFunc(numbers);
                }
                else if(command == "print")
                {
                    printFunc(numbers);
                }
            }
        }
    }
}
