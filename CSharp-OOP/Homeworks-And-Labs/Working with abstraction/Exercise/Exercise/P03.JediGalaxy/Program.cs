using System;
using System.Linq;

namespace P03.JediGalaxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] matrixInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixInfo[0];
            int cols = matrixInfo[1];

            int[,] matrix = new int[rows, cols];
            GenerateMatrix(matrix, rows, cols);

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "Let the Force be with you")
                {
                    break;
                }

                int[] ivoCoordinates = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .Select(int.Parse)
                                              .ToArray();
                RowCol ivoCoordinates = new RowCol

                int[] evilCoordinates = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .Select(int.Parse)
                                              .ToArray();

                int ivoRow = ivoCoordinates[0];
                int 
            }
        }

        public static void GenerateMatrix(int[,] matrix, int rows, int cols)
        {
            int num = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = num;
                    num++;
                }
            }
        }
    }
}
