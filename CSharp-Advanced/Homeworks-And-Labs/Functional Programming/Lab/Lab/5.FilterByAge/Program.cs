using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var nameAge = new Dictionary<string, int>();
            Func<int, int, bool> older = (a, c) => a >= c;
            Func<int, int, bool> younger = (a, c) => a <= c;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);

                if (!nameAge.ContainsKey(name))
                {
                    nameAge.Add(name, age);
                }
            }

            string condition = Console.ReadLine();
            int ageCondition = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            if(condition == "older")
            {
                nameAge = nameAge.Where(n => older(n.Value, ageCondition)).ToDictionary(a => a.Key, b => b.Value);
            }
            else
            {
                nameAge = nameAge.Where(n => younger(n.Value, ageCondition)).ToDictionary(a => a.Key, b => b.Value);
            }

            //Func<string, int, string> outputFunc = format switch
            //{
            //    "name age" => (name, age) => $"{name} - {age}",
            //    "name" => (name, age) => $"{name}",
            //    "age" => (name, age) => age.ToString()
            //};

            if (format == "name age")
            {
                foreach (var kvp in nameAge)
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
            else if (format == "name")
            {
                foreach (var kvp in nameAge)
                {
                    Console.WriteLine($"{kvp.Key}");
                }
            }
            else if (format == "age")
            {
                foreach (var kvp in nameAge)
                {
                    Console.WriteLine($"{kvp.Value}");
                }
            }
        }
    }
}
