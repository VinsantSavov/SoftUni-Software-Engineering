using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int DEF_POWER = 100;
        public Warrior(string name)
            : base(name, DEF_POWER)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
