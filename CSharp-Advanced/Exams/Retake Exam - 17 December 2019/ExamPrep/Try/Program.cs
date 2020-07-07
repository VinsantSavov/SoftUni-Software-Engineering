using System;
using System.Linq;

namespace Try
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            matrix[2, 2] = 2;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
