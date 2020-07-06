using System;
using System.Text.RegularExpressions;

namespace _1.TheIsleOfMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"([#%$*&])(?<name>[A-Za-z]+)\1=(?<lenght>\d+)!!(?<hashcode>.+)$");

            while (true)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    int lenght = int.Parse(match.Groups["lenght"].Value);
                    string hashCode = match.Groups["hashcode"].Value;
                    string decrypted = string.Empty;

                    if(hashCode.Length == lenght)
                    {
                        for (int i = 0; i < hashCode.Length; i++)
                        {
                            decrypted += (char)(hashCode[i] + lenght);
                        }

                        Console.WriteLine($"Coordinates found! {name} -> {decrypted}");
                        break;
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
