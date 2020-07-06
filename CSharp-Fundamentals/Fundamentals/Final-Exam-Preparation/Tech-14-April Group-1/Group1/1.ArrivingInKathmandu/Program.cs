using System;
using System.Text.RegularExpressions;

namespace _1.ArrivingInKathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^(?<nameOfThePeak>[A-Za-z0-9!@#$?]+)=(?<lenght>\d+)<<(?<geohash>.+)$");

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Last note")
                {
                    break;
                }

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string nameOfThePeak = match.Groups["nameOfThePeak"].Value;
                    int len = int.Parse(match.Groups["lenght"].Value);
                    string geohash = match.Groups["geohash"].Value;
                    string decrypted = string.Empty;

                    if(len == geohash.Length)
                    {
                        for (int i = 0; i < nameOfThePeak.Length; i++)
                        {
                            if(nameOfThePeak[i] >= 'a' && nameOfThePeak[i] <= 'z' || nameOfThePeak[i] >= 'A' && nameOfThePeak[i] <= 'Z')
                            {
                                decrypted += nameOfThePeak[i];
                            }
                            else if(nameOfThePeak[i] >= '1' && nameOfThePeak[i] <= '9')
                            {
                                decrypted += nameOfThePeak[i];
                            }
                        }
                        Console.WriteLine($"Coordinates found! {decrypted} -> {geohash}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
