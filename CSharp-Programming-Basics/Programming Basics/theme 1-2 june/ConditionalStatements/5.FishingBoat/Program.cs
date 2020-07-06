using System;

namespace _5.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            double cost = 0;
            double discount = 0;

            if(season == "Spring")
            {
                if(number <= 6)
                {
                    discount = 3000 * 0.1;
                    cost = 3000 - discount;

                    if (number % 2 == 0)
                    {
                        cost = cost - cost * 0.05;
                    }
                }
                else if(number >=7 && number <= 11)
                {
                    discount = 3000 * 0.15;
                    cost = 3000 - discount;

                    if (number % 2 == 0)
                    {
                        cost = cost - cost * 0.05;
                    }
                }
                else if(number >= 12)
                {
                    discount = 3000 * 0.25;
                    cost = 3000 - discount;

                    if (number % 2 == 0)
                    {
                        cost = cost - cost * 0.05;
                    }
                }
            }
            else if (season == "Summer")
            {
                if (number <= 6)
                {
                    discount = 4200 * 0.1;
                    cost = 4200 - discount;

                    if (number % 2 == 0)
                    {
                        cost = cost - cost * 0.05;
                    }
                }
                else if (number >= 7 && number <= 11)
                {
                    discount = 4200 * 0.15;
                    cost = 4200 - discount;

                    if (number % 2 == 0)
                    {
                        cost = cost - cost * 0.05;
                    }
                }
                else if (number >= 12)
                {
                    discount = 4200 * 0.25;
                    cost = 4200 - discount;

                    if (number % 2 == 0)
                    {
                        cost = cost - cost * 0.05;
                    }
                }
            }
            else if (season == "Autumn")
            {
                if (number <= 6)
                {
                    discount = 4200 * 0.1;
                    cost = 4200 - discount;
                }
                else if (number >= 7 && number <= 11)
                {
                    discount = 4200 * 0.15;
                    cost = 4200 - discount;
                }
                else if (number >= 12)
                {
                    discount = 4200 * 0.25;
                    cost = 4200 - discount;
                }
            }
            else if (season == "Winter")
            {
                if (number <= 6)
                {
                    discount = 2600 * 0.1;
                    cost = 2600 - discount;

                    if (number % 2 == 0)
                    {
                        cost = cost - cost * 0.05;
                    }
                }
                else if (number >= 7 && number <= 11)
                {
                    discount = 2600 * 0.15;
                    cost = 2600 - discount;

                    if (number % 2 == 0)
                    {
                        cost = cost - cost * 0.05;
                    }
                }
                else if (number >= 12)
                {
                    discount = 2600 * 0.25;
                    cost = 2600 - discount;

                    if (number % 2 == 0)
                    {
                        cost = cost - cost * 0.05;
                    }
                }
            }

            if (budget > cost)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", budget - cost);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", cost - budget);
            }
        }
    }
}
