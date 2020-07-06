using System;

namespace ChristmasGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            for(int i = M; i >= N; i--)
            {
                if (i % 2 == 0)
                {
                    if (i % 3 == 0)
                    {
                        if (i != S)
                        {
                            Console.Write("{0} ",i);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

        }
    }
}
