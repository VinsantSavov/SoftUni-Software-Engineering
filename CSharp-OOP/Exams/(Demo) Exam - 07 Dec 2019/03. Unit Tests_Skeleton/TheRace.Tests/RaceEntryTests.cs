using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private const string RiderName = "Test rider";

        private const string MotorModel = "Test model";
        private const int Horsepower = 15;
        private const double CubicC = 20;

        private RaceEntry race;
        private UnitMotorcycle motorcycle;
        private UnitRider rider;

        [SetUp]
        public void Setup()
        {
            this.motorcycle = new UnitMotorcycle(MotorModel, Horsepower, CubicC);
            this.rider = new UnitRider(RiderName, motorcycle);
            this.race = new RaceEntry();
        }

        [Test]
        public void AddRiderMethodShouldAddCorrectly()
        {
            this.race.AddRider(this.rider);

            Assert.That(this.race.Counter, Is.EqualTo(1));
        }

        [Test]
        public void AddRiderMethodCannotAddNull()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.race.AddRider(null);
            }, "Rider cannot be null.");
        }

        [Test]
        public void AddMethodShouldThrowExceptionIfRiderIsPresented()
        {
            this.race.AddRider(this.rider);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.race.AddRider(this.rider);
            }, "Rider Test rider is already added.");
        }

        [Test]
        public void AddMethodShouldWorkProperly()
        {
            string result = this.race.AddRider(this.rider);

            Assert.That(result, Is.EqualTo("Rider Test rider added in race."));
        }

        [Test]
        public void CalculateAverageHorsePowerShouldworkProperly()
        {
            UnitMotorcycle motorTest = new UnitMotorcycle("Asd", 15, 40);
            UnitRider riderTest = new UnitRider("Test", motorTest);

            this.race.AddRider(this.rider);
            this.race.AddRider(riderTest);

            double result = this.race.CalculateAverageHorsePower();

            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void CalculateAverageHorsePowerShouldThrowExceptionIfThereArentEnoighParticipants()
        {
            this.race.AddRider(this.rider);

            Assert.Throws<InvalidOperationException>(() =>
            {
                double result = this.race.CalculateAverageHorsePower();
            }, "The race cannot start with less than 2 participants.");
        }
    }
}