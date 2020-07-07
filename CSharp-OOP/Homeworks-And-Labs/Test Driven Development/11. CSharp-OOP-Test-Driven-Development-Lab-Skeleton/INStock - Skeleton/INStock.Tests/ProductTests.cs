namespace INStock.Tests
{
    using INStock.Models;
    using NUnit.Framework;

    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void LabelShouldThrowExceptionIfNull()
        {
            Assert.That(() =>
            {
                var product = new Product(null, 10, 5);
            }, Throws.ArgumentNullException);
        }

        [Test]
        public void LabelShouldThrowExceptionIfEmpty()
        {
            Assert.That(() =>
            {
                var product = new Product("", 10, 5);
            }, Throws.ArgumentNullException);
        }

        [Test]
        public void LabelShouldThrowExceptionIfWhitespaces()
        {
            Assert.That(() =>
            {
                var product = new Product("    ", 10, 5);
            }, Throws.ArgumentNullException);
        }

        [Test]
        public void LabelShouldWorkCorrectly()
        {
            var label = "Test";
            var product = new Product(label, 10, 5);

            Assert.That(product.Label, Is.EqualTo(label));
        }

        [Test]
        public void PriceCantBeNegative()
        {
            Assert.That(() =>
            {
                var product = new Product("Test", -3, 5);
            }, Throws.ArgumentException);
        }

        [Test]
        public void PriceCantBeZero()
        {
            Assert.That(() =>
            {
                var product = new Product("Test", 0, 5);
            }, Throws.ArgumentException);
        }

        [Test]
        public void PriceShouldWorkCorrectly()
        {
            decimal price = 10;
            var product = new Product("Test", price, 5);

            Assert.That(product.Price, Is.EqualTo(price));
        }

        [Test]
        public void QuantityCantBeNegative()
        {
            Assert.That(() =>
            {
                var product = new Product("Test", 10, -5);
            }, Throws.ArgumentException);
        }

        [Test]
        public void QuantityShouldWorkCorrectly()
        {
            int quantity = 10;
            var product = new Product("Test", 8, quantity);

            Assert.That(product.Quantity, Is.EqualTo(quantity));
        }

        [Test]
        public void CompareToShouldThrowException()
        {
            var firstProduct = new Product("first test", 8, 15);
            var secondProduct = new Product("second test", 8, 16);

            Assert.That(() =>
            {
                firstProduct.CompareTo(null);
            }, Throws.ArgumentNullException);
        }

        [Test]
        public void CompareToPriceShouldWorkCorrectly()
        {
            var firstProduct = new Product("first test", 8, 15);
            var secondProduct = new Product("second test", 11, 16);
            var thirdProduct = new Product("third test", 11, 2);

            int resultOne = firstProduct.CompareTo(secondProduct);
            int resultTwo = secondProduct.CompareTo(firstProduct);
            int resultThree = secondProduct.CompareTo(thirdProduct);

            Assert.That(resultOne, Is.Negative);
            Assert.That(resultTwo, Is.Positive);
            Assert.That(resultThree, Is.Zero);
        }
    }
}