using System;

namespace _2.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            double nightCost = double.Parse(Console.ReadLine());
            int moreCosts = int.Parse(Console.ReadLine());

            if(nightsCount > 7)
            {
                nightCost = nightCost * 0.95;
            }
            double moneyForSleep = nightsCount * nightCost;
            double costs = budget * moreCosts / 100;
            double allMoney = moneyForSleep + costs;

            if (budget >= allMoney)
            {
                Console.WriteLine("Ivanovi will be left with {0:F2} leva after vacation.",budget-allMoney);
            }
            else
            {
                Console.WriteLine("{0:F2} leva needed.",allMoney-budget);
            }
        }
    }
}
