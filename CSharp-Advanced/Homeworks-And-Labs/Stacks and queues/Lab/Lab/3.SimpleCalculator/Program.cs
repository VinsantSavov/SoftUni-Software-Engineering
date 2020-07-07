using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] equation = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(equation.Reverse());
            int result = 0;

            while(stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int second = int.Parse(stack.Pop());

                if (sign == "+")
                {
                    result = first + second;
                    stack.Push(result.ToString());
                }
                else
                {
                    result = first - second;
                    stack.Push(result.ToString());
                }
            }

            int sum = int.Parse(stack.Pop().ToString());
            Console.WriteLine(sum);
        }
    }
}
