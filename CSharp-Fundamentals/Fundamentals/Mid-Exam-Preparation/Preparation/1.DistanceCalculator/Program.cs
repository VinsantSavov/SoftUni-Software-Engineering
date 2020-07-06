using System;

namespace _1.DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsMade = int.Parse(Console.ReadLine());
            double stepInCent = double.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            distance = distance * 100;
            double distanceTravelled = 0;

            for (int i = 1; i <= stepsMade; i++)
            {
                
                if (i % 5 == 0)
                {
                    distanceTravelled += stepInCent * 0.7;
                }
                else
                {
                    distanceTravelled += stepInCent;
                }
            }

            double percentage = distanceTravelled / distance * 100;

            Console.WriteLine($"You travelled {percentage:F2}% of the distance!");

        }
    }
}
