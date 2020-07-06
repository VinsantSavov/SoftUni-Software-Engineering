using System;
using System.Linq;

namespace _5.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lastElement = numbers[numbers.Length-1];
            bool isBigger = false;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                int element = numbers[i];

                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(element > numbers[j])
                    {
                        isBigger = true;
                    }
                    else
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                    Console.Write(element + " ");
                }

            }
            Console.WriteLine(lastElement);
        }
    }
}
