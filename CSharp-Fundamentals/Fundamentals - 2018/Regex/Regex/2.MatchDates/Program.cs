using System;
using System.Text.RegularExpressions;

namespace _2.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dates = Console.ReadLine();

            var regex =@"\b(?<day>[0-9][0-9])(?<separator>[-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>[0-9]{4})\b";

            var date = Regex.Matches(dates, regex);

            foreach (Match kvp in dates)
            {
                var day = kvp.Groups["day"].Value;
                var month = kvp.Groups["month"].Value;
                var year = kvp.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
