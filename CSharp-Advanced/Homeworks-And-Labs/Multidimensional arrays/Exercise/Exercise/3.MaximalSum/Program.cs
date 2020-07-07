using System;
using System.Linq;

namespace _3.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];
            int[,] biggestMatrix = new int[3, 3];
            int[,] tempMatrix = new int[3, 3];
            long maxSum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            if(rows > 3 && cols > 3)
            {
                for (int row = 0; row <= rows - 3; row++)
                {
                    for (int col = 0; col <= cols - 3; col++)
                    {
                        long sum = Sum(row, col, matrix);


                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            biggestMatrix = BiggestMatrix(row, col, matrix, tempMatrix);
                        }
                    }
                }
            }
            else
            {
                biggestMatrix = matrix;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        maxSum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(biggestMatrix[i,j] +" ");
                }
                Console.WriteLine();
            }
        }

        public static long Sum(int row, int col, int[,] matrix)
        {
            long sum = 0;

            for (int i = row; i < row+3; i++)
            {
                for (int j = col; j < col+3; j++)
                {
                    sum += matrix[i, j];

                }
            }

            return sum;
        }

        public static int[,] BiggestMatrix(int row, int col, int[,] matrix, int[,] tempMatrix)
        {
            int r = 0;
            int c = 0;

            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    tempMatrix[r, c] = matrix[i, j];
                    c++;
                }
                r++;
                c = 0;
            }

            return tempMatrix;
        }
    }
}
