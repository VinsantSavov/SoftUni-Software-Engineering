using System;
using System.Text.RegularExpressions;

namespace _1.MessageEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"(@|\*)(?<tag>[A-Z][a-z]{3,})(\1): \[(?<first>[A-Za-z])\]\|\[(?<second>[A-Za-z])\]\|\[(?<third>[A-Za-z])\]\|$"); 

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string tag = match.Groups["tag"].Value;
                    char first = char.Parse(match.Groups["first"].Value);
                    char second = char.Parse(match.Groups["second"].Value);
                    char third = char.Parse(match.Groups["third"].Value);

                    int a = first;
                    int b = second;
                    int c = third;

                    Console.WriteLine($"{tag}: {a} {b} {c}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
