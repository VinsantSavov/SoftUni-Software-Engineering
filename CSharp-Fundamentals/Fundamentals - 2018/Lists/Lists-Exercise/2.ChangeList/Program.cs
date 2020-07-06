using System;
using System.Linq;
using System.Collections.Generic;

namespace _2.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();

                if (tokens[0] == "end")
                {
                    break;
                }
                else if (tokens[0] == "Delete")
                {
                    int num = int.Parse(tokens[1]);
                    
                    for(int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == num)
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }
                }
                else if (tokens[0] == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);
                    numbers.Insert(position, element);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
