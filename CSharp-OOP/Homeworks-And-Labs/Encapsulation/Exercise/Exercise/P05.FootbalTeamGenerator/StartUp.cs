using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FootbalTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {   
            List<Team> teams = new List<Team>();

            while (true)
            {
                try
                {
                    string input = Console.ReadLine();

                    if (input == "END")
                    {
                        break;
                    }

                    string[] info = input.Split(";");

                    if (info.Contains("Team"))
                    {
                        string teamName = info[1];

                        Team team = new Team(teamName);
                        teams.Add(team);

                    }
                    else if (info.Contains("Add"))
                    {
                        string teamName = info[1];
                        string playerName = info[2];
                        int endurance = int.Parse(info[3]);
                        int sprint = int.Parse(info[4]);
                        int dribble = int.Parse(info[5]);
                        int passing = int.Parse(info[6]);
                        int shooting = int.Parse(info[7]);

                        Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);
                        Player player = new Player(playerName, stats);
                        Team team = teams.FirstOrDefault(t => t.Name == teamName);

                        if (team != null)
                        {
                            team.AddPlayer(player);
                        }
                        else
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }

                    }
                    else if (info.Contains("Remove"))
                    {
                        string teamName = info[1];
                        string playerName = info[2];

                        Team team = teams.FirstOrDefault(t => t.Name == teamName);

                        if (team != null)
                        {
                            team.RemovePlayer(playerName);
                        }
                        else
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }

                    }
                    else if (info.Contains("Rating"))
                    {
                        string teamName = info[1];

                        Team team = teams.FirstOrDefault(t => t.Name == teamName);

                        if (team != null)
                        {
                            Console.WriteLine($"{teamName} - {team.Rating()}");
                        }
                        else
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                    }
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
