using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.OrderByAge
{
    public class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                string[] tokens = input.Split().ToArray();
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                Person person = new Person(name, id, age);
                people.Add(person);
            }
            people = people.OrderBy(p => p.Age).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
