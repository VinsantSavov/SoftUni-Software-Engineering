using System;

namespace _6.Joutney
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double cost = 0;

            if(budget <= 100)
            {
                if(season == "summer")
                {
                    cost = budget * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:F2}", cost);
                }
                else
                {
                    cost = budget * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:F2}", cost);
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    cost = budget * 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:F2}", cost);
                }
                else
                {
                    cost = budget * 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:F2}", cost);
                }
            }
            else if (budget > 1000)
            {
                if (season == "summer")
                {
                    cost = budget * 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:F2}", cost);
                }
                else
                {
                    cost = budget * 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:F2}", cost);
                }
            }
        }
    }
}
