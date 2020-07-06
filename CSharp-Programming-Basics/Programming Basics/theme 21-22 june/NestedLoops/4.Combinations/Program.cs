using System;

namespace _4.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for(int i = 0; i <= 25; i++)
            {
                for(int k = 0; k <= 25; k++)
                {
                    for (int l = 0; l <= 25; l++)
                    {
                        for (int m = 0; m <= 25; m++)
                        {
                            for (int g = 0; g <= 25; g++)
                            {
                                if (i + k + l + m + g == n)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}
