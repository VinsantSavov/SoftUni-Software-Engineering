using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.ParenthesisTry
{
    class Program
    {
        static void Main(string[] args)
        {
            string parenthesis = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            string secondPart = string.Empty;
            string firstPart = string.Empty;

            for (int i = 0; i < parenthesis.Length/2; i++)
            {
                stack.Push(parenthesis[i]);
            }
            for (int i = parenthesis.Length / 2; i < parenthesis.Length; i++)
            {
                secondPart += parenthesis[i];
            }

            foreach (var sym in stack.Reverse())
            {
                firstPart += sym;
            }
        }
    }
}
