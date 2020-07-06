using System;

namespace _9.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int diffDays = startingYield;
            int amount = 0;
            int days = 0;

            while (diffDays >= 100)
            {
                amount += diffDays;
                if (amount > 26)
                {
                    amount -= 26;
                }
                else
                {
                    break;
                }
                diffDays -= 10;
                days++;
            }
            if (amount > 26)
            {
                amount -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(amount);
        }
    }
}
