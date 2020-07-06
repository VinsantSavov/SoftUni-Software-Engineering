using System;
using System.Linq;

namespace _5.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for(int i = 0; i < numbers.Length; i++)
            {
                int topElement = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int secondNum = numbers[j];
                    if (topElement <= secondNum)
                    {
                        break;
                    }
                    else if (j == numbers.Length - 1)
                    {
                        Console.Write(topElement + " ");
                    }
                }
            }
            Console.WriteLine(numbers[numbers.Length-1]);
        }
    }
}
