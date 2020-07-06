using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex starRegex = new Regex("[starSTAR]");
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string decryptedMessage = string.Empty;

                MatchCollection stars = starRegex.Matches(input);
                int count = stars.Count;

                for (int j = 0; j < input.Length; j++)
                {
                    decryptedMessage += (char)(input[j] - count);
                }
                Regex regex = new Regex(@"^[^@\-!:>]*@(?<planetName>[A-Za-z]+)[^@\-!:>]*:[^@\-!:>0-9]*(?<population>\d+)[^@\-!:>]*![^@\-!:>]*(?<attackType>[AD])[^@\-!:>]*![^@\-!:>]*->[^@\-!:>0-9]*(?<soldierCount>\d+)[^@\-!:>]*$");

                Match decrypted = regex.Match(decryptedMessage);

                if (decrypted.Success)
                {
                    string planetName = decrypted.Groups["planetName"].Value;
                    char type = char.Parse(decrypted.Groups["attackType"].Value);

                    if (type == 'A')
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }

            }
            
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
