using System;

namespace _4.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);

        }

        public static void PrintLine(int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        public static void PrintTriangle(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }
            for(int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
