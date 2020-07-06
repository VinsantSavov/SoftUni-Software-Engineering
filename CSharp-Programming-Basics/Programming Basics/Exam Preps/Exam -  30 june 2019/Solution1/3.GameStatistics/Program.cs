using System;

namespace _3.GameStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            if (minutes == 0)
            {
                Console.WriteLine("Match has just began!");
            }
            else if(minutes < 45)
            {
                Console.WriteLine("First half time.");
            }
            else if (minutes >= 45)
            {
                Console.WriteLine("Second half time.");
            }

            if(minutes > 1 && minutes <= 10)
            {
                Console.WriteLine("{0} missed a penalty.",name);
                if (minutes % 2 == 0)
                {
                    Console.WriteLine("{0} was injured after the penalty.",name);
                }
            }
            else if (minutes > 10 && minutes <= 25)
            {
                Console.WriteLine("{0} received yellow card.",name);
                if(minutes %2 != 0)
                {
                    Console.WriteLine("{0} got another yellow card.",name);
                }
            }
            else if (minutes > 35 && minutes < 45)
            {
                Console.WriteLine("{0} SCORED A GOAL !!!", name);
            }
            else if (minutes > 45 && minutes <= 55)
            {
                Console.WriteLine("{0} got a freekick.", name);
                if (minutes % 2 == 0)
                {
                    Console.WriteLine("{0} missed the freekick.", name);
                }
            }
            else if (minutes > 55 && minutes <= 80)
            {
                Console.WriteLine("{0} missed a shot from corner.", name);
                if (minutes % 2 != 0)
                {
                    Console.WriteLine("{0} has been changed with another player.", name);
                }
            }
            else if (minutes > 80 && minutes <= 90)
            {
                Console.WriteLine("{0} SCORED A GOAL FROM PENALTY !!!", name);
                
            }
        }
    }
}
