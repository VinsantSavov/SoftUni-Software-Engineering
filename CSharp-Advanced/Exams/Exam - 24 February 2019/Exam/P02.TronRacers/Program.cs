using System;
using System.Collections.Generic;

namespace P02.TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];
            bool bothAreAlive = true;

            List<int> coordinates = GenerateMatrix(matrix, size);
            int firstRow = coordinates[0];
            int firstCol = coordinates[1];
            int secondRow = coordinates[2];
            int secondCol = coordinates[3];

            while(bothAreAlive)
            {
                string[] commands = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string firstCommand = commands[0];
                string secondCommand = commands[1];

                if(firstCommand == "up")
                {
                    if(firstRow-1 >= 0)
                    {
                        if(matrix[firstRow-1, firstCol] == "s")
                        {
                            bothAreAlive = false;
                            matrix[firstRow - 1, firstCol] = "x";
                            continue;
                        }
                        else
                        {
                            firstRow--;
                            matrix[firstRow, firstCol] = "f";
                        }
                    }
                    else
                    {
                        if(matrix[size-1, firstCol] == "s")
                        {
                            bothAreAlive = false;
                            matrix[size - 1, firstCol] = "x";
                            continue;
                        }
                        else
                        {
                            firstRow = size - 1;
                            matrix[firstRow, firstCol] = "f";
                        }
                    }
                }
                else if(firstCommand == "down")
                {
                    if (firstRow + 1 < size)
                    {
                        if (matrix[firstRow + 1, firstCol] == "s")
                        {
                            bothAreAlive = false;
                            matrix[firstRow + 1, firstCol] = "x";
                            continue;
                        }
                        else
                        {
                            firstRow++;
                            matrix[firstRow, firstCol] = "f";
                        }
                    }
                    else
                    {
                        if (matrix[0, firstCol] == "s")
                        {
                            bothAreAlive = false;
                            matrix[0, firstCol] = "x";
                            continue;
                        }
                        else
                        {
                            firstRow = 0;
                            matrix[firstRow, firstCol] = "f";
                        }
                    }
                }
                else if(firstCommand == "right")
                {
                    if(firstCol +1 < size)
                    {
                        if(matrix[firstRow, firstCol+1] == "s")
                        {
                            bothAreAlive = false;
                            matrix[firstRow, firstCol + 1] = "x";
                            continue;
                        }
                        else
                        {
                            firstCol++;
                            matrix[firstRow, firstCol] = "f";
                        }
                    }
                    else
                    {
                        if(matrix[firstRow,0] == "s")
                        {
                            bothAreAlive = false;
                            matrix[firstRow, 0] = "x";
                            continue;
                        }
                        else
                        {
                            firstCol = 0;
                            matrix[firstRow, firstCol] = "f";
                        }
                    }
                }
                else if(firstCommand == "left")
                {
                    if (firstCol - 1 >= 0)
                    {
                        if (matrix[firstRow, firstCol - 1] == "s")
                        {
                            bothAreAlive = false;
                            matrix[firstRow, firstCol - 1] = "x";
                            continue;
                        }
                        else
                        {
                            firstCol--;
                            matrix[firstRow, firstCol] = "f";
                        }
                    }
                    else
                    {
                        if (matrix[firstRow, size-1] == "s")
                        {
                            bothAreAlive = false;
                            matrix[firstRow, size - 1] = "x";
                            continue;
                        }
                        else
                        {
                            firstCol = size-1;
                            matrix[firstRow, firstCol] = "f";
                        }
                    }
                }

                if(secondCommand == "up")
                {
                    if (secondRow - 1 >= 0)
                    {
                        if (matrix[secondRow - 1, secondCol] == "f")
                        {
                            bothAreAlive = false;
                            matrix[secondRow - 1, secondCol] = "x";
                            continue;
                        }
                        else
                        {
                            secondRow--;
                            matrix[secondRow, secondCol] = "s";
                        }
                    }
                    else
                    {
                        if (matrix[size - 1, secondCol] == "f")
                        {
                            bothAreAlive = false;
                            matrix[size - 1, secondCol] = "x";
                            continue;
                        }
                        else
                        {
                            secondRow = size - 1;
                            matrix[secondRow, secondCol] = "s";
                        }
                    }
                }
                else if(secondCommand == "down")
                {
                    if (secondRow + 1 < size)
                    {
                        if (matrix[secondRow + 1, secondCol] == "f")
                        {
                            bothAreAlive = false;
                            matrix[secondRow + 1, secondCol] = "x";
                            continue;
                        }
                        else
                        {
                            secondRow++;
                            matrix[secondRow, secondCol] = "s";
                        }
                    }
                    else
                    {
                        if (matrix[0, secondCol] == "f")
                        {
                            bothAreAlive = false;
                            matrix[0, secondCol] = "x";
                            continue;
                        }
                        else
                        {
                            secondRow = 0;
                            matrix[secondRow, secondCol] = "s";
                        }
                    }
                }
                else if(secondCommand == "right")
                {
                    if (secondCol + 1 < size)
                    {
                        if (matrix[secondRow, secondCol + 1] == "f")
                        {
                            bothAreAlive = false;
                            matrix[secondRow, secondCol + 1] = "x";
                            continue;
                        }
                        else
                        {
                            secondCol++;
                            matrix[secondRow, secondCol] = "s";
                        }
                    }
                    else
                    {
                        if (matrix[secondRow, 0] == "f")
                        {
                            bothAreAlive = false;
                            matrix[secondRow, 0] = "x";
                            continue;
                        }
                        else
                        {
                            secondCol = 0;
                            matrix[secondRow, secondCol] = "s";
                        }
                    }
                }
                else if(secondCommand == "left")
                {
                    if (secondCol - 1 >= 0)
                    {
                        if (matrix[secondRow, secondCol - 1] == "f")
                        {
                            bothAreAlive = false;
                            matrix[secondRow, secondCol - 1] = "x";
                            continue;
                        }
                        else
                        {
                            secondCol--;
                            matrix[secondRow, secondCol] = "s";
                        }
                    }
                    else
                    {
                        if (matrix[secondRow, size - 1] == "f")
                        {
                            bothAreAlive = false;
                            matrix[secondRow, size - 1] = "x";
                            continue;
                        }
                        else
                        {
                            secondCol = size - 1;
                            matrix[secondRow, secondCol] = "s";
                        }
                    }
                }
            }

            Print(matrix, size);
        }

        public static List<int> GenerateMatrix(string[,] matrix, int size)
        {
            List<int> coordinates = new List<int>();

            for (int r = 0; r < size; r++)
            {
                string line = Console.ReadLine();

                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = line[c].ToString();

                    if(line[c] == 'f')
                    {
                        coordinates.Add(r);
                        coordinates.Add(c);
                    }
                    // ako sa razmeneni
                }
            }

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    if(matrix[r,c] == "s")
                    {
                        coordinates.Add(r);
                        coordinates.Add(c);
                    }
                }
            }

            return coordinates; 
        }

        public static void Print(string[,] matrix, int size)
        {
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Console.Write(matrix[r,c]);
                }
                Console.WriteLine();
            }
        }
    }
}
