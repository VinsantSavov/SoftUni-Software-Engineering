using System;

namespace _5.GameInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int playedMatches = int.Parse(Console.ReadLine());
            int allMatches = 0;
            double averageMinutes = 0;
            int numExtensions = 0;
            int numPenalties = 0;

            for(int i = 0; i < playedMatches; i++)
            {
                int continuance = int.Parse(Console.ReadLine());

                if (continuance > 90 && continuance <=120)
                {
                    numExtensions++;
                }
                if (continuance > 120)
                {
                    numPenalties++;
                }
                allMatches += continuance;
            }
            averageMinutes = allMatches / (double)playedMatches;

            Console.WriteLine($"{team} has played {allMatches} minutes. Average minutes per game: {averageMinutes:F2}");
            Console.WriteLine($"Games with penalties: {numPenalties}");
            Console.WriteLine($"Games with additional time: {numExtensions}");
        }
    }
}
