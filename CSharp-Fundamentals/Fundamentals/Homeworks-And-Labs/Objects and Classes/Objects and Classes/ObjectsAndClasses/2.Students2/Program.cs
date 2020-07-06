using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Students2
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            

            while (true)
            {
                string input = Console.ReadLine();
                bool hasStudent = false;

                if (input == "end")
                {
                    break;
                }

                List<string> tokens = input.Split().ToList();
                

                if (students.Any())
                {
                    for (int i = 0; i < students.Count; i++)
                    {
                        if(tokens[0] == students[i].FirstName && tokens[1] == students[i].LastName)
                        {
                            students[i].Age = int.Parse(tokens[2]);
                            students[i].HomeTown = tokens[3];
                            hasStudent = true;
                        }
                        else if(i == students.Count-1 && hasStudent == false)
                        {
                            hasStudent = false;
                        }
                    }
                }
                if(hasStudent==false || students.Any()==false)
                {
                    Student student = new Student()
                    {
                        FirstName = tokens[0],
                        LastName = tokens[1],
                        Age = int.Parse(tokens[2]),
                        HomeTown = tokens[3]
                    };
                    students.Add(student);
                }
                
            }

            string town = Console.ReadLine();

            foreach (var student in students)
            {
                if(student.HomeTown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
