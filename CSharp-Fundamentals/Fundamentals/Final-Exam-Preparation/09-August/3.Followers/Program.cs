using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> followersLikes = new Dictionary<string, int>();
            Dictionary<string, int> followersComments = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Log out")
                {
                    break;
                }

                string[] tokens = input.Split(": ");
                string command = tokens[0];

                if(command == "New follower")
                {
                    string username = tokens[1];
                    if (!followersLikes.ContainsKey(username))
                    {
                        followersLikes.Add(username, 0);
                        followersComments.Add(username, 0);
                    }
                }
                else if(command == "Like")
                {
                    string username = tokens[1];
                    int count = int.Parse(tokens[2]);

                    if (followersLikes.ContainsKey(username))
                    {
                        followersLikes[username] += count;
                    }
                    else
                    {
                        followersLikes.Add(username, count);
                        followersComments.Add(username, 0);
                    }
                }
                else if(command == "Comment")
                {
                    string username = tokens[1];

                    if (followersComments.ContainsKey(username))
                    {
                        followersComments[username]++;
                    }
                    else
                    {
                        followersComments.Add(username, 1);
                        followersLikes.Add(username, 0);
                    }
                }
                else if(command == "Blocked")
                {
                    string username = tokens[1];

                    if (!followersLikes.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        followersLikes.Remove(username);
                        followersComments.Remove(username);
                    }
                }
            }

            followersLikes = followersLikes.OrderByDescending(l => l.Value).ThenBy(n => n.Key).ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine($"{followersLikes.Count} followers");
            foreach (var kvp in followersLikes)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value + followersComments[kvp.Key]}");
            }
        }
    }
}
