using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool hasChanged = false;

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "Contains")
                {
                    int number = int.Parse(command[1]);
                    bool contains = numbers.Contains(number);
                    hasChanged = true;

                    if(contains == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if(command[0] == "PrintEven")
                {
                    List<int> even = new List<int>();
                    hasChanged = true;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            even.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ",even));
                }
                else if(command[0] == "PrintOdd")
                {
                    List<int> odd = new List<int>();
                    hasChanged = true;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            odd.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", odd));
                }
                else if(command[0] == "GetSum")
                {
                    int sum = 0;
                    hasChanged = true;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }
                else if(command[0] == "Filter")
                {
                    string condition = command[1];
                    int number = int.Parse(command[2]);
                    hasChanged = true;

                    if (condition == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > number)
                            {
                                Console.Write(numbers[i]+" ");
                            }
                        }
                        Console.WriteLine();
                    }
                    
                    else if(condition == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    
                    else if (condition == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    
                    else if (condition == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else if (command[0] == "end")
                {
                    
                    break;
                }
            }
        }
    }
}
