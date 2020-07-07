namespace BlueOrigin.Tests
{
    using System;
    using NUnit.Framework;

    public class SpaceshipTests
    {
        private Astronaut firstAstronaut;
        private Astronaut secondAstronaut;
        private Spaceship spaceship;

        [SetUp]
        public void SetUp()
        {
            this.firstAstronaut = new Astronaut("Test one", 10);
            this.secondAstronaut = new Astronaut("Test two", 20);
            this.spaceship = new Spaceship("Test", 3);
        }

        [Test]
        public void ConstructorShouldWorkProperly()
        {
            Assert.That(this.spaceship.Name, Is.EqualTo("Test"));
            Assert.That(this.spaceship.Capacity, Is.EqualTo(3));
        }

        [Test]
        public void SpaceshipNameCannotBeNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Spaceship ship = new Spaceship(null, 2);
            }, "Invalid spaceship name!");  
        }

        [Test]
        public void SpaceshipCapacityCannotBeNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Spaceship ship = new Spaceship("Test", -2);
            }, "Invalid capacity!");
        }

        [Test]
        public void AddShouldWorkProperly()
        {
            this.spaceship.Add(this.firstAstronaut);
            this.spaceship.Add(this.secondAstronaut);

            Assert.That(this.spaceship.Count, Is.EqualTo(2));
        }

        [Test]
        public void AddCannotAddAstronaoutWithTheSameName()
        {
            this.spaceship.Add(this.firstAstronaut);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.spaceship.Add(this.firstAstronaut);
            }, "Astronaut Test one is already in!");
        }

        [Test]
        public void AddCannotAddMoreThanTheCapacity()
        {
            Astronaut astronaut3 = new Astronaut("Test 3", 5);
            Astronaut astronaut4 = new Astronaut("Test 4", 23);
            this.spaceship.Add(this.firstAstronaut);
            this.spaceship.Add(this.secondAstronaut);
            this.spaceship.Add(astronaut3);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.spaceship.Add(astronaut4);
            }, "Spaceship is full!");
        }

        [Test]
        public void RemoveShouldReturnTrue()
        {
            this.spaceship.Add(this.firstAstronaut);
            this.spaceship.Add(this.secondAstronaut);

            bool isRemoved = this.spaceship.Remove("Test one");

            Assert.That(isRemoved, Is.True);
            Assert.That(this.spaceship.Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveShouldReturnFalse()
        {
            this.spaceship.Add(this.firstAstronaut);
            this.spaceship.Add(this.secondAstronaut);

            bool isRemoved = this.spaceship.Remove("Test");

            Assert.That(isRemoved, Is.False);
            Assert.That(this.spaceship.Count, Is.EqualTo(2));
        }
    }
}