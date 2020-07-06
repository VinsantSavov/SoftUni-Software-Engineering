using System;

namespace _12.ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            int allToys = puzzles + dolls + bears + minions + trucks;

            double money = (puzzles * 2.60) + (dolls * 3) + (bears * 4.1) + (minions * 8.2) + (trucks * 2);
            double fee;

            if (allToys >= 50)
            {
                double disc_money = money * 0.25;
                disc_money = money - disc_money;
                fee = disc_money * 0.1;
                money = disc_money - fee;

                if(money>= vacationPrice)
                {
                    Console.WriteLine("Yes! {0:F2} lv left.", money - vacationPrice);
                }
                else
                {
                    Console.WriteLine("Not enough money! {0:F2} lv needed.",vacationPrice-money);
                }
            }
            else
            {
                fee = money * 0.1;
                money = money - fee;
                if (money >= vacationPrice)
                {
                    Console.WriteLine("Yes! {0:F2} lv left.", money - vacationPrice);
                }
                else
                {
                    Console.WriteLine("Not enough money! {0:F2} lv needed.", vacationPrice - money);
                }

            }
        
        }
    }
}
