using System;

namespace _4.NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if(flower == "Roses")
            {
                price = number * 5;
                if (number > 80)
                {
                    price = price - price * 0.1;
                }
            }
            if (flower == "Dahlias")
            {
                price = number * 3.80;
                if (number > 90)
                {
                    price = price - price * 0.15;
                }
            }
            if (flower == "Tulips")
            {
                price = number * 2.80;
                if (number > 80)
                {
                    price = price - price * 0.15;
                }
            }
            if (flower == "Narcissus")
            {
                if (number < 120)
                {
                    price = number * 3;
                    price = price + price * 0.15;
                }
                else
                {
                    price = number * 3;
                }
            }
            if (flower == "Gladiolus")
            {
                if (number < 80)
                {
                    price = number * 2.50;
                    price = price + price * 0.2;
                }
                else
                {
                    price = number * 2.50;
                }
            }

            if(budget >= price)
            {
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", number, flower,budget - price);
            }
            else
            {
                Console.WriteLine("Not enough money, you need {0:F2} leva more.", price - budget);
            }
        }
    }
}
