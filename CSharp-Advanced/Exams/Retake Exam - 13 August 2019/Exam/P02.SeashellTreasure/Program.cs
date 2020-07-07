using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.SeashellTreasure
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            List<string> collectedShells = new List<string>();
            int stolenShellsCount = 0;

            string[][] beach = new string[rows][];
            GenerateBeach(beach, rows);

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Sunset")
                {
                    break;
                }

                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);

                if(command == "Collect")
                {
                    if(row >= 0 && row < rows && col >= 0 && col < beach[row].Length)
                    {
                        if(beach[row][col] != "-")
                        {
                            string shell = beach[row][col];
                            collectedShells.Add(shell);
                            beach[row][col] = "-";
                        }
                    }
                }
                else if(command == "Steal")
                {
                    string direction = commands[3];

                    if (row >= 0 && row < rows && col >= 0 && col < beach[row].Length)
                    {
                        if(beach[row][col] == "M" || beach[row][col] == "N" || beach[row][col] == "C")
                        {
                            beach[row][col] = "-";
                            stolenShellsCount++;
                        }

                        if (direction == "up")
                        {
                            bool first = false;
                            bool second = false;
                            if (row - 1 >= 0 && col < beach[row - 1].Length)
                            {
                                if(beach[row-1][col] != "-")
                                {
                                    stolenShellsCount++;
                                    beach[row - 1][col] = "-";
                                }
                                first = true;
                            }
                            if (row - 2 >= 0 && col < beach[row - 2].Length && first)
                            {
                                if (beach[row - 2][col] != "-")
                                {
                                    stolenShellsCount++;
                                    beach[row - 2][col] = "-";
                                }
                                second = true;
                            }
                            if (row - 3 >= 0 && col < beach[row - 3].Length && second)
                            {
                                if (beach[row - 3][col] != "-")
                                {
                                    stolenShellsCount++;
                                    beach[row - 3][col] = "-";
                                }
                            }
                        }
                        else if(direction == "down")
                        {
                            bool first = false;
                            bool second = false;
                            if (row + 1 < rows && col < beach[row + 1].Length)
                            {
                                if (beach[row + 1][col] != "-")
                                {
                                    stolenShellsCount++;
                                    beach[row + 1][col] = "-";
                                }
                                first = true;
                            }
                            if (row + 2 < rows && col < beach[row + 2].Length && first)
                            {
                                if (beach[row + 2][col] != "-")
                                {
                                    stolenShellsCount++;
                                    beach[row + 2][col] = "-";
                                }
                                second = true;
                            }
                            if (row + 3 < rows && col < beach[row + 3].Length && second)
                            {
                                if (beach[row + 3][col] != "-")
                                {
                                    stolenShellsCount++;
                                    beach[row + 3][col] = "-";
                                }
                            }
                        }
                        else if(direction == "left")
                        {
                            bool first = false;
                            bool second = false;

                            if (col - 1 >= 0)
                            {
                                if(beach[row][col-1] != "-")
                                {
                                    stolenShellsCount++;
                                    beach[row][col-1] = "-";
                                }
                                first = true;
                            }
                            if(col - 2 >= 0 && first)
                            {
                                if (beach[row][col - 2] != "-")
                                {
                                    stolenShellsCount++;
                                    beach[row][col - 2] = "-";
                                }
                                second = true;
                            }
                            if(col - 3 >= 0 && second)
                            {
                                if (beach[row][col - 3] != "-")
                                {
                                    stolenShellsCount++;
                                    beach[row][col - 3] = "-";
                                }
                            }
                        }
                        else if(direction == "right")
                        {
                            bool first = false;
                            bool second = false;

                            if (col + 1 < beach[row].Length)
                            {
                                if(beach[row][col+1] != "-")
                                {
                                    stolenShellsCount++;
                                    beach[row][col + 1] = "-";
                                }
                                first = true;
                            }
                            if (col + 2 < beach[row].Length && first)
                            {
                                if (beach[row][col + 2] != "-")
                                {
                                    stolenShellsCount++;
                                    beach[row][col + 2] = "-";
                                }
                                second = true;
                            }
                            if (col + 3 < beach[row].Length && second)
                            {
                                if (beach[row][col + 3] != "-")
                                {
                                    stolenShellsCount++;
                                    beach[row][col + 3] = "-";
                                }
                            }
                        }
                    }                   
                }
            }

            PrintBeach(beach, rows);

            if(collectedShells.Count == 0)
            {
                Console.WriteLine("Collected seashells: 0");
            }
            else
            {
                Console.Write($"Collected seashells: {collectedShells.Count} -> ");
                Console.WriteLine(string.Join(", ", collectedShells));
            }

            Console.WriteLine($"Stolen seashells: {stolenShellsCount}");
        }

        public static void GenerateBeach(string[][] beach, int rows)
        {
            for (int r = 0; r < rows; r++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                beach[r] = new string[line.Length];
                beach[r] = line;
            }
        }

        public static void PrintBeach(string[][] beach, int rows)
        {
            for (int r = 0; r < rows; r++)
            {
                Console.WriteLine(string.Join(" ", beach[r]));
            }
        }
    }
}
