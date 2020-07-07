using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Another
{
    class Program
    {
        static void Main(string[] args)
        {
            int presentsCount = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            string[,] matrix = new string[size, size];
            bool ranOut = false;

            List<int> coordinates = GenerateMatrix(matrix, size);
            int countNiceKids = CountNiceKids(matrix, size);
            int all = countNiceKids;
            int santaRow = coordinates[0];
            int santaCol = coordinates[1];

            while (presentsCount > 0)
            {
                string command = Console.ReadLine();

                if (command == "Christmas morning")
                {
                    break;
                }

                if(command == "up")
                {
                    if(santaRow -1 >= 0)
                    {
                        santaRow--;
                        if(matrix[santaRow,santaCol] == "X")
                        {
                            matrix[santaRow, santaCol] = "S";
                        }
                        else if(matrix[santaRow, santaCol] == "V")
                        {
                            matrix[santaRow, santaCol] = "S";
                            countNiceKids--;
                            presentsCount--;
                        }
                        else if(matrix[santaRow, santaCol] == "C")
                        {
                            int givenPr = Cookie(matrix, santaRow, santaCol, ref countNiceKids);
                            presentsCount -= givenPr;
                            matrix[santaRow, santaCol] = "S";
                        }

                        matrix[santaRow + 1, santaCol] = "-";
                    }
                    //else
                    //{
                    //    matrix[santaRow, santaCol] = "-";
                    //    ranOut = true;
                    //}
                }
                else if(command == "down")
                {
                    if (santaRow + 1 < size)
                    {
                        santaRow++;
                        if (matrix[santaRow, santaCol] == "X")
                        {
                            matrix[santaRow, santaCol] = "S";
                        }
                        else if (matrix[santaRow, santaCol] == "V")
                        {
                            matrix[santaRow, santaCol] = "S";
                            countNiceKids--;
                            presentsCount--;
                        }
                        else if (matrix[santaRow, santaCol] == "C")
                        {
                            int givenPr = Cookie(matrix, santaRow, santaCol, ref countNiceKids);
                            presentsCount -= givenPr;
                            matrix[santaRow, santaCol] = "S";
                        }

                        matrix[santaRow - 1, santaCol] = "-";
                    }
                    //else
                    //{
                    //    matrix[santaRow, santaCol] = "-";
                    //    ranOut = true;
                    //}
                }
                else if(command == "left")
                {
                    if (santaCol - 1 >= 0)
                    {
                        santaCol--;
                        if (matrix[santaRow, santaCol] == "X")
                        {
                            matrix[santaRow, santaCol] = "S";
                        }
                        else if (matrix[santaRow, santaCol] == "V")
                        {
                            matrix[santaRow, santaCol] = "S";
                            countNiceKids--;
                            presentsCount--;
                        }
                        else if (matrix[santaRow, santaCol] == "C")
                        {
                            int givenPr = Cookie(matrix, santaRow, santaCol, ref countNiceKids);
                            presentsCount -= givenPr;
                            matrix[santaRow, santaCol] = "S";
                        }

                        matrix[santaRow, santaCol + 1] = "-";
                    }
                    //else
                    //{
                    //    matrix[santaRow, santaCol] = "-";
                    //    ranOut = true;
                    //}
                }
                else if(command == "right")
                {
                    if (santaCol + 1 < size)
                    {
                        santaCol++;
                        if (matrix[santaRow, santaCol] == "X")
                        {
                            matrix[santaRow, santaCol] = "S";
                        }
                        else if (matrix[santaRow, santaCol] == "V")
                        {
                            matrix[santaRow, santaCol] = "S";
                            countNiceKids--;
                            presentsCount--;
                        }
                        else if (matrix[santaRow, santaCol] == "C")
                        {
                            int givenPr = Cookie(matrix, santaRow, santaCol, ref countNiceKids);
                            presentsCount -= givenPr;
                            matrix[santaRow, santaCol] = "S";
                        }

                        matrix[santaRow, santaCol - 1] = "-";
                    }
                    //else
                    //{
                    //    matrix[santaRow, santaCol] = "-";
                    //    ranOut = true;
                    //}
                }
            }

            if (presentsCount <= 0)
            {
                Console.WriteLine("Santa ran out of presents!");
            }

            Print(matrix, size);

            if(countNiceKids == 0)
            {
                Console.WriteLine($"Good job, Santa! {all} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {countNiceKids} nice kid/s.");
            }
        }

        public static List<int> GenerateMatrix(string[,] matrix, int size)
        {
            List<int> coordinates = new List<int>();

            for (int r = 0; r < size; r++)
            {
                string[] line = Console.ReadLine().Split().ToArray();

                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = line[c];

                    if(line[c] == "S")
                    {
                        coordinates.Add(r);
                        coordinates.Add(c);
                    }
                }
            }

            return coordinates;
        }

        public static int CountNiceKids(string[,] matrix, int size)
        {
            int count = 0;

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    if(matrix[r,c] == "V")
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static int Cookie(string[,] matrix, int row, int col, ref int countNiceKids)
        {
            int givenPresent = 0;

            if(matrix[row+1,col] == "X")
            {
                matrix[row + 1, col] = "-";
                givenPresent++;
            }
            else if(matrix[row + 1, col] == "V")
            {
                matrix[row + 1, col] = "-";
                givenPresent++;
                countNiceKids--;
            }

            if(matrix[row - 1, col] == "X")
            {
                matrix[row - 1, col] = "-";
                givenPresent++;
            }
            else if (matrix[row - 1, col] == "V")
            {
                matrix[row - 1, col] = "-";
                givenPresent++;
                countNiceKids--;
            }

            if (matrix[row, col+1] == "X")
            {
                matrix[row, col+1] = "-";
                givenPresent++;
            }
            else if (matrix[row, col+1] == "V")
            {
                matrix[row, col+1] = "-";
                givenPresent++;
                countNiceKids--;
            }

            if (matrix[row, col - 1] == "X")
            {
                matrix[row, col - 1] = "-";
                givenPresent++;
            }
            else if (matrix[row, col - 1] == "V")
            {
                matrix[row, col - 1] = "-";
                givenPresent++;
                countNiceKids--;
            }

            return givenPresent;
        }

        public static void Print(string[,] matrix, int size)
        {
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Console.Write(matrix[r,c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
