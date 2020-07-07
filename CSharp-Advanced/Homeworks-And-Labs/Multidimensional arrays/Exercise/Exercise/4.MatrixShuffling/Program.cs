using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] texts = Console.ReadLine().Split().ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = texts[col];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                string[] commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands.Length < 5 || commands.Length > 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = int.Parse(commands[1]);
                int col1 = int.Parse(commands[2]);
                int row2 = int.Parse(commands[3]);
                int col2 = int.Parse(commands[4]);

                if (commands[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (row1 < 0 || col1 < 0 || row2 < 0 || col2 < 0 || row1 >= rows || col1 >= cols || row2 >= rows || col2 >= cols)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}
