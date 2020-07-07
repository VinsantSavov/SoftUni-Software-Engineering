using P04.WildFarm.Exceptions;
using P04.WildFarm.Models;
using P04.WildFarm.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.WildFarm.Core
{
    public class Engine : IEngine
    {
        private ICollection<IAnimal> animals;

        public Engine()
        {
            this.animals = new List<IAnimal>();
        }

        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                IAnimal animal = ProduceAnimal(input);

                Food food = ProduceFood();

                try
                {
                    this.animals.Add(animal);

                    Console.WriteLine(animal.ProduceSound());
                    animal.Feed(food);
                }
                catch(NotValidFoodException ex)
                {
                    string message = String.Format(ex.Message, animal.GetType().Name, food.GetType().Name);

                    Console.WriteLine(message);
                }
            }

            foreach (var animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static IAnimal ProduceAnimal(string input)
        {
            string[] animalInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


            string type = animalInfo[0];
            string name = animalInfo[1];
            double weight = double.Parse(animalInfo[2]);

            IAnimal animal = null;

            if (type == "Owl")
            {
                double wingSize = double.Parse(animalInfo[3]);

                animal = new Owl(name, weight, wingSize);
            }
            else if (type == "Hen")
            {
                double wingSize = double.Parse(animalInfo[3]);

                animal = new Hen(name, weight, wingSize);
            }
            else
            {
                string livingRegion = animalInfo[3];

                if (type == "Mouse")
                {
                    animal = new Mouse(name, weight, livingRegion);
                }
                else if (type == "Dog")
                {
                    animal = new Dog(name, weight, livingRegion);
                }
                else
                {
                    string breed = animalInfo[4];

                    if (type == "Cat")
                    {
                        animal = new Cat(name, weight, livingRegion, breed);
                    }
                    else if (type == "Tiger")
                    {
                        animal = new Tiger(name, weight, livingRegion, breed);
                    }
                }
            }

            return animal;
        }

        private static Food ProduceFood()
        {
            string[] foodInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string foodType = foodInfo[0];
            int quantity = int.Parse(foodInfo[1]);

            Food food = null;
            if (foodType == "Seeds")
            {
                food = new Seeds(quantity);
            }
            else if (foodType == "Meat")
            {
                food = new Meat(quantity);
            }
            else if (foodType == "Vegetable")
            {
                food = new Vegetable(quantity);
            }
            else if (foodType == "Fruit")
            {
                food = new Fruit(quantity);
            }

            return food;
        }
    }
}
