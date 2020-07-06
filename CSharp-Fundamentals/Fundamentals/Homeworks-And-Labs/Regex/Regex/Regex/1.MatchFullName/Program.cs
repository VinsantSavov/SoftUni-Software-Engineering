using System;
using System.Text.RegularExpressions;

namespace _1.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            MatchCollection matched = Regex.Matches(input, regex);

            foreach (Match item in matched)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
