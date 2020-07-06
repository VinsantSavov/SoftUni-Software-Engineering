using System;
using System.Linq;
using System.Collections.Generic;

namespace _6.ListManipulationBasics
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

                else if(command == "Add")
                {
                    AddToTheLIst(numbers);
                }
                else if(command == "Remove")
                {
                    RemoveFromTheList(numbers);
                }
                else if(command == "RemoveAt")
                {
                    RemoveIndex(numbers);
                }
                else if(command == "Insert")
                {
                    InsertAnElement(numbers);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }

        public static void AddToTheLIst(List<int> numbers)
        {
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }

        public static void RemoveFromTheList(List<int> numbers)
        {
            int num = int.Parse(Console.ReadLine());
            numbers.Remove(num);
        }

        public static void RemoveIndex(List<int> numbers)
        {
            int index = int.Parse(Console.ReadLine());
            numbers.RemoveAt(index);
        }

        public static void InsertAnElement(List<int> numbers)
        {
            int index = int.Parse(Console.ReadLine());
            int element = int.Parse(Console.ReadLine());
            numbers.Insert(index, element);
        }
    }
}
