using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> itemsPrices = new Dictionary<string, double>();
            Dictionary<string, int> itemsQuantity = new Dictionary<string, int>();
            Dictionary<string, double> products = new Dictionary<string, double>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "buy")
                {
                    break;
                }

                List<string> tokens = input.Split().ToList();
                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (!itemsPrices.ContainsKey(product))
                {
                    itemsPrices.Add(product, price);
                }
                else
                {
                    itemsPrices[product] = price;
                }
                if (!itemsQuantity.ContainsKey(product))
                {
                    itemsQuantity.Add(product, quantity);
                }
                else
                {
                    itemsQuantity[product] += quantity;
                }
            }

            foreach (var product in itemsPrices)
            {
                foreach (var item in itemsQuantity)
                {
                    if(item.Key == product.Key)
                    {
                        double result = item.Value * product.Value;
                        products.Add(item.Key, result);
                    }
                }
            }

            foreach (var kvp in products)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
    }
}
