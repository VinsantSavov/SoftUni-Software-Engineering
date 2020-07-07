using NUnit.Framework;
using Skeleton;
using System;

[TestFixture]
public class AxeTests
{
    private const int Attack = 5;

    [Test]
    public void TestIfWeaponLosesDurabilityAfterAttack()
    {
        //Arrange
        var axe = new Axe(Attack, 2);

        //Act
        axe.Attack(new Dummy(100, 50));

        //Assert
        Assert.That(axe.DurabilityPoints, Is.EqualTo(1));
    }

    [Test]
    public void TestAttackWithBrokenWeapon()
    {
        //Arrange
        var axe = new Axe(Attack, 0);
        var target = new Dummy(50, 100);

        //Act

        //Assert
        Assert.That(() => axe.Attack(target), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
    }
}