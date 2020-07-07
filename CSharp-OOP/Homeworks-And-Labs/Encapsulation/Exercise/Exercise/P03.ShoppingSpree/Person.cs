using System;
using System.Collections.Generic;

namespace P03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public IReadOnlyList<Product> Bag 
        { 
            get
            {
                return this.bag;
            } 
        }

        public string BuyProduct(Product product)
        {
            string text = string.Empty;

            if(money >= product.Cost)
            {
                bag.Add(product);
                this.Money -= product.Cost;
                text = $"{this.Name} bought {product.Name}";
            }
            else
            {
                text = $"{this.Name} can't afford {product.Name}";
            }

            return text;
        }
    }
}
