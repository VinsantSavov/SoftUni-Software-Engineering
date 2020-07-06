using System;
using System.Linq;
using System.Collections.Generic;

namespace _4.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> itemsPrice = new Dictionary<string, decimal>();
            Dictionary<string, int> itemsQuantity = new Dictionary<string, int>();

            while (true)
            {
                List<string> products = Console.ReadLine().Split().ToList();

                if (products[0] == "buy")
                {
                    break;
                }
                string product = products[0];
                decimal price = decimal.Parse(products[1]);
                int quantity = int.Parse(products[2]);

                if (!itemsPrice.ContainsKey(product))
                {
                    itemsPrice[product] = price;
                }
                else
                {
                    itemsPrice[product] = price;
                }
                if (!itemsQuantity.ContainsKey(product))
                {
                    itemsQuantity[product] = quantity;
                }
                else
                {
                    itemsQuantity[product] += quantity;
                }
            }
            foreach (var kvp in itemsPrice)
            {
                foreach (var fg in itemsQuantity)
                {
                    if (kvp.Key == fg.Key)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value*fg.Value}");
                    }
                }
            }
        }
    }
}
