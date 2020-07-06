using System;

namespace _1.TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTheAdventure = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayOnePerson = double.Parse(Console.ReadLine());
            double foodPerDayOnePerson = double.Parse(Console.ReadLine());

            double waterSupply = waterPerDayOnePerson * playersCount * daysOfTheAdventure;
            double foodSupply = foodPerDayOnePerson * playersCount * daysOfTheAdventure;
            bool areReady = true;

            for (int i = 1; i <= daysOfTheAdventure; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;

                if (groupEnergy <= 0)
                {
                    areReady = false;
                    break;
                }
                if (i % 2 == 0)
                {
                    groupEnergy += groupEnergy * 0.05;
                    waterSupply -= waterSupply * 0.3;
                }
                if (i % 3 == 0)
                {
                    foodSupply -= foodSupply / playersCount;
                    groupEnergy += groupEnergy * 0.1;
                }

            }

            if (areReady)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {foodSupply:F2} food and {waterSupply:F2} water.");
            }
        }
    }
}
