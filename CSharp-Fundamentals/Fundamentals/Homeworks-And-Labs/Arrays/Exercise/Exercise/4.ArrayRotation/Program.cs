using System;
using System.Linq;

namespace _4.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int[] rotatedNums = new int[numbers.Length];
                int temp = numbers[0];

                for (int k = 0; k < numbers.Length-1; k++)
                { 
                    rotatedNums[k] = numbers[k + 1];
                }

                rotatedNums[numbers.Length-1] = temp;
                numbers = rotatedNums;
            }
            foreach (var kvp in numbers)
            {
                Console.Write(kvp + " ");
            }
        }
    }
}
