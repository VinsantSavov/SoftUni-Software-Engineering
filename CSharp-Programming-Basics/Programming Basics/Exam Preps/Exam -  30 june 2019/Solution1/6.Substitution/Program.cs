using System;

namespace _6.Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumFirstNumber = int.Parse(Console.ReadLine());
            int secondNumFirstNumber = int.Parse(Console.ReadLine());
            int firstNumSecondNumber = int.Parse(Console.ReadLine());
            int secondNumSecondNumber = int.Parse(Console.ReadLine());
            int smqna = 0;

            for(int i = firstNumFirstNumber; i <= 8; i++)
            {
                for(int k= 9;k>= secondNumFirstNumber; k--)
                {
                    for(int n= firstNumSecondNumber; n <= 8; n++)
                    {
                        for(int l=9;l>= secondNumSecondNumber; l--)
                        {
                            if (i % 2 == 0)
                            {
                                if (k % 2 != 0)
                                {
                                    if (n % 2 == 0)
                                    {
                                        if (l % 2 != 0)
                                        {
                                            if (i == n && k == l)
                                            {
                                                Console.WriteLine("Cannot change the same player.");
                                            }
                                            else
                                            {
                                                if (smqna >= 6)
                                                {
                                                    return;
                                                }
                                                smqna++;
                                                Console.WriteLine($"{i}{k} - {n}{l}");
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
    }
}
