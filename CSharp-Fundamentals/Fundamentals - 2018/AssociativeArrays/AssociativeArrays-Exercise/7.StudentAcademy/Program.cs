using System;
using System.Linq;
using System.Collections.Generic;

namespace _7.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            Dictionary<string, List<double>> averageMarks = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(student))
                {
                    students[student] = new List<double>();
                }   

                students[student].Add(grade);
            }

            averageMarks = students.Where(x => x.Value.Average() >= 4.5).OrderByDescending(x => x.Value.Average()).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in averageMarks)
            {
                string name = kvp.Key;
                List<double> grades = kvp.Value;
                Console.WriteLine($"{name} -> {grades.Average():F2}");
            }
        }
    }
}
