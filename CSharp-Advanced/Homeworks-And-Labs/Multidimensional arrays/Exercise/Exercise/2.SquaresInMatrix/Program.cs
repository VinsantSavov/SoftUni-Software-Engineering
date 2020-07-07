using System;
using System.Linq;

namespace _2.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];
            int count = 0;

            for (int row = 0; row < rows; row++)
            {
                char[] symbols = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }


            for (int row = 0; row < rows -1; row++)
            {
                for (int col = 0; col < cols -1; col++)
                {
                    if(matrix[row, col] == matrix[row, col+1] 
                        && matrix[row,col+1] == matrix[row+1,col] 
                        && matrix[row + 1, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
