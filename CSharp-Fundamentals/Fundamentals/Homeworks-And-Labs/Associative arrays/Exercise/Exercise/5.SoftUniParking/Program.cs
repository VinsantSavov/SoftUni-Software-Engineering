using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if(input[0] == "register")
                {
                    string user = input[1];
                    string plateNum = input[2];

                    if (!users.ContainsKey(user))
                    {
                        users.Add(user, plateNum);
                        Console.WriteLine($"{user} registered {plateNum} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNum}");
                    }
                }
                else if(input[0] == "unregister")
                {
                    string user = input[1];

                    if (!users.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        users.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }

            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
