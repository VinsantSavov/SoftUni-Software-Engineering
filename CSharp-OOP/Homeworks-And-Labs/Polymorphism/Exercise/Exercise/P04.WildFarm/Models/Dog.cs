using System;
using System.Collections.Generic;

namespace P04.WildFarm.Models
{
    public class Dog : Mammal
    {
        private const double WEIGHT_GAIN = 0.40;
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
            this.Foods = new List<Type>() { typeof(Meat) };
        }

        public override double WeightGain => WEIGHT_GAIN;

        public override IReadOnlyCollection<Type> Foods { get; }

        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
