using System;

namespace _3.CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numDrinks = int.Parse(Console.ReadLine());

            double money = 0;

            if(sugar == "Without")
            {

                if (drink == "Espresso")
                {
                    double discount = 0.90 * 0.65;
                    if (numDrinks >= 5)
                    {
                        double espressoDisc = discount * 0.75;
                        money = espressoDisc * numDrinks;
                    }
                    else
                    {
                        money = discount * numDrinks;
                    }
                }
                else if (drink == "Cappuccino")
                {
                    double discount = 1 * 0.65;
                    money = numDrinks * discount;
                }
                else if(drink == "Tea")
                {
                    double discount = 0.50 * 0.65;
                    money = numDrinks * discount;
                }

            }
            else if (sugar == "Normal")
            {
                if (drink == "Espresso")
                {
                 
                    if (numDrinks >= 5)
                    {
                        double espressoDisc = 1 * 0.75;
                        money = espressoDisc * numDrinks;
                    }
                    else
                    {
                        money = 1 * numDrinks;
                    }
                }
                else if (drink == "Cappuccino")
                {
               
                    money = numDrinks * 1.2;
                }
                else if (drink == "Tea")
                {
                
                    money = numDrinks * 0.6;
                }
            }
            else if (sugar == "Extra")
            {
                if (drink == "Espresso")
                {

                    if (numDrinks >= 5)
                    {
                        double espressoDisc = 1.2 * 0.75;
                        money = espressoDisc * numDrinks;
                    }
                    else
                    {
                        money = 1.2 * numDrinks;
                    }
                }
                else if (drink == "Cappuccino")
                {

                    money = numDrinks * 1.60;
                }
                else if (drink == "Tea")
                {

                    money = numDrinks * 0.7;
                }
            }

            if(money > 15)
            {
                money = money * 0.8;
            }

            Console.WriteLine($"You bought {numDrinks} cups of {drink} for {money:F2} lv.");
        }
    }
}
