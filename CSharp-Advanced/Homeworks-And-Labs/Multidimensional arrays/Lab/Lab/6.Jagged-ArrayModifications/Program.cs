using System;
using System.Linq;

namespace _6.Jagged_ArrayModifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                string[] commands = input.Split().ToArray();
                string command = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                if(row >= matrix.GetLength(0) || col >= matrix.GetLength(1) || row < 0 || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if(command == "Add")
                    {
                        matrix[row, col] += value;
                    }
                    else if(command == "Subtract")
                    {
                        matrix[row, col] -= value;
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
