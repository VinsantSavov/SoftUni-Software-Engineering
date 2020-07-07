using NUnit.Framework;
//using ExtendedDatabase;
using System;

namespace Tests
{
    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase extendedDatabase;
        private ExtendedDatabase extendedDatabaseWithManyPeople;
        private Person[] people;

        [SetUp]
        public void Setup()
        {
            this.people = new Person[3] { new Person(1, "Pesho"), new Person(2, "Gosho"), new Person(3, "Vasil") };
            this.extendedDatabase = new ExtendedDatabase(people);
        }

        public void CreateDatabaseWithManyPeople(int count)
        {
            this.extendedDatabaseWithManyPeople = new ExtendedDatabase();

            for (int i = 0; i < count; i++)
            {
                extendedDatabaseWithManyPeople.Add(new Person(i, $"Peshi + {i}"));
            }
        }

        [Test]
        public void AddMethodShouldAddPersonAtTheEnd()
        {
            //Act
            this.extendedDatabase.Add(new Person(4, "Kondio"));

            Assert.That(this.extendedDatabase.Count, Is.EqualTo(4));
            Assert.That(() =>
            {
                this.extendedDatabase.Add(new Person(4, "Gogo"));
            }, Throws.InvalidOperationException.With.Message.EqualTo("There is already user with this Id!"));
            Assert.That(() =>
            {
                this.extendedDatabase.Add(new Person(5, "Pesho"));
            }, Throws.InvalidOperationException.With.Message.EqualTo("There is already user with this username!"));
            Assert.That(() =>
            {
                this.CreateDatabaseWithManyPeople(17);
            }, Throws.InvalidOperationException.With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void ConstructorWorksCorrectly()
        { 
            this.CreateDatabaseWithManyPeople(16);

            Assert.That(this.extendedDatabaseWithManyPeople.Count, Is.EqualTo(16));
        }

        [Test]
        public void RemoveMethodWorksCorrectly()
        {
            this.extendedDatabase.Remove();

            Assert.That(this.extendedDatabase.Count, Is.EqualTo(2));
            Assert.That(() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    this.extendedDatabase.Remove();
                }
            }, Throws.InvalidOperationException);
        }

        [Test]
        public void FindByUsernameShouldWorkCorrectly()
        {
            Person person = this.extendedDatabase.FindByUsername("Gosho");

            Assert.That(person.UserName, Is.EqualTo("Gosho"));
            Assert.That(() =>
            {
                this.extendedDatabase.FindByUsername("DFG");
            }, Throws.InvalidOperationException.With.Message.EqualTo("No user is present by this username!"));
            Assert.Throws<ArgumentNullException>(() =>
            {
                this.extendedDatabase.FindByUsername(null);
            });

            /*Assert.That(() =>
            {
                this.extendedDatabase.FindByUsername(null);
            }, Throws.ArgumentNullException.With.Message.EqualTo("Username parameter is null!"));*/
        }

        [Test]
        public void FindByIdShouldWorkCorrectly()
        {
            /*Assert.That(() =>
            {
                this.extendedDatabase.FindById(-1);
            }, Throws.ArgumentException.With.Message.EqualTo("Id should be a positive number!"));*/

            Person person = this.extendedDatabase.FindById(1);

            Assert.That(person.Id, Is.EqualTo(1));
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                this.extendedDatabase.FindById(-1);
            }, "Id should be a positive number!");
            Assert.That(() =>
            {
                this.extendedDatabase.FindById(55);
            }, Throws.InvalidOperationException.With.Message.EqualTo("No user is present by this ID!"));
            /*Assert.That(() =>
            {
                Person person = this.extendedDatabase.FindById(1);
            }, Is.EqualTo(this.extendedDatabase.FindById(1)));*/
        }
    }
}