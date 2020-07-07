using System;
using System.Linq;

namespace _4.SymbolMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            bool isPresented = false;
            bool haveToBreak = false;

            for (int row = 0; row < n; row++)
            {
                char[] symbols = Console.ReadLine().ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            int currRow = 0;
            int currCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if(matrix[row,col] == symbol)
                    {
                        currRow = row;
                        currCol = col;
                        isPresented = true;
                        haveToBreak = true;
                        break;
                    }
                    if (haveToBreak)
                    {
                        break;
                    }
                }
                if (haveToBreak)
                {
                    break;
                }
            }

            if (isPresented)
            {
                Console.WriteLine($"({currRow}, {currCol})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
