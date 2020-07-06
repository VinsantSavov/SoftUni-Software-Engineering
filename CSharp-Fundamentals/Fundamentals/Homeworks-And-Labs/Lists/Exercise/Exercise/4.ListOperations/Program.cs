using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "End")
                {
                    break;
                }

                if (commands[0] == "Add")
                {
                    int num = int.Parse(commands[1]);
                    numbers.Add(num);
                }
                else if(commands[0] == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);

                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
           
                }
                else if (commands[0] == "Remove")
                {
                    int index = int.Parse(commands[1]);

                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (commands[0] == "Shift" && commands[1] == "left")
                {
                    int rotations = int.Parse(commands[2]);

                    for (int i = 0; i < rotations ; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if(commands[0] == "Shift" && commands[1] == "right")
                {
                    int rotations = int.Parse(commands[2]);

                    for (int i = 0; i < rotations; i++)
                    {
                        numbers.Insert(0, numbers[numbers.Count-1]);
                        numbers.RemoveAt(numbers.Count-1);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
