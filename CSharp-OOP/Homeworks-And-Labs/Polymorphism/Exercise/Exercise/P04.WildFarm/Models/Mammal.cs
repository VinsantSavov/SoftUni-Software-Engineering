using System;
using System.Collections.Generic;

namespace P04.WildFarm.Models
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }
    }
}
