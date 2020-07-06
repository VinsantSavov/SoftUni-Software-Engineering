using System;
using System.Linq;
using System.Collections.Generic;

namespace _7.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "end")
                {
                    break;
                }
                string[] tokens = command.Split();

                if (tokens[0] == "Contains")
                {
                    int num = int.Parse(tokens[1]);
                    bool contains = false;
                    for(int i = 0; i < numbers.Count; i++)
                    {
                        if (num == numbers[i])
                        {
                            contains = true;
                            break;
                        }
                    }
                    if (contains)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (tokens[0] == "PrintEven")
                {
                    List<int> evenNums = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            evenNums.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ",evenNums));
                }
                else if(tokens[0] == "PrintOdd")
                {
                    List<int> oddNums = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            oddNums.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", oddNums));
                }
                else if (tokens[0] == "GetSum")
                {
                    int sum = 0;
                    for(int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }
                else if(tokens[0] == "Filter")
                {
                    List<int> newList = new List<int>();
                    int num = int.Parse(tokens[2]);

                    if (tokens[1] == ">")
                    {
                        for(int i = 0; i < numbers.Count; i++)
                        {
                            if(num < numbers[i])
                            {
                                newList.Add(numbers[i]);
                            }
                        }
                    }
                    else if (tokens[1] == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (num > numbers[i])
                            {
                                newList.Add(numbers[i]);
                            }
                        }
                    }
                    else if (tokens[1] == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (num <= numbers[i])
                            {
                                newList.Add(numbers[i]);
                            }
                        }
                    }
                    else if (tokens[1] == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (num >= numbers[i])
                            {
                                newList.Add(numbers[i]);
                            }
                        }
                    }
                    Console.WriteLine(string.Join(" ",newList));
                }
            }
        }
    }
}
