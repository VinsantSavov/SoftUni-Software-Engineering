using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(" : ").ToArray();
                string courseName = tokens[0];
                string student = tokens[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(student);
                }
                else
                {
                    courses[courseName].Add(student);
                }
            }

            foreach (var course in courses.OrderByDescending(n=>n.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value.OrderBy(n=>n))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
