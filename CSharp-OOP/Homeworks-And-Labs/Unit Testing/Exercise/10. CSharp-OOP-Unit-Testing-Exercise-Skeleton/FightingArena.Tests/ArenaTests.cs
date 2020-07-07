
using Moq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;
        private Mock<Warrior> firstWarrior;
        private Mock<Warrior> secondWarrior;

        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
            this.firstWarrior = new Mock<Warrior>("Josh", 20, 50);
            this.secondWarrior = new Mock<Warrior>("Venture", 20, 50);
            this.arena.Enroll(firstWarrior.Object);
            this.arena.Enroll(secondWarrior.Object);
        }

        [Test]
        public void EnrollMethodShouldAddWarriorCorrectly()
        {
            var warriorToAdd = new Mock<Warrior>("Basi", 30, 60);
            var warrior = new Mock<Warrior>("Basi", 30, 60);
            this.arena.Enroll(warriorToAdd.Object);

            Assert.That(this.arena.Count, Is.EqualTo(3));

            Assert.That(() =>
            {
                this.arena.Enroll(warrior.Object);
            }, Throws.InvalidOperationException.With.Message.EqualTo("Warrior is already enrolled for the fights!"));
        }

        [Test]
        public void FightMethodShouldWork()
        {
            this.arena.Fight("Josh", "Venture");

            Assert.That(this.firstWarrior.Object.HP, Is.EqualTo(30));
            Assert.That(this.secondWarrior.Object.HP, Is.EqualTo(30));
            Assert.That(() =>
            {
                this.arena.Fight("Josh", "Doge");
            }, Throws.InvalidOperationException.With.Message
            .EqualTo("There is no fighter with name Doge enrolled for the fights!"));

        }
    }
}
