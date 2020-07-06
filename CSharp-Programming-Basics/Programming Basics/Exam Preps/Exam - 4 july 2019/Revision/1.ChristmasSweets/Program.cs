using System;

namespace _1.ChristmasSweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double baklavaPrice = double.Parse(Console.ReadLine());
            double muffinPrice = double.Parse(Console.ReadLine());
            double cakeKilos = double.Parse(Console.ReadLine());
            double sweetsKilos = double.Parse(Console.ReadLine());
            int bisquitsKilos = int.Parse(Console.ReadLine());

            double cakePrice = baklavaPrice + (baklavaPrice * 60 / 100);
            double sweetsPrice = muffinPrice + (muffinPrice * 80 / 100);

            double totalCakePrice = cakePrice * cakeKilos;
            double totalSweetsPrice = sweetsPrice * sweetsKilos;
            double totalBisquitsPrice = bisquitsKilos * 7.5;

            double total = totalCakePrice + totalSweetsPrice + totalBisquitsPrice;

            Console.WriteLine("{0:F2}",total);
        }
    }
}
