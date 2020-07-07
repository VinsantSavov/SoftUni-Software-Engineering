using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.FashioBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes.Reverse());
            int sum = 0;
            int racksCount = 1;

            while(stack.Count > 0)
            {
                int value = stack.Pop();
                sum += value;
                
                if(rackCapacity == sum)
                {
                    if(stack.Count > 0)
                    {
                        racksCount++;
                        sum = 0;
                    }
                }
                else if( rackCapacity < sum)
                {
                    stack.Push(value);
                    sum = 0;
                    racksCount++;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
