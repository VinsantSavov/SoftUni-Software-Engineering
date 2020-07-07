using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                if(command.Contains(' '))
                {
                    int[] quaries = command.Split().Select(int.Parse).ToArray();
                    int quary = quaries[0];
                    int num = quaries[1];

                    stack.Push(num);
                }
                else if(command == "2")
                {
                    stack.Pop();
                }
                else if(command == "3")
                {
                    int maxElement = int.MinValue;

                    if(stack.Count > 0)
                    {
                        foreach (var item in stack)
                        {
                            if (item > maxElement)
                            {
                                maxElement = item;
                            }
                        }
                        Console.WriteLine(maxElement);
                    }
                }
                else if (command == "4")
                {
                    int minElement = int.MaxValue;

                    if(stack.Count > 0)
                    {
                        foreach (var item in stack)
                        {
                            if (item < minElement)
                            {
                                minElement = item;
                            }
                        }
                        Console.WriteLine(minElement);
                    }
                }
            }

            Console.WriteLine(string.Join(", ",stack));
        }
    }
}
