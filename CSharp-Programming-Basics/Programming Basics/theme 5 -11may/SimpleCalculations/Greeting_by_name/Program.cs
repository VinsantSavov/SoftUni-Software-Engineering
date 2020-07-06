using System;

namespace Greeting_by_name
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine("{0:F2}\n{1:F2}",area,perimeter);

        }
    }
}
