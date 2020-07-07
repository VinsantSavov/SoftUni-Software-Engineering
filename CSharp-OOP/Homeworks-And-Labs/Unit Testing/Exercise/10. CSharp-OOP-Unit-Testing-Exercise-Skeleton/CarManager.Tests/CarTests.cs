
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class CarTests
    {
        private Car workingCar;

        [SetUp]
        public void Setup()
        {
            this.workingCar = new Car("BMW", "E46", 8.8, 100);
        }

        [Test]
        public void PropertyMake()
        {
            Assert.That(this.workingCar.Make, Is.EqualTo("BMW"));

            Assert.That(() =>
            {
                Car carWithNoModel = new Car(null, "E46", 8, 100);
            }, Throws.ArgumentException.With.Message.EqualTo("Make cannot be null or empty!"));
        }

        [Test]
        public void PropertyModel()
        {
            Assert.That(this.workingCar.Model, Is.EqualTo("E46"));

            Assert.That(() =>
            {
                Car carWithNoModel = new Car("BMW", null, 10, 100);
            }, Throws.ArgumentException.With.Message.EqualTo("Model cannot be null or empty!"));
        }

        [Test]
        public void PropertyFuelConsumption()
        {
            Assert.That(this.workingCar.FuelConsumption, Is.EqualTo(8.8));

            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("BMW", "E46", 0, 100);
            }, "Fuel consumption cannot be zero or negative!");
        }

        [Test]
        public void PropertyFuelAmount()
        {
            Assert.That(this.workingCar.FuelAmount, Is.EqualTo(0));
        }

        [Test]
        public void PropertyFuelCapacity()
        {
            Assert.That(this.workingCar.FuelCapacity, Is.EqualTo(100));

            Assert.That(() =>
            {
                Car car = new Car("BMW", "E46", 8.8, 0);
            }, Throws.ArgumentException.With.Message.EqualTo("Fuel capacity cannot be zero or negative!"));
        }

        [Test]
        public void RefuelMethodShouldWork()
        {
            //Act
            this.workingCar.Refuel(50);

            Assert.That(this.workingCar.FuelAmount, Is.EqualTo(50));

            Assert.That(() =>
            {
                this.workingCar.Refuel(0);
            }, Throws.ArgumentException.With.Message.EqualTo("Fuel amount cannot be zero or negative!"));

            this.workingCar.Refuel(100);

            Assert.That(this.workingCar.FuelAmount, Is.EqualTo(100));
        }

        [Test]
        public void DriveMethodShoutlWork()
        {
            this.workingCar.Refuel(50);
            this.workingCar.Drive(100);

            Assert.That(this.workingCar.FuelAmount, Is.EqualTo(41.2));

            Assert.That(() =>
            {
                this.workingCar.Drive(3000);
            }, Throws.InvalidOperationException.With.Message.EqualTo("You don't have enough fuel to drive!"));
        }
    }
}