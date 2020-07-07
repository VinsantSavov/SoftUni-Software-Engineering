using System;
using System.Collections.Generic;

namespace P04.WildFarm.Models
{
    public class Cat : Feline
    {
        private const double WEIGHT_GAIN = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
            this.Foods = new List<Type>() { typeof(Vegetable), typeof(Meat) }; 
        }

        public override double WeightGain => WEIGHT_GAIN;

        public override IReadOnlyCollection<Type> Foods { get; }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
