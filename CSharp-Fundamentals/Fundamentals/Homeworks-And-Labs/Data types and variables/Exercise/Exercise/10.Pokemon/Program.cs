using System;

namespace _10.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            double value = n * 0.5;

            while (n>=m)
            {
                n = n - m;
                count++;

                if (y != 0)
                {
                    if (n == value)
                    {
                        n = n / y;
                    }
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
