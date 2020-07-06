using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Students
{
    class Program
    {
        class Student
        {
            public Student(string fname, string sname,double grade)
            {
                FirstName = fname;
                LastName = sname;
                Grade = grade;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
        }

        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] line = Console.ReadLine().Split();
                string firstName = line[0];
                string lastName = line[1];
                double grade = double.Parse(line[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            foreach (var kvp in students)
            {
                Console.WriteLine($"{kvp.FirstName} {kvp.LastName}: {kvp.Grade:f2}");
            }
        }
    }
}
