using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> customers = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInput = Console.ReadLine()
                .Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] productsInput = Console.ReadLine()
                .Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < peopleInput.Length -1; i+=2)
            {
                string name = peopleInput[i];
                decimal money = decimal.Parse(peopleInput[i + 1]);

                try
                {
                    Person person = new Person(name, money);
                    customers.Add(person);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            for (int i = 0; i < productsInput.Length-1; i+=2)
            {
                string name = productsInput[i];
                decimal cost = decimal.Parse(productsInput[i + 1]);

                try
                {
                    Product product = new Product(name, cost);
                    products.Add(product);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string customerName = info[0];
                string product = info[1];

                Product productToBuy = products.FirstOrDefault(n => n.Name == product);
                Person customer = customers.FirstOrDefault(n => n.Name == customerName);

                if(productToBuy != null && customer != null)
                {
                    string output = customer.BuyProduct(productToBuy);

                    Console.WriteLine(output);
                }
            }

            foreach (var customer in customers)
            {
                if(customer.Bag.Count > 0)
                {
                    Console.WriteLine($"{customer.Name} - {string.Join(", ", customer.Bag)}");
                }
                else
                {
                    Console.WriteLine($"{customer.Name} - Nothing bought");
                }
            }
        }
    }
}
