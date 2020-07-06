using System;
using System.Linq;

namespace _7.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int maxCounter = 0;
            int[] equalElements = new int[counter];

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                maxCounter = counter;
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                }
            

            }
        }
    }
}
