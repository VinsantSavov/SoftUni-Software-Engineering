using System;
using System.Collections.Generic;

namespace P04.WildFarm.Models
{
    public class Owl : Bird
    {
        private const double WEIGHT_GAIN = 0.25;
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
            this.Foods = new List<Type>() { typeof(Meat) };
        }

        public override double WeightGain => WEIGHT_GAIN;

        public override IReadOnlyCollection<Type> Foods { get; }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
