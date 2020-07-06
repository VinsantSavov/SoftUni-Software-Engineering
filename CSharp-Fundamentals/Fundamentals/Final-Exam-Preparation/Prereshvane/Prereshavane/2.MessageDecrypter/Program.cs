using System;
using System.Text.RegularExpressions;

namespace _2.MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"^([$%])(?<tag>[A-Z][a-z]{2,})\1: \[(?<first>\d+)\]\|\[(?<second>\d+)\]\|\[(?<third>\d+)\]\|$"); 

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);
                string decrypted = string.Empty;

                if (match.Success)
                {
                    string tag = match.Groups["tag"].Value;
                    int first = int.Parse(match.Groups["first"].Value);
                    int second = int.Parse(match.Groups["second"].Value);
                    int third = int.Parse(match.Groups["third"].Value);
                    decrypted += (char)first;
                    decrypted += (char)second;
                    decrypted += (char)third;

                    Console.WriteLine($"{tag}: {decrypted}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
