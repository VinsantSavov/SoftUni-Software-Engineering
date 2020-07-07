using System;
using NUnit.Framework;

public class HeroRepositoryTests
{
    private Hero testHeroOne;
    private Hero testHeroTwo;
    private HeroRepository heroRepository;

    [SetUp]
    public void SetUp()
    {
        this.testHeroOne = new Hero("Test one", 1);
        this.testHeroTwo = new Hero("Test two", 2);
        this.heroRepository = new HeroRepository();
    }

    [Test]
    public void CreateHeroMethodShouldWorkProperly()
    {
        string testOne = this.heroRepository.Create(testHeroOne);
        string testTwo = this.heroRepository.Create(testHeroTwo);

        Assert.That(testOne, Is.EqualTo("Successfully added hero Test one with level 1"));
        Assert.That(testTwo, Is.EqualTo("Successfully added hero Test two with level 2"));
        Assert.That(this.heroRepository.Heroes.Count, Is.EqualTo(2));
        Assert.That(this.heroRepository.Heroes, Is.Not.Null);
    }

    [Test]
    public void CreateHeroShouldThrowNullException()
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            this.heroRepository.Create(null);
        }, "Hero is null");
    }

    [Test]
    public void CreateCannotCreateTwoHerosWithEqualNames()
    {
        this.heroRepository.Create(testHeroOne);

        Assert.Throws<InvalidOperationException>(() =>
        {
            this.heroRepository.Create(testHeroOne);
        }, "Hero with name Test one already exists");
    }

    [Test]
    public void RemoveShouldReturnTrue()
    {
        this.heroRepository.Create(testHeroOne);

        bool isRemoved = this.heroRepository.Remove("Test one");

        Assert.That(isRemoved, Is.True);
    }

    [Test]
    public void RemoveShouldReturnFalse()
    {
        this.heroRepository.Create(testHeroOne);

        bool isRemoved = this.heroRepository.Remove("Test two");

        Assert.That(isRemoved, Is.False);
    }

    [Test]
    public void RemoveMethodShouldThrowException()
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            this.heroRepository.Remove(null);
        }, "Name cannot be null");
    }

    [Test]
    public void GetHeroWithHighestLevelShouldWorkProperly()
    {
        this.heroRepository.Create(testHeroOne);
        this.heroRepository.Create(testHeroTwo);

        Hero hero = this.heroRepository.GetHeroWithHighestLevel();

        Assert.That(hero.Name, Is.EqualTo("Test two"));
        Assert.That(hero.Level, Is.EqualTo(2));
    }

    [Test]
    public void GetHeroShouldReturnHeroWithTheSameName()
    {
        this.heroRepository.Create(testHeroOne);
        this.heroRepository.Create(testHeroTwo);

        Hero hero = this.heroRepository.GetHero("Test one");

        Assert.That(hero.Name, Is.EqualTo("Test one"));
        Assert.That(hero.Level, Is.EqualTo(1));
    }
}