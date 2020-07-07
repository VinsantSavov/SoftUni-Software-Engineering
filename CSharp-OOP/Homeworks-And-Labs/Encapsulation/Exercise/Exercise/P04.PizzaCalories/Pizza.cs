using System;
using System.Collections.Generic;

namespace P04.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            get
            {
                return this.dough;
            }
            set
            {
                this.dough = value;
            }
        }

        public int NumberOfToppings
        {
            get
            {
                return this.toppings.Count;
            }
        }

        public void AddTopping(Topping topping)
        {
            if(this.toppings.Count < 10)
            {
                this.toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }

        public double TotalCalories()
        {
            double totalCalories = 0;

            totalCalories += this.dough.CaloriesPerGram;

            foreach (var topping in this.toppings)
            {
                totalCalories += topping.CaloriesPerGram;
            }

            return totalCalories;
        }
    }
}
