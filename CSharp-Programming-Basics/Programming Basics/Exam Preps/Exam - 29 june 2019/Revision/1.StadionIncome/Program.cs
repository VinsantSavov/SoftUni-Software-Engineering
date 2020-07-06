using System;

namespace _1.StadionIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectors = int.Parse(Console.ReadLine());
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double ticket = double.Parse(Console.ReadLine());

            double sectorIncome = stadiumCapacity * ticket / sectors;
            double totalIncome = stadiumCapacity * ticket;
            double moneyForCharity = (totalIncome - 0.75 * sectorIncome) / 8;

            Console.WriteLine("Total income - {0:F2} BGN",totalIncome);
            Console.WriteLine("Money for charity - {0:F2} BGN",moneyForCharity);
        }
    }
}
