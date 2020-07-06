using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            Dictionary<string, double> averageGrades = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(student))
                {
                    students.Add(student, grade);
                    counts.Add(student, 1);
                }
                else
                {
                    students[student] += grade;
                    counts[student]++;
                }
            }

            foreach (var student in students)
            {
                foreach (var count in counts)
                {
                    if(count.Key == student.Key)
                    {
                        double av = student.Value / count.Value;
                        if(av >= 4.5)
                        {
                            averageGrades.Add(count.Key, av);
                        }
                    }
                }
            }

            foreach (var student in averageGrades.OrderByDescending(s=>s.Value))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}
