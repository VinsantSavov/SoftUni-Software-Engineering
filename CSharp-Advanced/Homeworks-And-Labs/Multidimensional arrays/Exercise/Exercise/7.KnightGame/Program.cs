using System;

namespace _7.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int knightsInCircle = 0;
            int maxKnights = 0;
            int knightRow = 0;
            int knightCol = 0;
            int count = 0;
            bool isEnough = true;

            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            while (true)
            {
                isEnough = false;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            /*if(IsValid(row-2,col+1,matrix) || IsValid(row - 2, col - 1, matrix)
                                || IsValid(row + 2, col + 1, matrix) || IsValid(row + 2, col - 1, matrix) 
                                || IsValid(row - 1, col - 1, matrix) || IsValid(row - 1, col + 1, matrix) 
                                || IsValid(row + 1, col - 1, matrix) || IsValid(row + 1, col + 1, matrix))
                            {
                                knightsInCircle++;
                            }*/

                            knightsInCircle = 0;

                            if (IsValid(row - 2, col + 1, matrix))
                            {
                                knightsInCircle++;
                                isEnough = true;
                            }
                            if (IsValid(row - 2, col - 1, matrix))
                            {
                                knightsInCircle++;
                                isEnough = true;
                            }
                            if (IsValid(row + 2, col + 1, matrix))
                            {
                                knightsInCircle++;
                                isEnough = true;
                            }
                            if (IsValid(row + 2, col - 1, matrix))
                            {
                                knightsInCircle++;
                                isEnough = true;
                            }
                            if (IsValid(row - 1, col - 2, matrix))
                            {
                                knightsInCircle++;
                                isEnough = true;
                            }
                            if (IsValid(row - 1, col + 2, matrix))
                            {
                                knightsInCircle++;
                                isEnough = true;
                            }
                            if (IsValid(row + 1, col - 2, matrix))
                            {
                                knightsInCircle++;
                                isEnough = true;
                            }
                            if (IsValid(row + 1, col + 2, matrix))
                            {
                                knightsInCircle++;
                                isEnough = true;
                            }

                            if (knightsInCircle > maxKnights)
                            {
                                maxKnights = knightsInCircle;
                                knightRow = row;
                                knightCol = col;
                            }
                        }
                    }
                }

                if (isEnough == false)
                {
                    break;
                }
                else
                {
                    matrix[knightRow, knightCol] = '0';
                    maxKnights = 0;
                    count++;
                }
            }


            Console.WriteLine(count);

        }

        public static bool IsValid(int row, int col, char[,] matrix)
        {
            bool isValid = false;

            if (row > 0 && row < matrix.GetLength(0) && col > 0 && col < matrix.GetLength(1) && matrix[row, col] == 'K')
            {
                isValid = true;
            }

            return isValid;
        }

    }
}
