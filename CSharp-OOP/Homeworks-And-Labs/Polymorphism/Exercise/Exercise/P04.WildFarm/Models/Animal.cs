using P04.WildFarm.Exceptions;
using P04.WildFarm.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        private const string FoodExc = "{0} does not eat {1}!";
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract double WeightGain { get; }

        public abstract IReadOnlyCollection<Type> Foods { get; }

        public void Feed(IFood food)
        {
            if (!this.Foods.Contains(food.GetType()))
            {
                throw new NotValidFoodException(FoodExc);
            }

            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * this.WeightGain;
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
