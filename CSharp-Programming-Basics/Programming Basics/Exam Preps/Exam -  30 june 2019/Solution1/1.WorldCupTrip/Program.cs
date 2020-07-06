using System;

namespace _1.WorldCupTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double goingTicket = double.Parse(Console.ReadLine());
            double comingTicket = double.Parse(Console.ReadLine());
            double matchCost = double.Parse(Console.ReadLine());
            int numMatches = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double totalSum = 0;
            double discountForOne = (goingTicket + comingTicket) * discount/100;
            double moneyForTickets = goingTicket + comingTicket - discountForOne;
            totalSum = moneyForTickets + matchCost * numMatches;
            double sumForFive = totalSum * 6;

            Console.WriteLine("Total sum: {0:F2} lv.",sumForFive);
            Console.WriteLine("Each friend has to pay {0:F2} lv.",totalSum);
          
        }
    }
}
