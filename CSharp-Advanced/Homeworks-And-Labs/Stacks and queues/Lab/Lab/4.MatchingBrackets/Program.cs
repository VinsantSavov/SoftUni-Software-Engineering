using System;
using System.Collections.Generic;

namespace _4.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string equation = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            List<string> expressions = new List<string>();

            for (int i = 0; i < equation.Length; i++)
            {
                if(equation[i] == '(')
                {
                    stack.Push(i);
                }
                else if(equation[i] == ')')
                {
                    int temp = stack.Pop();
                    string expression = equation.Substring(temp,i-temp+1);
                    expressions.Add(expression);
                }
            }

            foreach (var item in expressions)
            {
                Console.WriteLine(item);
            }
        }
    }
}
