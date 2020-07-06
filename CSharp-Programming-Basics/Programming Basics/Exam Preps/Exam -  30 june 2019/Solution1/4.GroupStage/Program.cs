using System;

namespace _4.GroupStage
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int matchesPlayed = int.Parse(Console.ReadLine());
            int goals = 0;
            int allGoalsReceived = 0;
            int points = 0;

            for(int i = 0; i < matchesPlayed; i++)
            {
                int goalsInserted = int.Parse(Console.ReadLine());
                int goalsReceived = int.Parse(Console.ReadLine());

                goals += goalsInserted;
                allGoalsReceived += goalsReceived;

                if (goalsInserted > goalsReceived)
                {
                    points += 3;
                }
                else if(goalsInserted == goalsReceived)
                {
                    points += 1;
                }
                else
                {
                    points += 0;
                }

            }
            if (goals >= allGoalsReceived)
            {
                Console.WriteLine($"{team} has finished the group phase with {points} points.");
                Console.WriteLine("Goal difference: {0}.",goals-allGoalsReceived);
            }
            else
            {
                Console.WriteLine($"{team} has been eliminated from the group phase.");
                Console.WriteLine("Goal difference: {0}.",goals-allGoalsReceived);
            }

        }
    }
}
