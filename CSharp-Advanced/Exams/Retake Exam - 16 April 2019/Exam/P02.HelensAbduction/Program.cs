using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.HelensAbduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            string[][] field = new string[rows][];

            List<int> coordinates = GenerateField(field, rows);
            int helenRow = coordinates[0];
            int helenCol = coordinates[1];
            int parisRow = coordinates[2];
            int parisCol = coordinates[3];
            bool savedHelen = false;

            while(energy > 0)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = info[0];
                int enemyRow = int.Parse(info[1]);
                int enemyCol = int.Parse(info[2]);

                SpawningSpartans(field, enemyRow, enemyCol);

                if(command == "up")
                {
                    if(parisRow -1 >= 0 && energy -1 > 0)
                    {
                        parisRow--;

                        if(field[parisRow][parisCol] == "-")
                        {
                            field[parisRow][parisCol] = "P";
                            field[parisRow + 1][parisCol] = "-";
                            energy--;
                        }
                        else if(field[parisRow][parisCol] == "S")
                        {
                            if(energy - 3 > 0)
                            {
                                field[parisRow][parisCol] = "P";
                                field[parisRow + 1][parisCol] = "-";
                                energy -= 3;
                            }
                            else
                            {
                                field[parisRow][parisCol] = "X";
                                field[parisRow+1][parisCol] = "-";
                                energy -= 3;
                                break;
                            }
                        }
                        else if(field[parisRow][parisCol] == "H")
                        {
                            field[parisRow + 1][parisCol] = "-";
                            field[helenRow][helenCol] = "-";
                            savedHelen = true;
                            energy--;
                            break;
                        }
                    }
                    else
                    {
                        if(--energy <= 0 && parisRow - 1 >= 0)
                        {
                            parisRow--;
                            field[parisRow][parisCol] = "X";
                            field[parisRow+1][parisCol] = "-";
                        }
                    }
                }
                else if(command == "down")
                {
                    if (parisRow + 1 < rows && energy - 1 > 0)
                    {
                        parisRow++;

                        if (field[parisRow][parisCol] == "-")
                        {
                            field[parisRow][parisCol] = "P";
                            field[parisRow - 1][parisCol] = "-";
                            energy--;
                        }
                        else if (field[parisRow][parisCol] == "S")
                        {
                            if (energy - 3 > 0)
                            {
                                field[parisRow][parisCol] = "P";
                                field[parisRow - 1][parisCol] = "-";
                                energy -= 3;
                            }
                            else
                            {
                                field[parisRow][parisCol] = "X";
                                field[parisRow - 1][parisCol] = "-";
                                energy -= 3;
                                break;
                            }
                        }
                        else if (field[parisRow][parisCol] == "H")
                        {
                            field[parisRow - 1][parisCol] = "-";
                            field[helenRow][helenCol] = "-";
                            savedHelen = true;
                            energy--;
                            break;
                        }
                    }
                    else
                    {
                        if (--energy <= 0 && parisRow + 1 < rows)
                        {
                            parisRow++;
                            field[parisRow][parisCol] = "X";
                            field[parisRow-1][parisCol] = "-";
                        }
                    }
                }
                else if(command == "left")
                {
                    if (parisCol - 1 >= 0 && energy - 1 > 0)
                    {
                        parisCol--;

                        if (field[parisRow][parisCol] == "-")
                        {
                            field[parisRow][parisCol] = "P";
                            field[parisRow][parisCol+1] = "-";
                            energy--;
                        }
                        else if (field[parisRow][parisCol] == "S")
                        {
                            if (energy - 3 > 0)
                            {
                                field[parisRow][parisCol] = "P";
                                field[parisRow][parisCol+1] = "-";
                                energy -= 3;
                            }
                            else
                            {
                                field[parisRow][parisCol] = "X";
                                field[parisRow][parisCol + 1] = "-";
                                energy -= 3;
                                break;
                            }
                        }
                        else if (field[parisRow][parisCol] == "H")
                        {
                            field[parisRow][parisCol+1] = "-";
                            field[helenRow][helenCol] = "-";
                            savedHelen = true;
                            energy--;
                            break;
                        }
                    }
                    else
                    {
                        if (--energy <= 0 && parisCol - 1 >= 0)
                        {
                            parisCol--;
                            field[parisRow][parisCol] = "X";
                            field[parisRow][parisCol+1] = "-";
                        }
                    }
                }
                else if(command == "right")
                {
                    if (parisCol + 1 < rows && energy - 1 > 0)
                    {
                        parisCol++;

                        if (field[parisRow][parisCol] == "-")
                        {
                            field[parisRow][parisCol] = "P";
                            field[parisRow][parisCol - 1] = "-";
                            energy--;
                        }
                        else if (field[parisRow][parisCol] == "S")
                        {
                            if (energy - 3 > 0)
                            {
                                field[parisRow][parisCol] = "P";
                                field[parisRow][parisCol - 1] = "-";
                                energy -= 3;
                            }
                            else
                            {
                                field[parisRow][parisCol] = "X";
                                field[parisRow][parisCol - 1] = "-";
                                energy -= 3;
                                break;
                            }
                        }
                        else if (field[parisRow][parisCol] == "H")
                        {
                            field[parisRow][parisCol - 1] = "-";
                            field[helenRow][helenCol] = "-";
                            savedHelen = true;
                            energy--;
                            break;
                        }
                    }
                    else
                    {
                        if (--energy <= 0 && parisCol + 1 < rows)
                        {
                            parisCol++;
                            field[parisRow][parisCol] = "X";
                            field[parisRow][parisCol-1] = "-";
                        }
                    }
                }

            }

            if(energy <= 0)
            {
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
            }

            if (savedHelen)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
            }

            PrintField(field, rows);
        }

        public static List<int> GenerateField(string[][] field, int rows)
        {
            List<int> coordinates = new List<int>();
            int helenRow = 0;
            int helenCol = 0;
            int parisRow = 0;
            int parisCol = 0;

            for (int r = 0; r < rows; r++)
            {
                string line = Console.ReadLine();
                field[r] = new string[line.Length];

                for (int c = 0; c < field[r].Length; c++)
                {
                    field[r][c] = line[c].ToString();

                    if(line[c].ToString() == "H")
                    {
                        helenRow = r;
                        helenCol = c;
                    }
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < field[r].Length; c++)
                {
                    if(field[r][c] == "P")
                    {
                        parisRow = r;
                        parisCol = c;
                    }
                }
            }

            coordinates.Add(helenRow);
            coordinates.Add(helenCol);
            coordinates.Add(parisRow);
            coordinates.Add(parisCol);

            return coordinates;
        }

        public static void SpawningSpartans(string[][] field, int enemyRow, int enemyCol)
        {
            field[enemyRow][enemyCol] = "S";
        }

        public static void PrintField(string[][] field, int rows)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < field[r].Length; c++)
                {
                    Console.Write(field[r][c]);
                }
                Console.WriteLine();
            }
        }
    }
}
