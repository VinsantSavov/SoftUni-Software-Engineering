using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>(numbers);
            int sum = 0;

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if(input == "end")
                {
                    break;
                }

                string[] commands = input.Split();
                string command = commands[0];

                if(command == "add")
                {
                    int first = int.Parse(commands[1]);
                    int second = int.Parse(commands[2]);

                    stack.Push(first);
                    stack.Push(second);
                }
                else if(command == "remove")
                {
                    int num = int.Parse(commands[1]);

                    if(stack.Count >= num)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            foreach (var num in stack)
            {
                sum += num;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
