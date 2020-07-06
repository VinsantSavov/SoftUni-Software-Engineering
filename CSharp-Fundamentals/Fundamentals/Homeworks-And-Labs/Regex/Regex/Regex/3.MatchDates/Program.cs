using System;
using System.Text.RegularExpressions;

namespace _3.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string regex = @"\b(?<day>[0-9]{2})(.|\/|-)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            MatchCollection dates = Regex.Matches(input, regex);

            foreach (Match item in dates)
            {
                string day = item.Groups["day"].Value;
                string month = item.Groups["month"].Value;
                string year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
