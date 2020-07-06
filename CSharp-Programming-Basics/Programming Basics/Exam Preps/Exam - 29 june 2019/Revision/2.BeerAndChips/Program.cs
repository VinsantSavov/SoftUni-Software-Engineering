using System;

namespace _2.BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int bottles = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());

            double beerCost = bottles * 1.20;
            double chipsCost = Math.Ceiling(chips * beerCost * 0.45);
            double allMoney = beerCost + chipsCost;

            if (budget >= allMoney)
            {
                Console.WriteLine($"{name} bought a snack and has {budget-allMoney:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {allMoney-budget:F2} more leva!");
            }
        }
    }
}
