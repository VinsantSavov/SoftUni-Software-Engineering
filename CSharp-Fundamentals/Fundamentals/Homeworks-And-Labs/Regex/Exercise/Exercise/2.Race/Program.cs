using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ").ToList();
            Regex  regexName = new Regex(@"[A-Za-z]");
            Regex regexNum = new Regex(@"[0-9]");
            Dictionary<string, int> people = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                string name = string.Empty;
                int km = 0;

                if(input == "end of race")
                {
                    break;
                }
                MatchCollection letters = regexName.Matches(input);
                MatchCollection numbers = regexNum.Matches(input);

                foreach (Match letter in letters)
                {
                    name += letter.Value;
                }

                if (participants.Contains(name))
                {
                    foreach (Match number in numbers)
                    {
                        km += int.Parse(number.Value);
                    }
                    if (!people.ContainsKey(name))
                    {
                        people.Add(name, 0);
                    }
                    people[name] += km;
                }
                

            }

            int count = 1;
            people = people.OrderByDescending(y => y.Value).ToDictionary(x=>x.Key, y=>y.Value);

            foreach (var item in people)
            {
                if(count == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                    count++;
                }
                else if(count == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                    count++;
                }
                else if(count == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                    count++;
                }
                else
                {
                    break;
                }
            }

        }
    }
}
