using System;
using System.Text.RegularExpressions;

namespace _6.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex email = new Regex(@" [A-Za-z0-9]+[\-\._]?[A-Za-z0-9]*@[A-Za-z]+\-?[A-Za-z]*\.[A-Za-z]+\-?[A-Za-z]*\.?[A-Za-z]+");

            string input = Console.ReadLine();

            MatchCollection matches = email.Matches(input);
            if (matches.Count>0)
            {
                foreach (Match item in matches)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
