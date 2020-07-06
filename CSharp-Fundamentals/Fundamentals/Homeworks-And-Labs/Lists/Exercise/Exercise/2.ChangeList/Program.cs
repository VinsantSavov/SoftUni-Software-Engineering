using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if(input[0] == "end")
                {
                    break;
                }
                if (input[0] == "Delete")
                {
                    int element = int.Parse(input[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if(element == numbers[i])
                        {
                            numbers.Remove(element);
                            i = -1;
                        }
                    }
                }
                else if (input[0] == "Insert")
                {
                    int element = int.Parse(input[1]);
                    int position = int.Parse(input[2]);

                    numbers.Insert(position, element);
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
