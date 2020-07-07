using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] array = new double[n][];

            for (int row = 0; row < n; row++)
            {
                double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
                array[row] = new double[numbers.Length];
                array[row] = numbers;
            }

            for (int row = 0; row < n-1; row++)
            {
                if(array[row].Length == array[row + 1].Length)
                {
                    for (int col = 0; col < array[row].Length; col++)
                    {
                        array[row][col] *= 2;
                        array[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < array[row].Length; col++)
                    {
                        array[row][col] /= 2;
                    }
                    for (int col = 0; col < array[row+1].Length; col++)
                    {
                        array[row + 1][col] /= 2;
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                string[] commands = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commands[0];
                int r = int.Parse(commands[1]);
                int c = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                if (r < 0 || r >= array.Length || c < 0 || c >= array[r].Length)
                {
                    continue;
                }
                else
                {
                    if (command == "Add")
                    {
                        array[r][c] += value;
                    }
                    else if(command == "Subtract")
                    {
                        array[r][c] -= value;
                    }
                }
                
            }

            foreach (var line in array)
            {
                Console.WriteLine(string.Join(" ",line));
            }
        }
    }
}
