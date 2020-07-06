using System;

namespace _8.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string type = string.Empty;
            string biggestModel = string.Empty;
            double volumeMax = 0;

            for (int i = 0; i < n; i++)
            {
                type = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = height * radius * radius * 3.14;

                if (volume > volumeMax)
                {
                    volumeMax = volume;
                    biggestModel = type;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}
