using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                int bombNum = bomb[0];
                int power = bomb[1];

                if (bombNum == numbers[i])
                {
                    if (i - power >= 0 && i + power <= numbers.Count - 1)
                    {
                        for (int j = i-power; j <= i+power; j++)
                        {
                            numbers[j] = 0;
                        }
                    }
                    else if(i-power<0)
                    {
                        for (int j = 0; j <= i + power; j++)
                        {
                            numbers[j] = 0;
                        }
                    }
                    else
                    {
                        for (int j = i - power; j <= numbers.Count-1; j++)
                        {
                            numbers[j] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(numbers.Sum());

        }
    }
}
