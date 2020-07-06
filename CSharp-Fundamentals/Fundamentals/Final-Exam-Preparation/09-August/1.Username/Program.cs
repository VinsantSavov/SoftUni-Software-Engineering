using System;
using System.Linq;

namespace _1.Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Sign up")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0];

                if(command == "Case")
                {
                    string type = tokens[1];

                    if(type == "lower")
                    {
                        username = username.ToLower();
                        Console.WriteLine(username);
                    }
                    else
                    {
                        username = username.ToUpper();
                        Console.WriteLine(username);
                    }
                }
                else if(command == "Reverse")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if(startIndex >= 0 && startIndex < endIndex && endIndex > startIndex && endIndex < username.Length)
                    {
                        string subString = username.Substring(startIndex, endIndex - startIndex+1);
                        char[] subs = subString.ToCharArray();
                        Array.Reverse(subs);
                        Console.WriteLine(subs);
                    }
                }
                else if(command == "Cut")
                {
                    string subString = tokens[1];

                    if (username.Contains(subString))
                    {
                        int index = username.IndexOf(subString);
                        username = username.Remove(index, subString.Length);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {subString}.");
                    }
                }
                else if(command == "Replace")
                {
                    char ch = char.Parse(tokens[1]);
                    username = username.Replace(ch, '*');
                    Console.WriteLine(username);
                }
                else if(command == "Check")
                {
                    char ch = char.Parse(tokens[1]);

                    if (username.Contains(ch))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {ch}.");
                    }
                }
            }
        }
    }
}
