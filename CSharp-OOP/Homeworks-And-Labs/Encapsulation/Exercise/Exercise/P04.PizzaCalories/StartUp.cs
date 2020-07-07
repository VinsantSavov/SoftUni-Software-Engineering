using System;
using System.Linq;

namespace P04.PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split(new [] {" "}, StringSplitOptions.None);
            string pizzaName = info[1];

            string[] doughInput = Console.ReadLine().Split(" ").ToArray();
            string flourType = doughInput[1];
            string bakingTechnique = doughInput[2];
            double doughWeight = double.Parse(doughInput[3]);

            try
            {
                Dough dough = new Dough(flourType, bakingTechnique, doughWeight);
                Pizza pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "END")
                    {
                        break;
                    }

                    string[] toppingInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string toppingType = toppingInfo[1];
                    double toppingWeight = double.Parse(toppingInfo[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);
                    pizza.AddTopping(topping);

                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories():F2} Calories.");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
