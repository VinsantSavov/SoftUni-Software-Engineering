using System;

namespace _3.EvenPowers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;


            for (int i = 0; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(sum);
                }
                sum *= 2;
            }
        }
    }
}
