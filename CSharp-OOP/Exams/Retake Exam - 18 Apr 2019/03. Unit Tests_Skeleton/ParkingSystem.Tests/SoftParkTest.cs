namespace ParkingSystem.Tests
{
    using NUnit.Framework;
    using System;

    public class SoftParkTest
    {
        private SoftPark park;
        private Car car;

        [SetUp]
        public void Setup()
        {
            this.park = new SoftPark();
            this.car = new Car("BMW", "CA5");
        }

        [Test]
        public void ConstructorShouldWorkProperly()
        {
            Assert.That(this.park.Parking.Count, Is.EqualTo(12));
        }

        [Test]
        public void ParkCarShouldThrowExceptionWhenSpotIsInvalid()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                this.park.ParkCar("Gd", this.car);
            }, "Parking spot doesn't exists!");
        }

        [Test]
        public void ParkCarShouldThrowExceptionWhenSpotIsNotFree()
        {
            Car anotherCar = new Car("Test", "123");

            this.park.ParkCar("A1", this.car);

            Assert.Throws<ArgumentException>(() =>
            {
                this.park.ParkCar("A1", anotherCar);
            }, "Parking spot is already taken!");
        }

        [Test]
        public void ParkCarShouldWorkProperly()
        {
            string result = this.park.ParkCar("A1", this.car);

            Assert.That(result, Is.EqualTo($"Car:{car.RegistrationNumber} parked successfully!"));
            Assert.That(this.park.Parking["A1"], Is.EqualTo(this.car));
        }

        [Test]
        public void ParkCarShouldThrowExceptionWhenCarAlreadyExists()
        {
            Car anotherCar = new Car("Test", "CA5");

            this.park.ParkCar("A1", this.car);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.park.ParkCar("B2", anotherCar);
            }, "Car is already parked!");
        }

        [Test]
        public void RemoveShouldThrowExceptionWhenSpotIsNotValid()
        {
            this.park.ParkCar("A1", this.car);

            Assert.Throws<ArgumentException>(() =>
            {
                this.park.RemoveCar("G3", this.car);
            }, "Parking spot doesn't exists!");
        }

        [Test]
        public void RemoveShouldThrowExceptionWhenCarIsNotOnTheSpot()
        {
            Car anotherCar = new Car("Test", "KN");
            this.park.ParkCar("A1", this.car);
            this.park.ParkCar("A2", anotherCar);

            Assert.Throws<ArgumentException>(() =>
            {
                this.park.RemoveCar("A2", this.car);
            }, "Car for that spot doesn't exists!");
        }

        [Test]
        public void RemoveShouldWorkProperly()
        {
            this.park.ParkCar("A1", this.car);

            string result = this.park.RemoveCar("A1", this.car);

            Assert.That(result, Is.EqualTo($"Remove car:{this.car.RegistrationNumber} successfully!"));
            Assert.That(this.park.Parking["A1"], Is.Null);
        }
    }
}