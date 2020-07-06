using System;

namespace _5.PcGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countH = 0;
            int countF = 0;
            int countO = 0;
            int countOther = 0;

            for(int i = 0; i < n; i++)
            {
                string game = Console.ReadLine();

                if(game == "Hearthstone")
                {
                    countH++;
                }
                else if(game == "Fornite")
                {
                    countF++;
                }
                else if (game == "Overwatch")
                {
                    countO++;
                }
                else
                {
                    countOther++;
                }
            }
            int allCount = countH + countF + countO + countOther;
            double perCent = 100.00 / allCount;

            Console.WriteLine("Hearthstone - {0:F2}%",perCent*countH);
            Console.WriteLine("Fornite - {0:F2}%",perCent*countF);
            Console.WriteLine("Overwatch - {0:F2}%", perCent * countO);
            Console.WriteLine("Others - {0:F2}%", perCent * countOther);
        }
    }
}
