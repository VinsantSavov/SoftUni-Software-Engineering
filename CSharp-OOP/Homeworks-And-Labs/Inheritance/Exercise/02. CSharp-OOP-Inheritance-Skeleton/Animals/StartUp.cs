using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string input = Console.ReadLine();
                Animal animal = null;

                if (input == "Beast!")
                {
                    break;
                }

                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                int age = int.Parse(info[1]);
                string gender = info[2];

                try
                {
                    animal = ExtractAnimal(input, animal, name, age, gender);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                animals.Add(animal);
            }

            PrintAnimal(animals);
        }

        private static Animal ExtractAnimal(string input, Animal animal, string name, int age, string gender)
        {
            if (input == "Cat")
            {
                animal = new Cat(name, age, gender);
            }
            else if (input == "Dog")
            {
                animal = new Dog(name, age, gender);
            }
            else if (input == "Frog")
            {
                animal = new Frog(name, age, gender);
            }
            else if (input == "Kitten")
            {
                animal = new Kitten(name, age, gender);
            }
            else if (input == "Tomcat")
            {
                animal = new Tomcat(name, age, gender);
            }

            return animal;
        }

        private static void PrintAnimal(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
