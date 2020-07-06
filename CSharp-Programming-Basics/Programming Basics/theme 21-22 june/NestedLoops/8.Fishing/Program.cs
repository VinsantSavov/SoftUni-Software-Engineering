using System;

namespace _8.Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int fishQuata = int.Parse(Console.ReadLine());
            string fish = Console.ReadLine();
            int fishLen = 0;
            double allMoney = 0;
            double allMoney1 = 0;
            int counter = 0;

            while (fish != "Stop" && counter != fishQuata)
            {
                fishLen = fish.Length;
                int asci = 0;
                double moneyPerFish = 0;
                double kilos = double.Parse(Console.ReadLine());
                counter++;
                for (int i = 0; i < fishLen; i++)
                {
                    asci += fish[i];
                }
                moneyPerFish = asci / kilos;
                if (counter % 3 == 0)
                {
                    allMoney1 += moneyPerFish;
                }
                else
                {
                    allMoney1 -= moneyPerFish;
                }
                fish = Console.ReadLine();

            }
            if (counter >= fishQuata)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
            }
            if (allMoney1 > 0)
            {
                Console.WriteLine($"Lyubo's profit from {counter} fishes is {allMoney1:F2} leva.");
            }
            else if (allMoney1 <= 0)
            {
                allMoney = Math.Abs(allMoney1);
                Console.WriteLine($"Lyubo lost {allMoney:F2} leva today.");
            }
        }
    }
}