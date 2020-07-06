using System;

namespace _9.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int u = 2;
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    for (int j = 97; j <= 96 + L; j++)
                    {
                        for (int g = 97; g <= 96 + L; g++)
                        {
                            for (u = 2; u <= n; u++)
                            {
                                if (k < u && i < u)
                                {
                                    Console.Write($"{i}{k}{(char)j}{(char)g}{u} ");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}