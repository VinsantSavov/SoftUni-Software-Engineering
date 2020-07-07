using INStock.Contracts;
using System;
using System.Linq;

namespace INStock.Models
{
    public class Product : IProduct
    {
        private string label;
        private decimal price;
        private int quantity;

        public Product(string label, decimal price, int quantity)
        {
            this.Label = label;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Label 
        {
            get => this.label;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }

                this.label = value;
            }
        }

        public decimal Price 
        {
            get => this.price;
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException();
                }

                this.price = value;
            }
        }

        public int Quantity 
        {
            get => this.quantity;
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException();
                }
                this.quantity = value;
            }
        }

        public int CompareTo(IProduct other)
        {
            if(other == null)
            {
                throw new ArgumentNullException();
            }
            return this.price.CompareTo(other.Price);
        }
    }
}
