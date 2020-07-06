using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Students
{
    class Program
    {
        private static object list;

        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string town = tokens[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Hometown = town
                };
                students.Add(student);
            }
            string city = Console.ReadLine();

            foreach (var student in students)
            {
                if (city == student.Hometown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
