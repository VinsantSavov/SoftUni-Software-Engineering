using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    numbers.Add(number);

                }
                else if (command[0] == "Remove")
                {
                    int number = int.Parse(command[1]);
                    numbers.Remove(number);
                }
                else if (command[0] == "RemoveAt")
                {
                    int index = int.Parse(command[1]);
                    numbers.RemoveAt(index);
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, number);
                }
                else if(command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ",numbers));
                    break;
                }
            }
        }
    }
}
