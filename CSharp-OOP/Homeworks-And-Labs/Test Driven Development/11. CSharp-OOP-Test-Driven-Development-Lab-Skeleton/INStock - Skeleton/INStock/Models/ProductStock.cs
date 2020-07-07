using INStock.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace INStock.Models
{
    public class ProductStock : IProductStock
    {
        private List<IProduct> productStock;

        public ProductStock()
        {
            this.productStock = new List<IProduct>();
        }

        public int Count => this.productStock.Count;

        public void Add(IProduct product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }

            if(this.productStock.Any(p => p.Label == product.Label))
            {
                throw new ArgumentException();
            }

            this.productStock.Add(product);
        }

        public bool Contains(IProduct product)
        {
            if(product == null)
            {
                throw new ArgumentNullException();
            }

            return this.productStock.Contains(product);
        }

        public IProduct Find(int index)
        {
            if(index < 0 || index > this.productStock.Count)
            {
                throw new IndexOutOfRangeException();
            }

            return this.productStock[index];
        }

        public IEnumerable<IProduct> FindAllByPrice(decimal price)
        {
            List<IProduct> samePrice = new List<IProduct>();

            foreach (var product in this.productStock)
            {
                if(product.Price == price)
                {
                    samePrice.Add(product);
                }
            }

            return samePrice;
        }

        public IEnumerable<IProduct> FindAllByQuantity(int quantity)
        {
            List<IProduct> sameQuantity = new List<IProduct>();

            foreach (var product in this.productStock)
            {
                if (product.Quantity == quantity)
                {
                    sameQuantity.Add(product);
                }
            }

            return sameQuantity;
        }

        public IEnumerable<IProduct> FindAllInRange(decimal lo, decimal hi)
        {
            List<IProduct> inRange = new List<IProduct>();

            foreach (var product in this.productStock)
            {
                if (product.Price >= lo && product.Price <= hi)
                {
                    inRange.Add(product);
                }
            }

            inRange = inRange.OrderByDescending(n => n.Price).ToList();

            return inRange;
        }

        public IProduct FindByLabel(string label)
        {
            var product = this.productStock.FirstOrDefault(p => p.Label == label);
            
            if(product == null)
            {
                throw new ArgumentException();
            }

            return product;
        }

        public IProduct FindMostExpensiveProduct()
        {
            var items = new List<IProduct>();
            items = this.productStock;
            items = items.OrderByDescending(n => n.Price).ToList();

            return items.First();
        }

        public IEnumerator<IProduct> GetEnumerator()
        {
            return this.productStock.GetEnumerator();
        }

        public bool Remove(IProduct product)
        {
            return this.productStock.Remove(product);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IProduct this[int index] 
        {
            get => this.Find(index);
        }
    }
}
