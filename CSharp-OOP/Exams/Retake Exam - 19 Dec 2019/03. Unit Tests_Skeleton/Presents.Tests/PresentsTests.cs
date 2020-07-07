namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class PresentsTests
    {
        private Present firstPresent;
        private Bag bag;

        [SetUp]
        public void SetUp()
        {
            this.bag = new Bag();
            this.firstPresent = new Present("Test", 10);
        }

        [Test]
        public void ConstructorOfPresentShouldWorkProperly()
        {
            Assert.That(this.firstPresent.Name, Is.EqualTo("Test"));
            Assert.That(this.firstPresent.Magic, Is.EqualTo(10));
        }

        [Test]
        public void CreateMethodShoulThrowNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                this.bag.Create(null);
            }, "Present is null");
        }

        [Test]
        public void CreateMethodShouldWorkProperly()
        {
            string message = this.bag.Create(this.firstPresent);

            var present = bag.GetPresent("Test");

            Assert.That(message, Is.EqualTo($"Successfully added present {this.firstPresent.Name}."));
            Assert.That(present.Name, Is.EqualTo("Test"));
            Assert.That(present.Magic, Is.EqualTo(10));
        }

        [Test]
        public void CreateMethodCannotAddExistingPresent()
        {
            this.bag.Create(this.firstPresent);

            Assert.That(() =>
            {
                this.bag.Create(this.firstPresent);
            }, Throws.InvalidOperationException.With.Message.EqualTo("This present already exists!"));
        }

        [Test]
        public void RemoveMethodShoudReturnFalse()
        {
            var present = new Present("False", 12);

            this.bag.Create(this.firstPresent);

            bool removeNull = this.bag.Remove(null);
            bool removeFake = this.bag.Remove(present);

            Assert.That(removeNull, Is.False);
            Assert.That(removeFake, Is.False);
        }

        [Test]
        public void RemoveMethodShoudReturnTrue()
        {
            this.bag.Create(this.firstPresent);

            bool isTrue = this.bag.Remove(this.firstPresent);

            Assert.That(isTrue, Is.True);
        }

        [Test]
        public void GetPresentWithLeastMagicShouldWorkProperly()
        {
            var present = new Present("False", 12);

            this.bag.Create(this.firstPresent);
            this.bag.Create(present);

            var returnedPresent = this.bag.GetPresentWithLeastMagic();

            Assert.That(returnedPresent.Name, Is.EqualTo("Test"));
            Assert.That(returnedPresent.Magic, Is.EqualTo(10));
        }

        [Test]
        public void GetPresentShouldWorkProperly()
        {
            var present = new Present("False", 12);

            this.bag.Create(this.firstPresent);
            this.bag.Create(present);

            var returnedPresent = this.bag.GetPresent("False");

            Assert.That(returnedPresent.Name, Is.EqualTo("False"));
            Assert.That(returnedPresent.Magic, Is.EqualTo(12));
        }

        [Test]
        public void GetPresentShouldReturnNull()
        {
            var present = new Present("False", 12);

            this.bag.Create(this.firstPresent);
            this.bag.Create(present);

            var returnedPresent = this.bag.GetPresent(null);

            Assert.That(returnedPresent, Is.Null);
        }

        [Test]
        public void GetPresentsShouldWorkProperly()
        {
            var present = new Present("False", 12);

            this.bag.Create(this.firstPresent);
            this.bag.Create(present);

            var collection = this.bag.GetPresents();

            Assert.That(collection is IReadOnlyCollection<Present>);
        }
    }
}
