using System;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double war_side = double.Parse(Console.ReadLine());
            double area = lenght * width;
            double bench_area = area / 10;
            double war_area = war_side * war_side;

            double freeSpace = area - bench_area - war_area;
            double dancers_num = freeSpace / 0.704 ; 

            Console.WriteLine(Math.Floor(dancers_num));
        }
    }
}
