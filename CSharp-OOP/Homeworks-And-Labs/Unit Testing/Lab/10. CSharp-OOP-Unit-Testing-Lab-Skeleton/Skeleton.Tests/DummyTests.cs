using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private const int AliveDummyHealth = 10;
    private const int DeadDummyHealth = 0;
    private const int Experience = 10;

    private Dummy aliveDummy;
    private Dummy deadDummy;

    [SetUp]
    public void SetDummies()
    {
        this.aliveDummy = new Dummy(AliveDummyHealth, Experience);
        this.deadDummy = new Dummy(DeadDummyHealth, Experience);
    }

    [Test]
    public void DummyLosesHealthIfAttacked()
    {
        //Act
        this.aliveDummy.TakeAttack(1);

        //Assert
        Assert.That(this.aliveDummy.Health, Is.EqualTo(9));
    }

    [Test]
    public void DeadDummyThrowsExceptionWhenAttacked()
    {
        //Assert
        Assert.That(() => this.deadDummy.TakeAttack(50),
            Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DeadDummyGivesExperience()
    {
        //Act
        var experience = this.deadDummy.GiveExperience();

        //Assert
        Assert.That(experience, Is.EqualTo(10));
    }

    [Test]
    public void AliveDummyCantGiveExperience()
    {

        //Assert
        Assert.That(() => this.aliveDummy.GiveExperience(),
            Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
}
