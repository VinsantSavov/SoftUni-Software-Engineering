using System;
using System.Collections.Generic;

namespace P05.ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int equalPeople = 0;
            int diffrentPeople = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                int age = int.Parse(info[1]);
                string town = info[2];

                Person person = new Person(name, age, town);
                people.Add(person);
            }

            int n = int.Parse(Console.ReadLine());
            n -= 1;
            Person chosen = people[n];

            foreach (var person in people)
            {
                int comp = chosen.CompareTo(person);

                if(comp == 0)
                {
                    equalPeople++;
                }
                else
                {
                    diffrentPeople++;
                }
            }

            if(equalPeople > 1)
            {
                Console.WriteLine($"{equalPeople} {diffrentPeople} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
