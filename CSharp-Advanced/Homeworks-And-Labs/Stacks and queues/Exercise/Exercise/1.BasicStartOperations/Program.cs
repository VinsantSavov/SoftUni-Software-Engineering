using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.BasicStartOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = operands[0];
            int s = operands[1];
            int x = operands[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            int minNum = int.MaxValue;
            bool isEqual = false;
            if(stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                foreach (var num in stack)
                {
                    if (num == x)
                    {
                        Console.WriteLine("true");
                        isEqual = true;
                        break;
                    }
                    else if(num != x)
                    {
                        if(num < minNum)
                        {
                            minNum = num;
                        }
                    }

                }
                if (!isEqual)
                {
                    Console.WriteLine(minNum);
                }
            }
            
            
        }
    }
}
