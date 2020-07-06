using System;

namespace Bithday
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine())*0.01;
            int area = lenght * width * height;
            double liters = area * 0.001;
            double freespace = liters - liters * percent;

            Console.WriteLine("{0:F3}", freespace);
        }
    }
}
