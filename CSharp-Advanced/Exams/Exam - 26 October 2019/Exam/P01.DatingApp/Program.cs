using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.DatingApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] secondInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            firstInput = firstInput.Where(m => m > 0).ToArray();
            secondInput = secondInput.Where(m => m > 0).ToArray();

            Stack<int> males = new Stack<int>(firstInput);
            Queue<int> females = new Queue<int>(secondInput);

            int matches = 0;

            while (males.Count > 0 && females.Count > 0)
            {
                int male = males.Peek();
                int female = females.Peek();

                bool nextCycle = checkIfNegativeOrZero(males, females, male, female);

                if (nextCycle)
                {
                    continue;
                }

                bool anotherCycle = checkIfItIs25(males, females, male, female);

                if (anotherCycle)
                {
                    continue;
                }

                if (male == female)
                {
                    males.Pop();
                    females.Dequeue();
                    matches++;
                }
                else if (male != female && males.Any() && females.Any())
                {
                    females.Dequeue();
                    male = males.Pop();
                    male -= 2;
                    List<int> temp = new List<int>();

                    foreach (var person in males.Reverse())
                    {
                        temp.Add(person);
                    }

                    temp.Add(male);
                    males.Clear();

                    foreach (var person in temp)
                    {
                        males.Push(person);
                    }
                }
            }

            Console.WriteLine($"Matches: {matches}");

            if (males.Count <= 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.Write("Males left: ");
                Console.WriteLine(string.Join(", ", males));
            }

            if (females.Count <= 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.Write("Females left: ");
                Console.WriteLine(string.Join(", ", females));
            }
        }

        public static bool checkIfNegativeOrZero(Stack<int> males, Queue<int> females, int male, int female)
        {
            bool removed = false;

            if (male <= 0)
            {
                removed = true;
                males.Pop();
            }
            if (female <= 0)
            {
                removed = true;
                females.Dequeue();
            }

            return removed;
        }

        public static bool checkIfItIs25(Stack<int> males, Queue<int> females, int male, int female)
        {
            bool popped = false;

            if (male % 25 == 0)
            {
                males.Pop();
                if (males.Any())
                {
                    male = males.Peek();

                    while (males.Any())
                    {
                        if (male % 25 == 0)
                        {
                            males.Pop();
                            popped = true;
                        }
                        else
                        {
                            males.Pop();
                            popped = true;
                            break;
                        }
                        males.TryPeek(out male);
                    }
                }
                else
                {
                    popped = true;
                }
         
            }
            if (female % 25 == 0)
            {
                females.Dequeue();

                if (females.Any())
                {
                    female = females.Peek();

                    while (females.Any())
                    {
                        if (female % 25 == 0)
                        {
                            females.Dequeue();
                            popped = true;
                        }
                        else
                        {
                            females.Dequeue();
                            popped = true;
                            break;
                        }
                        females.TryPeek(out female);
                    }
                }
                else
                {
                    popped = true;
                }
            }

            return popped;
        }
    }
}
