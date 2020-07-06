using System;

namespace _2.ChristmasShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            int fantasyBooks = int.Parse(Console.ReadLine());
            int horrorBooks = int.Parse(Console.ReadLine());
            int romanticBooks = int.Parse(Console.ReadLine());

            double fantasyMoney = fantasyBooks * 14.90;
            double horrorMoney = horrorBooks * 9.80;
            double romanticMoney = romanticBooks * 4.30;

            double totalMoney = fantasyMoney + horrorMoney + romanticMoney;
            totalMoney = totalMoney - (totalMoney * 20 / 100);

            if(totalMoney >= moneyNeeded)
            {
                double rest = totalMoney - moneyNeeded;
                double moneySellers = Math.Floor(rest * 0.1);
                totalMoney -= moneySellers;
                Console.WriteLine("{0:F2} leva donated.",totalMoney);
                Console.WriteLine("Sellers will receive {0} leva.",moneySellers);
            }
            else
            {
                Console.WriteLine("{0:F2} money needed.",moneyNeeded-totalMoney);
            }
        }
    }
}
