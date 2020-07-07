namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;

    public class Tests
    {
        private const string make = "Test";
        private const string model = "One";

        [Test]
        public void ConstructorShouldWorkProperly()
        {
            Phone phone = new Phone(make, model);

            Assert.That(phone.Make, Is.EqualTo(make));
            Assert.That(phone.Model, Is.EqualTo(model));
            Assert.That(phone.Count, Is.Zero);
        }

        [Test]
        public void MakeCannotBeNullOrEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Phone phone = new Phone(null, model);
            }, "Invalid Make!");

            Assert.Throws<ArgumentException>(() =>
            {
                Phone phone = new Phone("", model);
            }, "Invalid Make!");
        }

        [Test]
        public void ModelCannotBeNullOrEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Phone phone = new Phone(make, null);
            }, "Invalid Model!");

            Assert.Throws<ArgumentException>(() =>
            {
                Phone phone = new Phone(make, "");
            }, "Invalid Model!");
        }

        [Test]
        public void AddContractShouldWorkProperly()
        {
            Phone phone = new Phone(make, model);
            phone.AddContact("Melvi", "088");
            phone.AddContact("Tate", "089");
            phone.AddContact("Mama", "089");

            Assert.That(phone.Count, Is.EqualTo(3));
        }

        [Test]
        public void CannotAddContactWithTheSameName()
        {
            Phone phone = new Phone(make, model);
            phone.AddContact("Melvi", "088");
            phone.AddContact("Tate", "089");

            Assert.Throws<InvalidOperationException>(() =>
            {
                phone.AddContact("Tate", "067");
            }, "Person already exists!");
        }

        [Test]
        public void CallShouldWorkProperly()
        {
            Phone phone = new Phone(make, model);
            phone.AddContact("Melvi", "088");
            phone.AddContact("Tate", "089");

            string result = phone.Call("Melvi");

            Assert.That(result, Is.EqualTo("Calling Melvi - 088..."));
        }

        [Test]
        public void CallShouldThrowExceptionIfThePersonDoesntExist()
        {
            Phone phone = new Phone(make, model);
            phone.AddContact("Melvi", "088");
            phone.AddContact("Tate", "089");

            Assert.Throws<InvalidOperationException>(() =>
            {
                phone.Call("Mama");
            }, "Person doesn't exists!");
        }
    }
}