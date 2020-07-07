
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class WarriorTests
    {
        private const int MIN_ATTACK_HP = 30;

        private Warrior fightingWarrior;

        [SetUp]
        public void Setup()
        {
            this.fightingWarrior = new Warrior("Brut", 50, 100);
        }

        [Test]
        public void NameProperty()
        {
            Assert.That(this.fightingWarrior.Name, Is.EqualTo("Brut"));

            Assert.That(() =>
            {
                Warrior warrior = new Warrior(null, 20, 20);
            }, Throws.ArgumentException.With.Message.EqualTo("Name should not be empty or whitespace!"));
        }

        [Test]
        public void DamageProperty()
        {
            Assert.That(this.fightingWarrior.Damage, Is.EqualTo(50));

            Assert.That(() =>
            {
                Warrior warrior = new Warrior("Brut", 0, 100);
            }, Throws.ArgumentException.With.Message.EqualTo("Damage value should be positive!"));
        }

        [Test]
        public void HpProperty()
        {
            Assert.That(this.fightingWarrior.HP, Is.EqualTo(100));

            Assert.That(() =>
            {
                Warrior warrior = new Warrior("Brut", 10, -20);
            }, Throws.ArgumentException.With.Message.EqualTo("HP should not be negative!"));
        }

        [Test]
        public void WarriorShouldBeAbleToAttackAnotherWarrior()
        {
            int ourHeorHP = this.fightingWarrior.HP;

            Assert.That(() =>
            {
                Warrior warrior = new Warrior("First", 10, 20);
                warrior.Attack(this.fightingWarrior);
            }, Throws.InvalidOperationException.With.Message
            .EqualTo("Your HP is too low in order to attack other warriors!"));

            Assert.That(() =>
            {
                Warrior warrior = new Warrior("First", 10, 20);
                this.fightingWarrior.Attack(warrior);
            }, Throws.InvalidOperationException.With.Message
            .EqualTo($"Enemy HP must be greater than {MIN_ATTACK_HP} in order to attack him!"));

            Assert.That(() =>
            {
                Warrior warrior = new Warrior("First", 150, 100);
                this.fightingWarrior.Attack(warrior);
            }, Throws.InvalidOperationException.With.Message.EqualTo("You are trying to attack too strong enemy"));

            Warrior enemyWarrior = new Warrior("First", 10, 40);
            Warrior secondEnemy = new Warrior("Second", 10, 100);
            this.fightingWarrior.Attack(enemyWarrior);

            Assert.That(this.fightingWarrior.HP, Is.EqualTo(90));

            Assert.That(enemyWarrior.HP, Is.EqualTo(0));

            this.fightingWarrior.Attack(secondEnemy);
            Assert.That(secondEnemy.HP, Is.EqualTo(50));
        }
    }
}