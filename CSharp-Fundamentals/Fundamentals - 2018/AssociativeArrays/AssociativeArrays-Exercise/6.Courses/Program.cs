using System;
using System.Linq;
using System.Collections.Generic;

namespace _6.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> registers = new Dictionary<string, List<string>>();
            List<string> users = new List<string>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split(" : ").ToList();

                if (input[0] == "end")
                {
                    break;
                }
                string course = input[0];
                string student = input[1];

                if (!registers.ContainsKey(input[0]))
                {
                    registers[course] = users.Add(student);
                }
                
            }
        }
    }
}
