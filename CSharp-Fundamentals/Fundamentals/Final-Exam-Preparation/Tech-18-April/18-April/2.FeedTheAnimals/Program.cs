using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.FeedTheAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animalFood = new Dictionary<string, int>();
            Dictionary<string, int> areaAnimal = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Last Info")
                {
                    break;
                }

                string[] tokens = input.Split(":");
                string command = tokens[0];
                string animal = tokens[1];
                int food = int.Parse(tokens[2]);
                string area = tokens[3];

                if(command == "Add")
                {
                    if (!animalFood.ContainsKey(animal))
                    {
                        animalFood.Add(animal, 0);
                        if (!areaAnimal.ContainsKey(area))
                        {
                            areaAnimal.Add(area, 1);
                        }
                        else
                        {
                            areaAnimal[area]++;
                        }
                        
                    }
                     animalFood[animal] += food;

                }
                else if(command == "Feed")
                {
                    if (animalFood.ContainsKey(animal))
                    {
                        animalFood[animal] = animalFood[animal] - food;
                        if(animalFood[animal] <= 0)
                        {
                            animalFood.Remove(animal);
                            areaAnimal[area]--;
                            Console.WriteLine($"{animal} was successfully fed");
                        }
                    }
                }
            }
            animalFood = animalFood.OrderByDescending(f => f.Value).ThenBy(n => n.Key).ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine("Animals: ");
            foreach (var kvp in animalFood)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}g");
            }
            Console.WriteLine("Areas with hungry animals: ");

            areaAnimal = areaAnimal.OrderByDescending(c => c.Value).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in areaAnimal)
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key} : {kvp.Value}");
                }
            }
        }
    }
}
