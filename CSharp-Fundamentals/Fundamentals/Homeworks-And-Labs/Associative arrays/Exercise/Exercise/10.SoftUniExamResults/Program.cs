using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "exam finished")
                {
                    break;
                }

                string[] tokens = input.Split("-").ToArray();
                string user = tokens[0];

                if(tokens[1] == "banned")
                {
                    users.Remove(user);
                }
                else
                {
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (!users.ContainsKey(user))
                    {
                        users.Add(user, points);
                    }
                    else
                    {
                        if (points > users[user])
                        {
                            users[user] = points;
                        }
                    }
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 1);
                    }
                    else
                    {
                        submissions[language]++;
                    }
                }
                
            }
            Console.WriteLine("Results:");
            foreach (var user in users.OrderByDescending(p=>p.Value).ThenBy(n=>n.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var language in submissions.OrderByDescending(c=>c.Value).ThenBy(n=>n.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
