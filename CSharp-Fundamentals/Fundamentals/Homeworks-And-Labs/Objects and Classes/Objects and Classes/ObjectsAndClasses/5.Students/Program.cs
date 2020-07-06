using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Students
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string homeTown { get; set; }
    }

    class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }
                
                List<string> tokens = input.Split().ToList();

                Student student = new Student()
                {
                    firstName = tokens[0],
                    lastName = tokens[1],
                    age = int.Parse(tokens[2]),
                    homeTown = tokens[3]
                };

                students.Add(student);
            
            }

            string city = Console.ReadLine();

            foreach (var student in students)
            {
                if(city == student.homeTown)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }
        }
    }
}
