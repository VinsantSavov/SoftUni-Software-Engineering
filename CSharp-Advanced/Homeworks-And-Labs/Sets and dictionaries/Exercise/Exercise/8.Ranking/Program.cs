using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestPassword = new Dictionary<string, string>();
            var dict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end of contests")
                {
                    break;
                }

                string[] inputInfo = input.Split(":").ToArray();
                string contest = inputInfo[0];
                string password = inputInfo[1];

                if (!contestPassword.ContainsKey(contest))
                {
                    contestPassword.Add(contest, password);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end of submissions")
                {
                    break;
                }

                string[] inputInfo = input.Split("=>").ToArray();
                string contest = inputInfo[0];
                string password = inputInfo[1];
                string username = inputInfo[2];
                int points = int.Parse(inputInfo[3]);

                if (!dict.ContainsKey(username))
                {
                    if(contestPassword.ContainsKey(contest) && contestPassword[contest] == password)
                    {
                        dict.Add(username, new Dictionary<string, int>());
                        dict[username].Add(contest, points);
                    }
                }
                else if (dict.ContainsKey(username) && contestPassword.ContainsKey(contest) && contestPassword[contest] == password)
                {
                    if (!dict[username].ContainsKey(contest))
                    {
                        dict[username].Add(contest, points);
                    }
                    else if (dict[username][contest] < points)
                    {
                        dict[username][contest] = points;
                    }
                }

            }

            string bestCandidate = string.Empty;
            int totalPoints = 0;

            foreach (var kvp in dict)
            {
                int maxPoints = 0;

                foreach (var contestPoints in kvp.Value)
                {
                    maxPoints += contestPoints.Value;
                }
                if (maxPoints > totalPoints)
                {
                    bestCandidate = kvp.Key;
                    totalPoints = maxPoints;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {totalPoints} points.");
            Console.WriteLine("Ranking:");

            dict = dict.OrderBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in dict)
            {
                Console.WriteLine(kvp.Key);

                foreach (var contestPoints in kvp.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {contestPoints.Key} -> {contestPoints.Value}");
                }
            }
        }
    }
}
