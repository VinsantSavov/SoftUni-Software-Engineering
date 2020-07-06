using System;
using System.Linq;

namespace _7.MaxSequanceOfEqualEl
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int longest = 0;
            int number = 0;

            for (int i = numbers.Length-1; i >= 0 ; i--)
            {
                int num = numbers[i];
                int counter = 1;

                for (int j = i-1; j >= 0; j--)
                {
                    int nextNum = numbers[j];
                    
                    if (num == nextNum)
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter >= longest)
                {
                    longest = counter;
                    number = num;
                }
            }

            for (int i = 0; i < longest; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}
