using System;

namespace _2.BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int StartingPoints = int.Parse(Console.ReadLine());
            double bonusPoints=0;

            if (StartingPoints <= 100)
            {
                bonusPoints += 5;
            }
            else if(StartingPoints>100&&StartingPoints<=1000)
            {
                bonusPoints = StartingPoints * 0.2;
            }
            else if(StartingPoints > 1000)
            {
                bonusPoints = StartingPoints * 0.1;
            }
            if (StartingPoints % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (StartingPoints%10==5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine("{0}", bonusPoints);
            Console.WriteLine("{0}", StartingPoints + bonusPoints);
        }
    }
}
