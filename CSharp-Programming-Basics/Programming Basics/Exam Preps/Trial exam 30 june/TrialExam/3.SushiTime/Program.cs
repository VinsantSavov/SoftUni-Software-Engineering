using System;

namespace _3.SushiTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushi = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double delivery = 0;
            double money = 0;

            if(restaurant == "Sushi Zone")
            {
                if (sushi == "sashimi")
                {
                    if (symbol == 'Y')
                    {
                        money = 4.99 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 4.99 * portions;
                    }
                }
                else if(sushi == "maki")
                {
                    if (symbol == 'Y')
                    {
                        money = 5.29 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 5.29 * portions;
                    }
                }
                else if (sushi == "uramaki")
                {
                    if (symbol == 'Y')
                    {
                        money = 5.99 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 5.99 * portions;
                    }
                }
                else if (sushi == "temaki")
                {
                    if (symbol == 'Y')
                    {
                        money = 4.29 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 4.29 * portions;
                    }
                }
            }
            else if(restaurant=="Sushi Time")
            {
                if (sushi == "sashimi")
                {
                    if (symbol == 'Y')
                    {
                        money = 5.49 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 5.49 * portions;
                    }
                }
                else if (sushi == "maki")
                {
                    if (symbol == 'Y')
                    {
                        money = 4.69 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 4.69 * portions;
                    }
                }
                else if (sushi == "uramaki")
                {
                    if (symbol == 'Y')
                    {
                        money = 4.49 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 4.49 * portions;
                    }
                }
                else if (sushi == "temaki")
                {
                    if (symbol == 'Y')
                    {
                        money = 5.19 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 5.19 * portions;
                    }
                }
                Console.WriteLine("Total price: {0} lv.", Math.Ceiling(money));
            }
            else if (restaurant == "Sushi Bar")
            {
                if (sushi == "sashimi")
                {
                    if (symbol == 'Y')
                    {
                        money = 5.25 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 5.25 * portions;
                    }
                }
                else if (sushi == "maki")
                {
                    if (symbol == 'Y')
                    {
                        money = 5.55 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 5.55 * portions;
                    }
                }
                else if (sushi == "uramaki")
                {
                    if (symbol == 'Y')
                    {
                        money = 6.25 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 6.25 * portions;
                    }
                }
                else if (sushi == "temaki")
                {
                    if (symbol == 'Y')
                    {
                        money = 4.75 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 4.75 * portions;
                    }
                }
                Console.WriteLine("Total price: {0} lv.", Math.Ceiling(money));
            }
            else if (restaurant == "Asian Pub")
            {
                if (sushi == "sashimi")
                {
                    if (symbol == 'Y')
                    {
                        money = 4.50 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 4.50 * portions;
                    }
                }
                else if (sushi == "maki")
                {
                    if (symbol == 'Y')
                    {
                        money = 4.80 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 4.80 * portions;
                    }
                }
                else if (sushi == "uramaki")
                {
                    if (symbol == 'Y')
                    {
                        money = 5.50 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 5.50 * portions;
                    }
                }
                else if (sushi == "temaki")
                {
                    if (symbol == 'Y')
                    {
                        money = 5.50 * portions;
                        delivery = money * 0.2;
                        money = money + delivery;
                    }
                    else
                    {
                        money = 5.50 * portions;
                    }
                }
                Console.WriteLine("Total price: {0} lv.", Math.Ceiling(money));
            }
            else
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!");
            }
           
        }
    }
}
