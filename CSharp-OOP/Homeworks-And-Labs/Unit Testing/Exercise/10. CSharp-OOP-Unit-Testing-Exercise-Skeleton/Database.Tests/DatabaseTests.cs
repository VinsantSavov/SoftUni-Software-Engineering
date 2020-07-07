using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private int[] addMethodArray;
        private int[] removeMethodArray;

        [SetUp]
        public void Setup()
        {
            this.addMethodArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            this.removeMethodArray = new int[] { 1 };
        }

        [Test]
        public void TheConstructorShouldTakeOnlyInts()
        {
            Database.Database database = new Database.Database(this.addMethodArray);

            Assert.That(database.Count, Is.EqualTo(15));
        }

        [Test]
        public void TheAddMethodShouldAddElementsAtTheNextFreeCell()
        {
            //Arrange
            Database.Database database = new Database.Database(this.addMethodArray);

            //Act
            database.Add(16);

            //Assert
            Assert.That(database.Count, Is.EqualTo(16));
            Assert.That(() =>
            {
                database.Add(17);
            }, Throws.InvalidOperationException.With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void TheRemoveMethodShouldRemoveElementsAtTheLastPosition()
        {
            //Arrange
            Database.Database database = new Database.Database(this.removeMethodArray);

            //Act
            database.Remove();

            //Assert
            Assert.That(database.Count, Is.EqualTo(0));
            Assert.That(() =>
            {
                database.Remove();
            }, Throws.InvalidOperationException.With.Message.EqualTo("The collection is empty!"));
        }

        [Test]
        public void TheFetchMethodShouldReturnTheElementsAsArray()
        {
            //Arrange
            Database.Database database = new Database.Database(this.addMethodArray);

            //Act
            int[] fetchedArray = database.Fetch();

            //Assert
            Assert.That(fetchedArray.Length, Is.EqualTo(database.Count));
        }
    }
}