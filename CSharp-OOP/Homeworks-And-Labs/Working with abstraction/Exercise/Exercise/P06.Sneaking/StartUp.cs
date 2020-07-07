using System;
using System.Collections.Generic;

namespace P06.Sneaking
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            string[][] field = new string[rows][];
            GenerateMatrix(field, rows);
            List<int> samCoordinates = FindCoordinates(field, rows, "S");
            int samRow = samCoordinates[0];
            int samCol = samCoordinates[1];
            List<int> nikCoordinates = FindCoordinates(field, rows, "N");
            int nikRow = nikCoordinates[0];
            int nikCol = nikCoordinates[1];

            bool samDied = false;
            bool nikoladzeKilled = false;

            char[] directions = Console.ReadLine().ToCharArray();

            for (int d = 0; d < directions.Length; d++)
            {
                if (NikoladzeRow(samRow, nikRow))
                {
                    field[nikRow][nikCol] = "X";
                    field[samRow][samCol] = "S";
                    nikoladzeKilled = true;
                    break;
                }

                field[samRow][samCol] = ".";
                MovingEnemies(field, rows);

                if (directions[d] == 'U')
                {
                   
                    if (FindingEnemy(field, samRow, samCol))
                    {
                        samDied = true;
                        field[samRow][samCol] = "X";
                        break;
                    }
                    else if (field[samRow - 1][samCol] == "b" || field[samRow - 1][samCol] == "d")
                    {
                        samRow--;
                        field[samRow][samCol] = "S";
                    }
                    else
                    {
                        samRow--;
                    }
                }
                else if (directions[d] == 'D')
                {
                    if (FindingEnemy(field, samRow, samCol))
                    {
                        samDied = true;
                        field[samRow][samCol] = "X";
                        break;
                    }
                    else if (field[samRow + 1][samCol] == "b" || field[samRow + 1][samCol] == "d")
                    {
                        samRow++;
                        field[samRow][samCol] = "S";
                    }
                    else
                    {
                        samRow++;
                    }
                }
                else if (directions[d] == 'R')
                {
                    if (field[samRow][samCol + 1] == "b" || field[samRow][samCol + 1] == "d")
                    {
                        samCol++;
                        field[samRow][samCol] = "S";
                    }
                    else if (FindingEnemy(field, samRow, samCol))
                    {
                        samDied = true;
                        field[samRow][samCol] = "X";
                        break;
                    }
                    else
                    {
                        samCol++;
                    }
                }
                else if (directions[d] == 'L')
                {
                    if (field[samRow][samCol - 1] == "b" || field[samRow][samCol - 1] == "d")
                    {
                        samCol--;
                        field[samRow][samCol] = "S";
                    }
                    else if (FindingEnemy(field, samRow, samCol))
                    {
                        samDied = true;
                        field[samRow][samCol] = "X";
                        break;
                    }
                    else
                    {
                        samCol--;
                    }
                }
                else if(directions[d] == 'W')
                {
                    field[samRow][samCol] = "S";
                    if (FindingEnemy(field, samRow, samCol))
                    {
                        samDied = true;
                        field[samRow][samCol] = "X";
                        break;
                    }
                }
            }

            if (NikoladzeRow(samRow, nikRow))
            {
                field[nikRow][nikCol] = "X";
                field[samRow][samCol] = "S";
                nikoladzeKilled = true;
            }

            if (samDied)
            {
                Console.WriteLine($"Sam died at {samRow}, {samCol}");
            }
            else if (nikoladzeKilled)
            {
                Console.WriteLine("Nikoladze killed!");
            }

            PrintField(field, rows);
        }

        public static void GenerateMatrix(string[][] field, int rows)
        {
            for (int r = 0; r < rows; r++)
            {
                string line = Console.ReadLine();
                field[r] = new string[line.Length];

                for (int c = 0; c < line.Length; c++)
                {
                    field[r][c] = line[c].ToString();
                }
            }
        }

        public static List<int> FindCoordinates(string[][] field, int rows, string type)
        {
            List<int> coordinates = new List<int>();

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < field[r].Length; c++)
                {
                    if(field[r][c] == type)
                    {
                        coordinates.Add(r);
                        coordinates.Add(c);
                    }
                }
            }

            return coordinates;
        }

        public static bool NikoladzeRow(int samRow, int nikRow) => samRow == nikRow;

        public static void MovingEnemies(string[][] field, int rows)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < field[r].Length; c++)
                {
                    if(field[r][c] == "b")
                    {
                        if(c + 1 < field[r].Length)
                        {
                            field[r][c] = ".";
                            field[r][c + 1] = "b";
                            break;
                        }
                        else if(c + 1 == field[r].Length) //field[r][c + 1].Length
                        {
                            field[r][c] = "d";
                            break;
                        }
                    }
                    else if(field[r][c] == "d")
                    {
                        if (c - 1 >= 0)
                        {
                            field[r][c] = ".";
                            field[r][c - 1] = "d";
                            break;
                        }
                        else if (c - 1 < 0)
                        {
                            field[r][c] = "b";
                            break;
                        }
                    }
                }
            }
        }

        public static bool FindingEnemy(string[][] field, int samRow, int samCol)
        {
            bool hasToDie = false;

            for (int c = 0; c < field[samRow].Length; c++)
            {
                if(field[samRow][c] == "b")
                {
                    if(c < samCol)
                    {
                        hasToDie = true;
                        break;
                    }
                }
                else if(field[samRow][c] == "d")
                {
                    if(c > samCol)
                    {
                        hasToDie = true;
                        break;
                    }
                }
            }

            return hasToDie;
        }

        public static void PrintField(string[][] field, int rows)
        {
            for (int r = 0; r < rows; r++)
            {
                Console.WriteLine(string.Join("", field[r]));
            }
        }
    }
}
