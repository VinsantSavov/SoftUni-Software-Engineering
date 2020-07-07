using System;

namespace _7.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascal = new long[n][];

            if (n >= 1)
            {
                pascal[0] = new long[] { 1 };
            }
            if (n >= 2)
            {
                pascal[1] = new long[] { 1, 1 };
            }

            for (int row = 2; row < n; row++)
            {
                pascal[row] = new long[row + 1];
                pascal[row][0] = 1;
                pascal[row][row] = 1;

                for (int col = 1; col < row; col++)
                {
                    pascal[row][col] = pascal[row - 1][col - 1] + pascal[row - 1][col];
                }

            }

            foreach (var line in pascal)
            {
                Console.WriteLine(string.Join(" ", line));
            }
        }
    }
}
