using System;

namespace _3.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());
            double courses = Math.Ceiling(people / capacity);

            Console.WriteLine(courses);
        }
    }
}
