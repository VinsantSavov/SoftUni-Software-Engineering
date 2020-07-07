using System;

namespace P04.PizzaCalories
{
    public class Topping
    {
        private const int BASE_CALORIES = 2;
        private const double TYPE_MEAT = 1.2;
        private const double TYPE_VEGGIES= 0.8;
        private const double TYPE_CHEESE = 1.1;
        private const double TYPE_SAUCE = 0.9;

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            if (Validator.ValidateToppingType(type))
            {
                if (Validator.ValidateToppingWeight(weight))
                {
                    this.type = type;
                    this.weight = weight;
                }
                else
                {
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                }
            }
            else
            {
                throw new ArgumentException($"Cannot place {type} on top of your pizza.");
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                return this.CalculateCaloriesPerGram() * weight * BASE_CALORIES;
            }
        }

        private double CalculateCaloriesPerGram()
        {
            double caloriesPerGram = 0;

            switch (type.ToLower())
            {
                case "meat":
                    caloriesPerGram = TYPE_MEAT;
                    break;
                case "veggies":
                    caloriesPerGram = TYPE_VEGGIES;
                    break;
                case "cheese":
                    caloriesPerGram = TYPE_CHEESE;
                    break;
                case "sauce":
                    caloriesPerGram = TYPE_SAUCE;
                    break;
            }

            return caloriesPerGram;
        }
    }
}
