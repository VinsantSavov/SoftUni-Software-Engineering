using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            data = new List<Hero>();
        }

        public int Count
        {
            get
            {
                return data.Count;
            }
        }

        public void Add(Hero hero)
        {
            data.Add(hero);
        }

        public void Remove(string name)
        {
            Hero heroToRemove = data.FirstOrDefault(h => h.Name == name);

            if(heroToRemove != null)
            {
                data.Remove(heroToRemove);
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero heroStr = null;
            int maxStr = 0;

            foreach (var hero in data)
            {
                if(hero.Item.Strength > maxStr)
                {
                    heroStr = hero;
                    maxStr = hero.Item.Strength;
                }
            }

            return heroStr;
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero heroAb = null;
            int maxAbility = 0;

            foreach (var hero in data)
            {
                if(hero.Item.Ability > maxAbility)
                {
                    heroAb = hero;
                    maxAbility = hero.Item.Ability;
                }
            }

            return heroAb;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero heroInt = null;
            int maxIntelligence = 0;

            foreach (var hero in data)
            {
                if(hero.Item.Intelligence > maxIntelligence)
                {
                    heroInt = hero;
                    maxIntelligence = hero.Item.Intelligence;
                }
            }

            return heroInt;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in data)
            {
                sb.AppendLine(hero.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
