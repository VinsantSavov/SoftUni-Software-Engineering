using Moq;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class FakeTests
    {
        [Test]
        public void TheyAreCorrect()
        {
            var fakeTester = new Mock<IFakeTester>();
            double result = 0;

            fakeTester.Setup(t => t.Sum(It.IsAny<int>(), It.IsAny<double>()))
                .Callback((int first, double second) =>
                {
                    result = first + second;
                });

            fakeTester.Setup(t => t.Sum(It.Is<int>(n => n == 10), It.IsAny<double>()))
                .Callback((int first, double second) =>
                {
                    result = first + second;
                });

            fakeTester.Setup(t => t.Location(It.IsAny<string>()))
                .Returns((string loc) =>
                {
                    return loc;
                });

            var obj = fakeTester.Object;
            obj.Sum(10, 5.5);

            Assert.That(result, Is.EqualTo(15.5));
            Assert.That(obj.Location("Moiski"), Is.EqualTo("Moiski"));
        }
    }
}
