using System;
using System.Linq;

namespace _5.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            int squareSum = 0;
            int maxSum = int.MinValue;
            int topLeft = 0;
            int topRight = 0;
            int bottomLeft = -0;
            int bottomRight = 0;

            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    squareSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if(squareSum > maxSum)
                    {
                        topLeft = matrix[row, col];
                        topRight = matrix[row, col + 1];
                        bottomLeft = matrix[row + 1, col];
                        bottomRight = matrix[row + 1, col + 1];
                        maxSum = squareSum;
                    }
                }
            }
            Console.WriteLine(topLeft + " " + topRight);
            Console.WriteLine(bottomLeft + " " + bottomRight);
            Console.WriteLine(maxSum);

        }
    }
}
