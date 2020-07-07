using NUnit.Framework;
using System;

namespace Robots.Tests
{


    public class RobotsTests
    {
        private Robot firstRobot;
        private Robot secondRobot;
        private RobotManager manager;

        [SetUp]
        public void SetUp()
        {
            this.firstRobot = new Robot("Test one", 5);
            this.secondRobot = new Robot("Test two", 10);
            this.manager = new RobotManager(2);
        }

        [Test]
        public void ConstructorShouldWorkProperly()
        {
            RobotManager robotMan = new RobotManager(1);

            Assert.That(robotMan.Capacity, Is.EqualTo(1));
            Assert.That(robotMan.Count, Is.EqualTo(0));
        }

        [Test]
        public void CapacityShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                RobotManager robotMan = new RobotManager(-1);
            }, "Invalid capacity!");
        }

        [Test]
        public void CountShouldWorkProperly()
        {
            this.manager.Add(firstRobot);
            this.manager.Add(secondRobot);

            Assert.That(this.manager.Count, Is.EqualTo(2));
        }

        [Test]
        public void CannotAddRobotWithTheSameName()
        {
            Robot robot = new Robot("Test one", 12);
            this.manager.Add(firstRobot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.manager.Add(robot);
            }, "There is already a robot with name Test one!");
        }

        [Test]
        public void CannotAddMoreRobotsThanTheCapacity()
        {
            Robot robot = new Robot("Test", 12);
            this.manager.Add(firstRobot);
            this.manager.Add(secondRobot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.manager.Add(robot);
            }, "Not enough capacity!");
        }

        [Test]
        public void RemoveShouldWorkProperly()
        {
            this.manager.Add(firstRobot);
            this.manager.Add(secondRobot);

            this.manager.Remove("Test one");

            Assert.That(this.manager.Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveCannotRemoveRobotIfTheNameIsInvalid()
        {
            this.manager.Add(firstRobot);
            this.manager.Add(secondRobot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.manager.Remove("Invalid");
            }, "Robot with the name Invalid doesn't exist!");
        }

        [Test]
        public void ManagerShouldThrowExceptionWhenNameIsInvalid()
        {
            this.manager.Add(firstRobot);
            this.manager.Add(secondRobot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.manager.Work("Invalid", "cook", 3);
            }, "Robot with the name Invalid doesn't exist!");
        }

        [Test]
        public void ManagerShouldThrowExceptionWhenBatteryUsageIsMoreThanBattery()
        {
            this.manager.Add(firstRobot);
            this.manager.Add(secondRobot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.manager.Work("Test one", "cook", 20);
            }, "Test one doesn't have enough battery!");
        }

        [Test]
        public void WorkMethodShouldWotkProperly()
        {
            this.manager.Add(firstRobot);
            this.manager.Add(secondRobot);

            this.manager.Work("Test one", "cook", 2);

            Assert.That(this.firstRobot.Battery, Is.EqualTo(3));
        }

        [Test]
        public void ChargeShouldThrowExceptionWhenTheNameIsInvalid()
        {
            this.manager.Add(firstRobot);
            this.manager.Add(secondRobot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.manager.Charge("Invalid");
            }, "Robot with the name Invalid doesn't exist!");
        }

        [Test]
        public void ChargeShouldWorkProperly()
        {
            this.manager.Add(firstRobot);
            this.manager.Add(secondRobot);

            this.manager.Work("Test one", "cook", 2);
            this.manager.Charge("Test one");

            Assert.That(this.firstRobot.Battery, Is.EqualTo(this.firstRobot.MaximumBattery));
        }
    }
}
