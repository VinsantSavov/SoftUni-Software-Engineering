using System;
using System.Linq;

namespace _2.NumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                if(command == "Switch")
                {
                    int index = int.Parse(tokens[1]);
                    if(index >= 0 && index < numbers.Length)
                    {
                        numbers[index] = -numbers[index];
                    }
                }
                else if(command == "Change")
                {
                    int index = int.Parse(tokens[1]);
                    int value = int.Parse(tokens[2]);

                    if (index >= 0 && index < numbers.Length)
                    {
                        numbers[index] = value;
                    }
                }
                else if(command == "Sum")
                {
                    if(tokens[1] == "Negative")
                    {
                        int negativeSum = 0;
                        foreach (var num in numbers)
                        {
                            if (num < 0)
                            {
                                negativeSum += num;
                            }
                        }

                        Console.WriteLine(negativeSum);
                    }
                    else if(tokens[1] == "Positive")
                    {
                        int positiveSum = 0;

                        foreach (var num in numbers)
                        {
                            if (num > 0)
                            {
                                positiveSum += num;
                            }
                        }

                        Console.WriteLine(positiveSum);
                    }
                    else if(tokens[1] == "All")
                    {
                        int sum = 0;
                        foreach (var num in numbers)
                        {
                            sum += num;
                        }
                        Console.WriteLine(sum);
                    }
                    
                }
                
            }
            foreach (var num in numbers)
            {
                if(num >= 0)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
