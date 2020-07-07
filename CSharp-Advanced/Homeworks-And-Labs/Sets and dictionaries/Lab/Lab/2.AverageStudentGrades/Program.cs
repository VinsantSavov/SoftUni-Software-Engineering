using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<decimal>());
                }

                grades[name].Add(grade);
            }

            foreach (var kvp in grades)
            {
                Console.Write(kvp.Key + " " + "->" + " ");

                foreach (var grade in kvp.Value)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.WriteLine($"(avg: {kvp.Value.Average():F2})");
            }
        }
    }
}
