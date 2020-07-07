using System;

namespace P04.PizzaCalories
{
    public class Dough
    {
        private const int BASE_CALORIES = 2;
        private const double TYPE_WHITE = 1.5;
        private const double TYPE_WHOLEGRAIN = 1;
        private const double TECHNIQUE_CRISPY = 0.9;
        private const double TECHNIQUE_CHEWY = 1.1;
        private const double TECHNIQUE_HOMEMADE = 1;

        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            if(Validator.ValidateTypeAndTechique(flourType, bakingTechnique))
            {
                if (Validator.ValidateWeight(weight))
                {
                    this.flourType = flourType;
                    this.bakingTechnique = bakingTechnique;
                    this.weight = weight;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range[1..200].");
                }
            }
            else
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                return this.CaloriesPerGramCalculation() * weight * BASE_CALORIES;
            }
        }

        private double CaloriesPerGramCalculation()
        {
            double caloriesPerGram = 0;
            double flourTypeCalories = 0;
            double bakingTechniqueCalories = 0;

            switch (flourType.ToLower())
            {
                case "white":
                    flourTypeCalories = TYPE_WHITE;
                    break;
                case "wholegrain":
                    flourTypeCalories = TYPE_WHOLEGRAIN;
                    break;
            }

            switch (bakingTechnique.ToLower())
            {
                case "crispy":
                    bakingTechniqueCalories = TECHNIQUE_CRISPY;
                    break;
                case "chewy":
                    bakingTechniqueCalories = TECHNIQUE_CHEWY;
                    break;
                case "homemade":
                    bakingTechniqueCalories = TECHNIQUE_HOMEMADE;
                    break;
            }

            caloriesPerGram = flourTypeCalories * bakingTechniqueCalories;

            return caloriesPerGram;
        }

        private double WholeCalories()
        {
            return weight * this.CaloriesPerGramCalculation() * BASE_CALORIES;
        }
    }
}
