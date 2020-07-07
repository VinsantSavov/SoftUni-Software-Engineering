using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<char> stack = new Stack<char>();
            Stack<string> actions = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                string command = commands[0];

                if(command == "1")
                {
                    string text = commands[1];

                    if (!stack.Any())
                    {
                        actions.Push(text);
                    }
                    else if(stack.Any() && actions.Any())
                    {
                        string actText = actions.Pop();
                        actions.Push(actText);
                        string temp = actText + text;
                        actions.Push(temp);
                    }

                    for (int g = 0; g < text.Length; g++)
                    {
                        stack.Push(text[g]);
                    }
                }
                else if(command == "2")
                {
                    int count = int.Parse(commands[1]);
                    string text = string.Empty;

                    foreach (var item in stack.Reverse())
                    {
                        text += item;
                    }
                    actions.Push(text);

                    for (int j = 0; j < count; j++)
                    {
                        stack.Pop();
                    }
                }
                else if(command == "3")
                {
                    int index = int.Parse(commands[1]);
                    int counter = 1;

                    foreach (var element in stack.Reverse())
                    {
                        if(index == counter)
                        {
                            Console.WriteLine(element);
                        }
                        counter++;
                    }
                }
                else if(command == "4")
                {
                    if (actions.Any())
                    {
                        string backup = actions.Pop();

                        while(backup != stack.ToString())
                        {
                            backup = actions.Pop();
                        }
                        if(backup != stack.ToString())
                        {
                            stack.Clear();
                            for (int j = 0; j < backup.Length; j++)
                            {
                                stack.Push(backup[j]);
                            }
                        }
                        /*if(backup == stack.ToString())
                        {
                            backup = actions.Pop();
                        }
                        else
                        {
                            stack.Clear();
                            for (int j = 0; j < backup.Length; j++)
                            {
                                stack.Push(backup[j]);
                            }
                        }*/
                    }
                }
            }
        }
    }
}
