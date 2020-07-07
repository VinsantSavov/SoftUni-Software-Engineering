using System;
using System.Linq;

namespace _1.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int sum = 0;

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row< rows; row++)
            {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            foreach (var num in matrix)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
