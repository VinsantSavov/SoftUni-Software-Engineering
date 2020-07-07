namespace INStock.Tests
{
    using INStock.Contracts;
    using INStock.Models;
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class ProductStockTests
    {
        private IProductStock productStock;
        private IProduct firstProduct;
        private IProduct secondProduct;

        [SetUp]
        public void SetUp()
        {
            this.productStock = new ProductStock();
            this.firstProduct = new Product("Test one", 5, 5);
            this.secondProduct = new Product("Test two", 10, 10);
        }

        [Test]
        public void AddMethodCannotAddNull()
        {
            Assert.That(() =>
            {
                this.productStock.Add(null);
            }, Throws.ArgumentNullException);
        }

        [Test]
        public void AddMethodCannotAddProductWithSameLabel()
        {
            this.productStock.Add(firstProduct);

            Assert.That(() =>
            {
                this.productStock.Add(new Product("Test one", 13, 3));
            }, Throws.ArgumentException);
        }

        [Test]
        public void AddMethodShouldWorkProperly()
        {
            this.productStock.Add(this.firstProduct);

            Assert.That(this.productStock.Count, Is.EqualTo(1));
            Assert.That(this.productStock.Contains(this.firstProduct), Is.True);
            Assert.That(this.productStock.FindByLabel("Test one"), Is.EqualTo(this.firstProduct));
            Assert.That(this.productStock.Find(0), Is.EqualTo(this.firstProduct));
        }

        [Test]
        public void ContainsMethodShouldThrowException()
        {
            Assert.That(() =>
            {
                this.productStock.Contains(null);
            }, Throws.ArgumentNullException);
        }

        [Test]
        public void ContainsMethodShouldReturnFalse()
        {
            this.productStock.Add(firstProduct);
            var result = this.productStock.Contains(secondProduct);

            Assert.That(result, Is.False);
        }

        [Test]
        public void ContainsMethodShouldReturnTrue()
        {
            this.productStock.Add(firstProduct);
            var result = this.productStock.Contains(firstProduct);

            Assert.That(result, Is.True);
        }

        [Test]
        public void FindMethodIndexCantBeNegative()
        {
            this.productStock.Add(firstProduct);

            Assert.That(() =>
            {
                var product = this.productStock.Find(-3);
            }, Throws.InstanceOf<IndexOutOfRangeException>());
        }

        [Test]
        public void FindMethodInvalidIndex()
        {
            this.productStock.Add(firstProduct);

            Assert.That(() =>
            {
                var product = this.productStock.Find(3);
            }, Throws.InstanceOf<IndexOutOfRangeException>());
        }

        [Test]
        public void FindMethodShouldWorkProperly()
        {
            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);

            var result = this.productStock.Find(1);

            Assert.That(secondProduct.Label, Is.EqualTo(result.Label));
            Assert.That(secondProduct.Price, Is.EqualTo(result.Price));
            Assert.That(secondProduct.Quantity, Is.EqualTo(result.Quantity));
        }

        [Test]
        public void FindAllByPriceWithInvalidPrice()
        {
            int price = 21;

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);

            var collection = this.productStock.FindAllByPrice(price).ToList();

            Assert.That(collection.Count, Is.Zero);
        }

        [Test]
        public void FindAllByPriceShouldWorkProperly()
        {
            int price = 10;

            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);

            var collection = this.productStock.FindAllByPrice(price).ToList();

            Assert.That(collection.Count, Is.EqualTo(1));
        }

        [Test]
        public void FindAllByQuantityWithInvalidQuantity()
        {
            int quantity = 21;
            this.CreateMultipleProducts();

            var collection = this.productStock.FindAllByQuantity(quantity).ToList();

            Assert.That(collection.Count, Is.Zero);
        }

        [Test]
        public void FindAllByQuantityShouldWorkProperly()
        {
            int quantity = 8;

            this.CreateMultipleProducts();

            var collection = this.productStock.FindAllByQuantity(quantity).ToList();

            Assert.That(collection.Count, Is.EqualTo(2));
        }

        [Test]
        public void FindAllInRangeShouldReturnEmptyCollection()
        {
            int fp = 21;
            int sp = 39;

            this.CreateMultipleProducts();

            var collection = this.productStock.FindAllInRange(fp, sp).ToList();

            Assert.That(collection.Count, Is.Zero);
        }

        [Test]
        public void FindAllInRangeShouldWorkProperly()
        {
            int fp = 20;
            int sp = 60;

            this.CreateMultipleProducts();

            var collection = this.productStock.FindAllInRange(fp, sp).ToList();

            Assert.That(collection.Count, Is.EqualTo(3));
            Assert.That(collection[0].Label, Is.EqualTo("Vim"));
            Assert.That(collection[1].Label, Is.EqualTo("Dok"));
            Assert.That(collection[2].Label, Is.EqualTo("Gom"));
        }

        [Test]
        public void FindByLabelShouldThrowException()
        {
            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);

            Assert.That(() =>
            {
                this.productStock.FindByLabel("Exception");
            }, Throws.ArgumentException);
        }

        [Test]
        public void FindByLabelShouldWorkProperly()
        {
            this.productStock.Add(firstProduct);
            this.productStock.Add(secondProduct);

            var product = this.productStock.FindByLabel("Test one");

            Assert.That(product.Price, Is.EqualTo(this.firstProduct.Price));
            Assert.That(product.Quantity, Is.EqualTo(this.firstProduct.Quantity));
            Assert.That(product.Label, Is.EqualTo(this.firstProduct.Label));
        }

        [Test]
        public void FindMostExpensiveProductShouldWorkProperly()
        {
            this.CreateMultipleProducts();

            var product = this.productStock.FindMostExpensiveProduct();

            Assert.That(product.Label, Is.EqualTo("Vim"));
            Assert.That(product.Price, Is.EqualTo(60));
            Assert.That(product.Quantity, Is.EqualTo(16));
        }

        [Test]
        public void RemoveMethodShouldBeFalse()
        {
            this.CreateMultipleProducts();

            var reslut = this.productStock.Remove(null);

            Assert.That(reslut, Is.False);
        }

        [Test]
        public void RemoveMethodShouldBeTrue()
        {
            var productOne = new Product("Pesh", 10, 2);
            this.productStock.Add(productOne);

            var result = this.productStock.Remove(productOne);

            Assert.That(result, Is.True);
        }

        [Test]
        public void GetEnumeratorShouldWorkProperly()
        {
            this.CreateMultipleProducts();

            var result = this.productStock.ToList();

            Assert.That(result[0].Label, Is.EqualTo("Pesh"));
            Assert.That(result[3].Label, Is.EqualTo("Vim"));

        }
        private void CreateMultipleProducts()
        {
            var productOne = new Product("Pesh", 10, 2);
            var productTwo = new Product("Gom", 20, 8);
            var productThree = new Product("Dok", 40, 8);
            var productFour = new Product("Vim", 60, 16);

            this.productStock.Add(productOne);
            this.productStock.Add(productTwo);
            this.productStock.Add(productThree);
            this.productStock.Add(productFour);
        }
    }
}
