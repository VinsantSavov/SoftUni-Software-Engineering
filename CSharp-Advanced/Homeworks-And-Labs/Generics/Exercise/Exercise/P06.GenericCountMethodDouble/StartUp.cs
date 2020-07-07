using System;

namespace P06.GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Elements<double> elements = new Elements<double>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                elements.Add(input);
            }

            double element = double.Parse(Console.ReadLine());

            int count = elements.Comparator(element);

            Console.WriteLine(count);
        }
    }
}
