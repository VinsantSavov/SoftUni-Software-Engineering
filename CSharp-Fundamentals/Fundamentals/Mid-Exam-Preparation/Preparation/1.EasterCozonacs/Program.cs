using System;

namespace _1.EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggsPrice = flourPrice * 0.75;
            double milkPrice = (flourPrice + flourPrice * 0.25) / 4;
            double oneCozonacPrice = flourPrice + eggsPrice + milkPrice;
            double cozonacsPrice = 0;

            int cozonacsCount = 0;
            int eggsCount = 0;

            while(cozonacsPrice < budget-oneCozonacPrice)
            {
                cozonacsCount++;
                cozonacsPrice += oneCozonacPrice;
                eggsCount += 3;

                if (cozonacsCount % 3 == 0)
                {
                    eggsCount -= cozonacsCount - 2;
                }
            }
            double leftMoney = budget - cozonacsPrice;
            Console.WriteLine($"You made {cozonacsCount} cozonacs! Now you have {eggsCount} eggs and {leftMoney:F2}BGN left.");
        }
    }
}
