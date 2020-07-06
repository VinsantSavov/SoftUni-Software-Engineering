using System;

namespace _3.GiftboxCoverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideSize = double.Parse(Console.ReadLine());
            int sheetsOfPaper = int.Parse(Console.ReadLine());
            double areaOfPaper = double.Parse(Console.ReadLine());

            double boxArea = sideSize * sideSize * 6;
            double areaOfAllSheets = 0;
            double percentageCovered = 0;

            for (int i = 1; i <= sheetsOfPaper; i++)
            {
                if(i % 3 == 0)
                {
                    areaOfAllSheets += areaOfPaper * 0.25;
                }
                else
                {
                    areaOfAllSheets += areaOfPaper;
                }
            }

            percentageCovered = (areaOfAllSheets / boxArea) * 100;

            Console.WriteLine($"You can cover {percentageCovered:F2}% of the box.");

        }
    }
}
