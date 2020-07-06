using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "END")
                {
                    break;
                }

                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                if (command == "Change")
                {
                    int paintingNum = int.Parse(tokens[1]);
                    int changedNum = int.Parse(tokens[2]);

                    if (numbers.Contains(paintingNum))
                    {
                        int index = numbers.IndexOf(paintingNum);
                        numbers[index] = changedNum;
                    }
                }
                else if(command == "Hide")
                {
                    int paintingNum = int.Parse(tokens[1]);

                    if (numbers.Contains(paintingNum))
                    {
                        numbers.Remove(paintingNum);
                    }
                }
                else if(command == "Switch")
                {
                    int paintingNumOne = int.Parse(tokens[1]);
                    int paintingNumTwo = int.Parse(tokens[2]);

                    if(numbers.Contains(paintingNumOne) && numbers.Contains(paintingNumTwo))
                    {
                        int one = numbers.IndexOf(paintingNumOne);
                        int two = numbers.IndexOf(paintingNumTwo);

                        numbers[one] = paintingNumTwo;
                        numbers[two] = paintingNumOne;
                    }
                }
                else if(command == "Insert")
                {
                    int place = int.Parse(tokens[1]);
                    int paintingNum = int.Parse(tokens[2]);

                    if(place >= -1 && place < numbers.Count - 1)
                    {
                        numbers.Insert(place+1, paintingNum);
                    }
                }
                else if(command == "Reverse")
                {
                    numbers.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
