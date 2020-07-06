using System;

namespace _6.TicketCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int reward = 0;
            int counter = 0;

            for (int i = 66; i <= 76; i++)
            {
                if (i % 2 == 0)
                {
                    for (int k = 102; k >= 97; k--)
                    {
                            for (int j = 65; j <= 67; j++)
                            {
                                for (int l = 1; l <= 10; l++)
                                {
                                    for (int m = 10; m >= 1; m--)
                                    {
                                        counter++;
                                        if (counter == n)
                                        {
                                            Console.WriteLine($"Ticket combination: {(char)i}{(char)k}{(char)j}{l}{m}");
                                            reward = i + k + j + l + m;
                                            Console.WriteLine("Prize: {0} lv.", reward);
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
