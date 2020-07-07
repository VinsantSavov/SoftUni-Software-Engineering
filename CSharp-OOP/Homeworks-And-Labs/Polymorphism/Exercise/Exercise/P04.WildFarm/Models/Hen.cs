using System;
using System.Collections.Generic;

namespace P04.WildFarm.Models
{
    public class Hen : Bird
    {
        private const double WEIGHT_GAIN = 0.35;
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
            this.Foods = new List<Type>() { typeof(Fruit), typeof(Meat), typeof(Seeds), typeof(Vegetable) };
        }

        public override double WeightGain => WEIGHT_GAIN;

        public override IReadOnlyCollection<Type> Foods { get; }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
