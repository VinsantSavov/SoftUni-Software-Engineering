using System;
using System.Linq;
using System.Collections.Generic;

namespace _4.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();
                if(tokens[0] == "End")
                {
                    break;
                }
                else if (tokens[0] == "Add")
                {
                    int num = int.Parse(tokens[1]);
                    numbers.Add(num);
                }
                else if(tokens[0] == "Insert")
                {
                    int num = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index > numbers.Count-1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    
                        numbers.Insert(index, num);
                    
                    
                }
                else if(tokens[0] == "Remove")
                {
                    int num = int.Parse(tokens[1]);
                    if (num > numbers.Count-1 || num < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    
                        numbers.RemoveAt(num);
                    
                    
                }
                else if(tokens[0] == "Shift" && tokens[1] == "left")
                {
                    int num = int.Parse(tokens[2]);
                    for (int i = 0; i < num % numbers.Count; i++)
                    {
                        int firstNum = numbers[0];
                        for (int j = 0; j < numbers.Count-1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }
                        numbers[numbers.Count - 1] = firstNum;
                    }
                }
                else if (tokens[0] == "Shift" && tokens[1] == "right")
                {
                    int num = int.Parse(tokens[2]);
                    for (int i = 0; i < num % numbers.Count; i++)
                    {
                        int lastNum = numbers[numbers.Count-1];
                        for (int j = numbers.Count-1; j > 0; j--)
                        {
                            numbers[j] = numbers[j - 1];
                        }
                        numbers[0] = lastNum;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
