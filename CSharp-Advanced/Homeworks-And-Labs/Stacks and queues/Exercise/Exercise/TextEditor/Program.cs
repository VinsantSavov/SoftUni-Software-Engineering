using System;
using System.Collections.Generic;
using System.Linq;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> stack = new Stack<string>();
            stack.Push(text);

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];

                if (command == "1")
                {
                    string someString = input[1];
                    text += someString;
                    stack.Push(text);
                }
                else if (command == "2")
                {
                    int count = int.Parse(input[1]);
                    text = text.Remove(text.Length - count, count);
                    stack.Push(text);
                }
                else if (command == "3")
                {
                    int index = int.Parse(input[1]);

                    Console.WriteLine(text[index - 1]);
                }
                else if (command == "4")
                {
                    stack.Pop();
                    text = stack.Peek();
                }
            }
        }
    }
}
