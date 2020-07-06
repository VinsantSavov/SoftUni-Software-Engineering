using System;
using System.Text.RegularExpressions;

namespace _2.MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(@"^(\$|%)(?<tag>[A-Z][a-z]{2,})\1: \[(?<first>[0-9]+)\]\|\[(?<second>[0-9]+)\]\|\[(?<third>[0-9]+)\]\|$");
                Match match = regex.Match(input);
                string decryptedMessage = String.Empty;

                if (!match.Success)
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    int f = int.Parse(match.Groups["first"].Value);
                    int s = int.Parse(match.Groups["second"].Value);
                    int t = int.Parse(match.Groups["third"].Value);
                    string tag = match.Groups["tag"].Value;


                    decryptedMessage += (char)f;
                    decryptedMessage += (char)s;
                    decryptedMessage += (char)t;

                    Console.WriteLine($"{tag}: {decryptedMessage}");
                }
            }
        }
    }
}
