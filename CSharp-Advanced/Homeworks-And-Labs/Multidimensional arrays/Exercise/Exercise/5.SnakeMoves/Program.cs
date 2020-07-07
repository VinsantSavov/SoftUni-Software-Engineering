using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            string snakePath = snake;

            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];

            for (int i = 0; i <= cols + rows; i++)
            {
                snakePath += snake;
            }

            for (int row = 0; row < rows; row++)
            {
                if(row == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snakePath[0];
                        snakePath = snakePath.Remove(0, 1);
                    }
                }
                else if(row % 2 == 0 && row != 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snakePath[0];
                        snakePath = snakePath.Remove(0, 1);
                    }
                }
                else if(row % 2 != 0)
                {
                    int counter = 0;

                    for (int col = cols-1; col >= 0; col--)
                    {
                        matrix[row, col] = snakePath[counter];
                        counter++;
                    }
                    snakePath = snakePath.Remove(0, cols);
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
