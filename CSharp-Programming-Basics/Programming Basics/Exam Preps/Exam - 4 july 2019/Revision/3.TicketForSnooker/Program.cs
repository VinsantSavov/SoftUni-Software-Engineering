using System;

namespace _3.TicketForSnooker
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketNum = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());

            double cost = 0;

            if(stage =="Quarter final")
            {
                if(ticketType == "Standard")
                {
                    cost = ticketNum * 55.50;
                }
                else if (ticketType == "Premium")
                {
                    cost = ticketNum * 105.20;
                }
                else if (ticketType == "VIP")
                {
                    cost = ticketNum * 118.90;
                }
            }
            else if (stage == "Semi final")
            {
                if (ticketType == "Standard")
                {
                    cost = ticketNum * 75.88;
                }
                else if (ticketType == "Premium")
                {
                    cost = ticketNum * 125.22;
                }
                else if (ticketType == "VIP")
                {
                    cost = ticketNum * 300.40;
                }
            }
            else if (stage == "Final")
            {
                if (ticketType == "Standard")
                {
                    cost = ticketNum * 110.10;
                }
                else if (ticketType == "Premium")
                {
                    cost = ticketNum * 160.66;
                }
                else if (ticketType == "VIP")
                {
                    cost = ticketNum * 400;
                }
            }

            if (cost > 4000)
            {
                cost = cost - (cost * 0.25);
                Console.WriteLine("{0:F2}",cost);
                return;
            }
            if (cost > 2500)
            {
                cost = cost - (cost * 0.1);
                if (picture == 'Y')
                {
                    double total = cost + 40 * ticketNum;
                    Console.WriteLine("{0:F2}", total);
                }
                else
                {
                    Console.WriteLine("{0:F2}", cost);
                }
            }
            else
            {
                if (picture == 'Y')
                {
                    double total = cost + 40 * ticketNum;
                    Console.WriteLine("{0:F2}", total);
                }
                else
                {
                    Console.WriteLine("{0:F2}", cost);
                }
            }

            
        }
    }
}
