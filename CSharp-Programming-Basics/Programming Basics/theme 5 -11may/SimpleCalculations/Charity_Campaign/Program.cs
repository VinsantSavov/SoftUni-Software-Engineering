using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            //double First_day = confectioners * (cakes*45) * (waffles*5.80) * (pancakes*3.20);
            double first = cakes * 45;
            double firstW = waffles * 5.80;
            double firstP = pancakes * 3.20;
            double all = confectioners * (first + firstW + firstP);
            double all_days = all * days;

            double expenses = all_days * 1 / 8;

            double money = all_days - expenses;

            Console.WriteLine("{0:F2}", money);
        }
    }
}
