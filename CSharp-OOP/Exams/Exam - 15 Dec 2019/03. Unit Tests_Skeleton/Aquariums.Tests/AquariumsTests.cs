namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AquariumsTests
    {
        private Fish fish;
        private Aquarium aquarium;

        [SetUp]
        public void SetUp()
        {
            this.fish = new Fish("Test");
            this.aquarium = new Aquarium("Test", 2);
        }

        [Test]
        public void FishConstructorShouldWorkProperly()
        {
            Assert.That(fish.Name, Is.EqualTo("Test"));
            Assert.That(fish.Available, Is.True);
        }

        [Test]
        public void AquariumConstructorShouldWorkProperly()
        {
            this.aquarium.Add(this.fish);

            Assert.That(this.aquarium.Name, Is.EqualTo("Test"));
            Assert.That(this.aquarium.Capacity, Is.EqualTo(2));
            Assert.That(this.aquarium.Count, Is.EqualTo(1));
        }

        [Test]
        public void AquariumNameCannotBeNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var aquarium = new Aquarium(null, 5);
            }, "Invalid aquarium name!");

            Assert.Throws<ArgumentNullException>(() =>
            {
                var aquarium = new Aquarium("", 5);
            }, "Invalid aquarium name!");
        }

        [Test]
        public void AquariumCapacityCannotBeNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var aquarium = new Aquarium("Test", -3);
            }, "Invalid aquarium capacity!");
        }

        [Test]
        public void AddMethodShouldWorkProperly()
        {
            var testFish = new Fish("Don");
            this.aquarium.Add(this.fish);
            this.aquarium.Add(testFish);

            Assert.That(this.aquarium.Count, Is.EqualTo(2));
        }

        [Test]
        public void AddMethodShouldThrowException()
        {
            var testFish = new Fish("Don");
            var excpFish = new Fish("Exception");
            this.aquarium.Add(this.fish);
            this.aquarium.Add(testFish);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.aquarium.Add(excpFish);
            }, "Aquarium is full!");
        }

        [Test]
        public void RemoveMethodShouldWorkProperly()
        {
            var testFish = new Fish("Don");
            this.aquarium.Add(this.fish);
            this.aquarium.Add(testFish);

            this.aquarium.RemoveFish("Test");

            Assert.That(this.aquarium.Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveMethodShouldThrowException()
        {
            var testFish = new Fish("Don");
            this.aquarium.Add(this.fish);
            this.aquarium.Add(testFish);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.aquarium.RemoveFish("Exception");
            }, "Fish with the name Exception doesn't exist!");
        }

        [Test]
        public void SellFishMethodShouldWorkProperly()
        {
            var testFish = new Fish("Don");
            this.aquarium.Add(this.fish);
            this.aquarium.Add(testFish);

            var fish = this.aquarium.SellFish("Test");

            Assert.That(fish.Available, Is.False);
            Assert.That(this.fish.Available, Is.False);
        }

        [Test]
        public void SellFishMethodShouldThrowException()
        {
            var testFish = new Fish("Don");
            this.aquarium.Add(this.fish);
            this.aquarium.Add(testFish);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.aquarium.RemoveFish("Exception");
            }, "Fish with the name Exception doesn't exist!");
        }

        [Test]
        public void ReportMethodShouldWorkProperly()
        {
            this.aquarium.Add(this.fish);
            var result = this.aquarium.Report();

            Assert.That(result, Is.EqualTo($"Fish available at {this.aquarium.Name}: {this.fish.Name}"));
        }
    }
}
