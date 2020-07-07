using System;
using System.Linq;

namespace P04.Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(numbers.ToList());

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
