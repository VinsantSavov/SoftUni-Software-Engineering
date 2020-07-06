using System;
using System.Linq;
using System.Collections.Generic;

namespace _5.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombProp = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombProp[0];
            int power = bombProp[1];
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (bomb == numbers[i])
                {
                    int startIndex = i - power;
                    int endIndex = i + power;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }
                    else if (startIndex > numbers.Count - 1 || endIndex < 0)
                    {
                        continue;
                    }

                    numbers.RemoveRange(startIndex, endIndex - startIndex + 1);

                    i = startIndex - 1;
                }
            }
            sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
