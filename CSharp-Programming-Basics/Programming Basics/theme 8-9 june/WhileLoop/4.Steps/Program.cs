using System;

namespace _4.Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isReached = false;
            int allSteps = 0;
            int stepsToHome = 0;

            while(input != "Going home")
            {
                int steps = int.Parse(input);
                allSteps += steps;
                if(allSteps >= 10000)
                {
                    isReached = true;
                    break;
                }
                input = Console.ReadLine();
            }

            if (isReached)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else if(input == "Going home")
            {
                stepsToHome = int.Parse(Console.ReadLine());
                allSteps += stepsToHome;
                if (allSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
                else
                {
                    Console.WriteLine("{0} more steps to reach goal.", 10000 - allSteps);
                }
               
            }
        }
    }
}
