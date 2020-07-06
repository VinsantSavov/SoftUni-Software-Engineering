using System;

namespace _9.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalAmount = 0;

            while (startingYield >= 100)
            {
                totalAmount += startingYield;
                startingYield -= 10;
                days++;

                if(totalAmount < 26)
                {
                    break;
                }
                else
                {
                    totalAmount -= 26;
                }
            }

            if(totalAmount >= 26)
            {
                totalAmount -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalAmount);
        }
    }
}
