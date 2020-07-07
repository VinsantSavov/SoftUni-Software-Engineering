using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Revision")
                {
                    break;
                }

                string[] inputInfo = input.Split(", ").ToArray();
                string store = inputInfo[0];
                string product = inputInfo[1];
                double price = double.Parse(inputInfo[2]);

                if (!dictionary.ContainsKey(store))
                {
                    dictionary.Add(store, new Dictionary<string, double>());
                }
                dictionary[store].Add(product, price);
            }

            foreach (var kvp in dictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}->");

                foreach (var product in kvp.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
