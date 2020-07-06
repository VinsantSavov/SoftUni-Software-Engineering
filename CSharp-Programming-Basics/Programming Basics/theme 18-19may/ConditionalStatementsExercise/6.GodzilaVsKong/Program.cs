using System;

namespace _6.GodzilaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double dressPrice = double.Parse(Console.ReadLine());
            double money;
            double decor = budget * 0.1;
            dressPrice = statists * dressPrice;

            if (statists > 150)
            {
                double disc = dressPrice * 0.1;
                dressPrice = dressPrice - disc;
            }
           
            money = decor + dressPrice;
            if(money <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:F2} leva left.", budget - money);
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:F2} leva more.", money - budget);
            }

        }
    }
}
