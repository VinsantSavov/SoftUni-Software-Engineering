using System;

namespace _1.PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            double entryTax = double.Parse(Console.ReadLine());
            double chairTax = double.Parse(Console.ReadLine());
            double umbrellaTax = double.Parse(Console.ReadLine());

            double allPeopleTax = peopleCount * entryTax;


            double peopleChair = Math.Ceiling(peopleCount * 0.75);
            double peopleUmbrella = Math.Ceiling(peopleCount * 0.5);

            double moneyForChair = peopleChair * chairTax;
            double moneyForUmbrella = peopleUmbrella * umbrellaTax;

            double allMoney = allPeopleTax + moneyForChair + moneyForUmbrella;
            Console.WriteLine($"{allMoney:F2} lv.");

        }
    }
}
