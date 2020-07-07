using System;
using System.Collections.Generic;

namespace P04.WildFarm.Models
{
    public class Mouse : Mammal
    {
        private const double WEIGHT_GAIN = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
            this.Foods = new List<Type>() { typeof(Vegetable), typeof(Fruit) };
        }

        public override double WeightGain => WEIGHT_GAIN;

        public override IReadOnlyCollection<Type> Foods { get; }

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return base.ToString() + $"{Math.Round(this.Weight,2)}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
