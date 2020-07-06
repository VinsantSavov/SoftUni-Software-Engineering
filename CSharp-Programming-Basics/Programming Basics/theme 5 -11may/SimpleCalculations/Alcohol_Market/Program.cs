using System;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskey_cost = double.Parse(Console.ReadLine());

            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakiq = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double rakiq_cost = whiskey_cost / 2;
            double wine_cost = rakiq_cost - rakiq_cost * 0.4;
            double beer_cost = rakiq_cost - rakiq_cost * 0.8;

            double moneyNeeded = (whiskey_cost*whiskey) + (rakiq_cost*rakiq) + (wine_cost*wine) + (beer_cost*beer);

            Console.WriteLine("{0:F2}",moneyNeeded);
        }
    }
}
