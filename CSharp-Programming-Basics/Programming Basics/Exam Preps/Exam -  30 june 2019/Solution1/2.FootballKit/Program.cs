using System;

namespace _2.FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double shirtCost = double.Parse(Console.ReadLine());
            double moneyForTheBall = double.Parse(Console.ReadLine());

            double shortsCost = shirtCost * 75 / 100;
            double socksCost = shortsCost * 20 / 100;
            double buttonsCost = 2 * (shortsCost + shirtCost);
            double totalSum = (shirtCost + shortsCost + socksCost + buttonsCost)*85/100;
            
            if(totalSum >= moneyForTheBall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine("His sum is {0:F2} lv.",totalSum);
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine("He needs {0:F2} lv. more.", moneyForTheBall- totalSum);
            }
        }
    }
}
