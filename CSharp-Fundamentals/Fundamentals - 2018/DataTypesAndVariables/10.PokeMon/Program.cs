using System;
using System.Numerics;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int pokeCounts = 0;
            decimal percent = N * 0.5m;

            while (N >= M)
            {
                N = N - M;
                pokeCounts++;

                if (N == percent && Y > 0)
                {
                    N = N / Y;
                }
            }
            Console.WriteLine((decimal)N);
            Console.WriteLine(pokeCounts);
        }
    }
}
