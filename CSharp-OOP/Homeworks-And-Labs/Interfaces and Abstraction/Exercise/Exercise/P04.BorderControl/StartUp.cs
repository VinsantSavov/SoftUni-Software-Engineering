using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.BorderControl.Models
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> people = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(info.Length == 4)
                {
                    string name = info[0];
                    int age = int.Parse(info[1]);
                    string id = info[2];
                    string birthdate = info[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    people.Add(citizen);
                }
                else
                {
                    string name = info[0];
                    int age = int.Parse(info[1]);
                    string group = info[2];

                    Rebel rebel = new Rebel(name, age, group);
                    people.Add(rebel);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                IBuyer person = people.FirstOrDefault(n => n.Name == input);

                if(person != null)
                {
                    person.BuyFood();
                }
            }

            Console.WriteLine(people.Sum(p=>p.Food));
        }
    }
}
