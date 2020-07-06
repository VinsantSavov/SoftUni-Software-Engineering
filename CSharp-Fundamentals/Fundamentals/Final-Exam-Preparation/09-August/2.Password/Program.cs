using System;
using System.Text.RegularExpressions;

namespace _2.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"^([\S]{1,})>(?<numbers>[0-9]{3})\|(?<lowerCase>[a-z]{3})\|(?<upperCase>[A-Z]{3})\|(?<symbols>[^<>\s]{3})<\1$"); 

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string encryptedPassword = String.Empty;
                Match match = regex.Match(input);

                if (match.Success)
                {

                    encryptedPassword += match.Groups["numbers"].Value;
                    encryptedPassword += match.Groups["lowerCase"].Value;
                    encryptedPassword += match.Groups["upperCase"].Value;
                    encryptedPassword += match.Groups["symbols"].Value;
 
                    Console.WriteLine($"Password: {encryptedPassword}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
