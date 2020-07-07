using P03.Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> raidGroup = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                BaseHero hero = null;

                try
                {
                    if (heroType == "Druid")
                    {
                        hero = new Druid(heroName);
                    }
                    else if (heroType == "Paladin")
                    {
                        hero = new Paladin(heroName);
                    }
                    else if (heroType == "Warrior")
                    {
                        hero = new Warrior(heroName);
                    }
                    else if (heroType == "Rogue")
                    {
                        hero = new Rogue(heroName);
                    }
                    else
                    {
                        throw new InvalidHeroException();
                    }

                    raidGroup.Add(hero);
                }
                catch(InvalidHeroException ex)
                {
                    Console.WriteLine(ex.Message);

                    i--;
                }
            }

            int result = raidGroup.Sum(h=>h.Power);
            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
            }

            if(result >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
