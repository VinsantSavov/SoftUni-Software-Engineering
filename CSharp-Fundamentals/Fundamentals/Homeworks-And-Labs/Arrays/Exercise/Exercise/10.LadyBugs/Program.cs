using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            foreach (var index in bugsIndexes)
            {
                if(index<0 || index > fieldSize - 1)
                {
                    continue;
                }
                field[index] = 1;
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] commands = input.Split();

                int ladyBugIndex = int.Parse(commands[0]);
                string direction = commands[1];
                int flyLength = int.Parse(commands[2]);

                if(ladyBugIndex < 0 || ladyBugIndex >= fieldSize-1 || field[ladyBugIndex] != 1)
                {
                    continue;
                }

                if(direction == "right")
                {
                    field[ladyBugIndex] = 0;
                    int newIndex = ladyBugIndex + flyLength;

                    while (newIndex < fieldSize)
                    {
                        if(field[newIndex] == 1)
                        {
                            newIndex += flyLength;
                            continue;
                        }
                            field[newIndex] = 1;
                            break;
                    }
                }
                else if(direction == "left")
                {
                    field[ladyBugIndex] = 0;
                    int newIndex = ladyBugIndex - flyLength;

                    while (newIndex >= 0)
                    {
                        if (field[newIndex] == 1)
                        {
                            newIndex -= flyLength;
                            continue;
                        }
                            field[newIndex] = 1;
                            break;
                    }
                }

            }
            Console.WriteLine(string.Join(" ",field));
        }
    }
}
