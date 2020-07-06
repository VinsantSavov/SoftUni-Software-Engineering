using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.OrderByAge
{
    class Program
    {
        class People
        {
            public People(string name,string id,int age)
            {
                Name = name;
                PersonID = id;
                Age = age;
            }

            public string Name { get; set; }
            public string PersonID { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            List<People> people = new List<People>();
            while (true)
            {
                string[] line = Console.ReadLine().Split();
                string name = line[0];
                

                if(name == "End")
                {
                    break;
                }
                string ID = line[1];
                int age = int.Parse(line[2]);

                People person = new People(name, ID, age);
                people.Add(person);
                
            }

            people = people.OrderBy(x => x.Age).ToList();

            foreach (var kvp in people)
            {
                Console.WriteLine($"{kvp.Name} with ID: {kvp.PersonID} is {kvp.Age} years old.");
            }
        }
    }
}
