using System;

namespace _7.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tank = 0;
            int space = 255;

            for(int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters <= space)
                {
                    tank += liters;
                    space -= liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(tank);
        }
    }
}
