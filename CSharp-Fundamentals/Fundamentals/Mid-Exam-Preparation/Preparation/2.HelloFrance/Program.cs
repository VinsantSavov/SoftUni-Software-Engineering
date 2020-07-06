using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.HelloFrance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split("|").ToArray();
            double budget = double.Parse(Console.ReadLine());
            double allMoney = 0;
            double profit = 0;
            List<double> boughtItems = new List<double>();

            for (int i = 0; i < items.Length; i++)
            {
                string[] tokens = items[i].Split("->").ToArray();
                
                string type = tokens[0];
                double price = double.Parse(tokens[1]);

                if(type == "Clothes")
                {
                    if(price <= 50)
                    {
                        if(budget >= price)
                        {
                            budget -= price;
                            double newPrice = price + price*0.4;
                            boughtItems.Add(newPrice);
                            profit += newPrice - price;
                            allMoney += newPrice;
                        }
                    }
                }
                else if (type == "Shoes")
                {
                    if (price <= 35)
                    {
                        if (budget >= price)
                        {
                            budget -= price;
                            double newPrice = price + price * 0.4;
                            boughtItems.Add(newPrice);
                            profit += newPrice - price;
                            allMoney += newPrice;
                        }
                    }
                }
                else if (type == "Accessories")
                {
                    if (price <= 20.50)
                    {
                        if (budget >= price)
                        {
                            budget -= price;
                            double newPrice = price + price * 0.4;
                            boughtItems.Add(newPrice);
                            profit += newPrice - price;
                            allMoney += newPrice;
                        }
                    }
                }
            }
            foreach (var item in boughtItems)
            {
                Console.Write($"{item:F2} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:F2}");

            if(allMoney + budget >= 150)
            {
                Console.WriteLine("Hello, France!" );
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
