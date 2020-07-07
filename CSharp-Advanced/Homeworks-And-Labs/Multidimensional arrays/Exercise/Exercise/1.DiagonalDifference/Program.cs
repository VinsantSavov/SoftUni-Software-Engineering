using System;
using System.Linq;

namespace _1.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int sumPrimary = 0;
            int sumSecond = 0;
            int k = n-1;

            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if(row == col)
                    {
                        sumPrimary += matrix[row, col];
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = n-1; col >= 0; col--)
                {
                    if(col == k)
                    {
                        sumSecond += matrix[row, col];
                        k--;
                        break;
                    }
                }
            }

            int difference = Math.Abs(sumPrimary - sumSecond);
            Console.WriteLine(difference);
        }
    }
}
