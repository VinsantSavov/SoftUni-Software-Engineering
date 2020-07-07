using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string parenthesis = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Stack<char> myStack = new Stack<char>();
            bool isBalanced = true;
            string firstPart = string.Empty;
            string secondPart = string.Empty;

            if(parenthesis.Length % 2 == 0 && parenthesis.Length <= 1000)
            {
                for (int i = 0; i < parenthesis.Length / 2; i++)
                {
                    stack.Push(parenthesis[i]);
                }
                if(stack.Contains(')') || stack.Contains(']') || stack.Contains('}'))
                {
                    for (int i = parenthesis.Length / 2-1; i >= parenthesis.Length / 2; i--)
                    {
                        char sym = stack.Pop();
                        if(sym == parenthesis[i])
                        {
                            isBalanced = true;
                        }
                        else
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = parenthesis.Length / 2; i < parenthesis.Length; i++)
                    {
                        char curr = stack.Pop();

                        if (curr == '(' && parenthesis[i] != ')')
                        {
                            isBalanced = false;
                            break;
                        }
                        else if (curr == '[' && parenthesis[i] != ']')
                        {
                            isBalanced = false;
                            break;
                        }
                        else if (curr == '{' && parenthesis[i] != '}')
                        {
                            isBalanced = false;
                            break;
                        }
                    }

                }

                if (isBalanced)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
                
        }
    }
}
