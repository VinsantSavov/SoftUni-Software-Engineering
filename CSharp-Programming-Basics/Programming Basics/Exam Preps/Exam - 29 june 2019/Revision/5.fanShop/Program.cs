using System;

namespace _5.fanShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int money = 0;

            for(int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();

                if (item == "hoodie")
                {
                    money += 30;
                }
                else if (item == "keychain")
                {
                    money += 4;
                }
                else if (item == "T-shirt")
                {
                    money += 20;
                }
                else if (item == "flag")
                {
                    money += 15;
                }
                else if (item == "sticker")
                {
                    money += 1;
                }
            }
            if(budget >= money)
            {
                Console.WriteLine($"You bought {n} items and left with {budget-money} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {money-budget} more lv.");
            }
        }
    }
}
