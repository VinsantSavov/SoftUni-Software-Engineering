using System;
using System.Text.RegularExpressions;

namespace _1.AnimalSanctuary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"^n:(?<name>[^;].+);t:(?<kind>[^;]+);c--(?<country>[A-Za-z ]+)$");
            int totalWeight = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);
                string name = String.Empty;
                string animal = String.Empty;
                string country = String.Empty;

                if (match.Success)
                {
                    string nameGroup = match.Groups["name"].Value;
                    string animalGroup = match.Groups["kind"].Value;
                    string countryGroup = match.Groups["country"].Value;

                    for (int j = 0; j < nameGroup.Length; j++)
                    {
                        if(nameGroup[j] >= 'a' && nameGroup[j] <= 'z' || nameGroup[j] >= 'A' && nameGroup[j] <= 'Z')
                        {
                            name += nameGroup[j];
                        }
                        else if(nameGroup[j] == ' ')
                        {
                            name += nameGroup[j];
                        }
                    }
                    for (int j = 0; j < animalGroup.Length; j++)
                    {
                        if (animalGroup[j] >= 'a' && animalGroup[j] <= 'z' || animalGroup[j] >= 'A' && animalGroup[j] <= 'Z')
                        {
                            animal += animalGroup[j];
                        }
                        else if (animalGroup[j] == ' ')
                        {
                            animal += animalGroup[j];
                        }
                    }
                    for (int j = 0; j < countryGroup.Length; j++)
                    {
                        if (countryGroup[j] >= 'a' && countryGroup[j] <= 'z' || countryGroup[j] >= 'A' && countryGroup[j] <= 'Z')
                        {
                            country += countryGroup[j];
                        }
                        else if (countryGroup[j] == ' ')
                        {
                            country += countryGroup[j];
                        }
                    }
                    for (int j = 0; j < nameGroup.Length; j++)
                    {
                        if(nameGroup[j] >= '1' && nameGroup[j] <= '9')
                        {
                            totalWeight += int.Parse(nameGroup[j].ToString());
                        }
                    }
                    for (int j = 0; j < animalGroup.Length; j++)
                    {
                        if (animalGroup[j] >= '1' && animalGroup[j] <= '9')
                        {
                            totalWeight += int.Parse(animalGroup[j].ToString());
                        }
                    }

                    Console.WriteLine($"{name} is a {animal} from {country}");
                }
            }
            Console.WriteLine($"Total weight of animals: {totalWeight}KG");
        }
    }
}
