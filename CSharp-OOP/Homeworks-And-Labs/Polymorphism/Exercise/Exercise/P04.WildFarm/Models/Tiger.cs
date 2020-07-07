using System;
using System.Collections.Generic;

namespace P04.WildFarm.Models
{
    public class Tiger : Feline
    {
        private const double WEIGHT_GAIN = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
            this.Foods = new List<Type>() { typeof(Meat) };
        }

        public override double WeightGain => WEIGHT_GAIN;

        public override IReadOnlyCollection<Type> Foods { get; }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
