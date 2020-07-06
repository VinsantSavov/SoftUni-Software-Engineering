using System;

namespace _9.MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());

            for(int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int l = 0; l < 10; l++)
                    {
                        for (int m = 0; m < 10; m++)
                        {
                            for (int n = 0; n < 10; n++)
                            {
                                for (int s = 0; s < 10; s++)
                                {
                                    if (i * k * l * m * n * s == magicNumber)
                                    {
                                        Console.Write($"{i}{k}{l}{m}{n}{s} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
