using Moq;
using Skeleton;
using NUnit.Framework;
using Skeleton.Tests.Fakes;

[TestFixture]
public class HeroTests
{
    [Test]
    public void HeroGainsExperienceWhenTargetDies()
    {
        //Arrange
        var fakeTarget = new Mock<ITarget>();
        var fakeWeapon = new Mock<IWeapon>();
        var hero = new Hero("Bosko", fakeWeapon.Object);

        fakeTarget.Setup(t => t.IsDead())
            .Returns(true);

        fakeTarget.Setup(t => t.GiveExperience())
            .Returns(10);

        hero.Attack(fakeTarget.Object);

        Assert.That(hero.Experience, Is.EqualTo(10));
    }
}