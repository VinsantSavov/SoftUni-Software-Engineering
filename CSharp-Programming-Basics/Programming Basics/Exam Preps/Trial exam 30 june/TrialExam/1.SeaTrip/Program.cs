using System;

namespace _1.SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodMoney = double.Parse(Console.ReadLine());
            double souvenirMoney = double.Parse(Console.ReadLine());
            double hotelMoney = double.Parse(Console.ReadLine());

            double totalMoney = 0;

            double firstday = hotelMoney-hotelMoney * 0.1 + foodMoney + souvenirMoney;
            double secondday =  hotelMoney-hotelMoney * 0.15 + foodMoney + souvenirMoney;
            double thirdday = hotelMoney-hotelMoney * 0.2 + foodMoney + souvenirMoney;

            totalMoney = firstday + secondday + thirdday + 54.39;

            Console.WriteLine("Money needed: {0:F2}",totalMoney);
        }
    }
}
