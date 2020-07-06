using System;
using System.Numerics;

namespace _3.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger sum = 0;

            for (int i = 0; i < n; i++)
            {
                BigInteger number = BigInteger.Parse(Console.ReadLine());

                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
