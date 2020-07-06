using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMeters = int.Parse(Console.ReadLine());
            double cost = squareMeters * 7.61;
            double discount = cost * 18 / 100;
            double wholeCost = cost - discount;

            Console.WriteLine("The final price is: {0:F2} lv.",wholeCost);
            Console.WriteLine("The discount is: {0:F2} lv.", discount);


        }
    }
}
