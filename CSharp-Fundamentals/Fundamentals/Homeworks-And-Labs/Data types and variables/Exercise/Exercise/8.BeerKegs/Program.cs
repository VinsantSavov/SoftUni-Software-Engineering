using System;

namespace _8.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestVolume = 0;
            string biggestKeg = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int heigth = int.Parse(Console.ReadLine());

                double volume = 3.14 * radius * radius * heigth;

                if(volume >= biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
