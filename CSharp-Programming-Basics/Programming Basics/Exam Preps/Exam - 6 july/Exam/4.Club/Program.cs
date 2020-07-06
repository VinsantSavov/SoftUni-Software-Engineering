using System;

namespace _4.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double goal = double.Parse(Console.ReadLine());
            string coctail = Console.ReadLine();
            double money = 0;
            double allMoney = 0;

            while (coctail != "Party!")
            {
                int numCoctails = int.Parse(Console.ReadLine());
                int coctailCost = coctail.Length;
                money = coctailCost * numCoctails;

                if (money % 2 != 0)
                {
                    money = money * 0.75;
                }
                allMoney += money;
                if (allMoney >= goal)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }
                coctail = Console.ReadLine();
            }
            if(coctail == "Party!")
            {
                Console.WriteLine("We need {0:F2} leva more.",goal-allMoney);
            }
            Console.WriteLine("Club income - {0:F2} leva.",allMoney);
        }
    }
}
