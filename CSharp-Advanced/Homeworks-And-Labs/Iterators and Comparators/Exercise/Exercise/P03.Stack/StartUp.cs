using System;
using System.Linq;

namespace P03.Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "END")
                {
                    break;
                }

                if(command == "Pop")
                {
                    if (stack.Any())
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("No elements");
                    }
                }
                else
                {
                    string[] input = command.Split(new[] { "Push ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                    stack.Push(input.ToList());
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
