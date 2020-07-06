using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.TeamWorkProjects
{
    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();
                string user = input[0];
                string teamName = input[1];

                if (!teams.Any())
                {
                    Team team = new Team() { Creator = user, Name = teamName };
                    Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                    teams.Add(team);
                }
                else
                {
                    if (teams.Any(t => t.Creator == user))
                    {
                        Console.WriteLine($"{user} cannot create another team!");
                    }

                    if (teams.Any(t => t.Name == teamName))
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                    }

                    if (teams.Any(t => t.Name != teamName) && teams.Any(t => t.Creator != user))
                    {
                        Team team = new Team() { Creator = user, Name = teamName };
                        Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                        teams.Add(team);
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                Team team = new Team();

                if(input == "end of assignment")
                {
                    break;
                }

                string[] tokens = input.Split(new [] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string member = tokens[0];
                string teamName = tokens[1];

                if(teams.Any(t => t.Name != teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                if (teams.Any(t => t.Members.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else
                {
                    foreach (var teamN in teams)
                    {
                        if(teamN.Name == teamName)
                        {
                            teamN.Members.Add(member);
                        }
                    }

                }

            }

            teams = teams.OrderByDescending(x => x.Members).ThenBy(n => n.Name).ToList();

            foreach (var team in teams)
            {
                Console.WriteLine($"{team.Name}:");
                Console.WriteLine($"- {team.Creator}");
                Console.WriteLine(string.Join(Environment.NewLine, $"-- {team.Members}"));
            }

            Console.WriteLine("Teams to disband: ");
            foreach (var team in teams)
            {
                if(team.Members.Count == 0)
                {
                    Console.WriteLine(team.Name);
                }
            }
        }
    }
}
