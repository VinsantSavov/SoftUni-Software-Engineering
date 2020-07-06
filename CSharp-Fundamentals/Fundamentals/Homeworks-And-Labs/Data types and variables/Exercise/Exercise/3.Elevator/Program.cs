using System;

namespace _3.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling(numOfPeople * 1.0 / capacity);

            Console.WriteLine(courses);
        }
    }
}
