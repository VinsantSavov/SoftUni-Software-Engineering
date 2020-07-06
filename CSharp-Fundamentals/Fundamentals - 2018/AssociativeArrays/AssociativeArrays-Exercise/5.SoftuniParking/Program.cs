using System;
using System.Linq;
using System.Collections.Generic;

namespace _5.SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> validations = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> user = Console.ReadLine().Split().ToList();

                string type = user[0];
                string username = user[1];

                if(type == "register")
                {
                    if (!validations.ContainsKey(username))
                    {
                        validations[username] = user[2];
                        Console.WriteLine($"{username} registered {user[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {validations[username]}");
                    }
                }
                else
                {
                    if (!validations.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        validations.Remove(username);
                    }
                }
            }
            foreach (var kvp in validations)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
