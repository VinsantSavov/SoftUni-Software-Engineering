using System;
using System.Text.RegularExpressions;

namespace _1.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] names = line.Split(", ",StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in names)
            {
                Regex regex = new Regex("^[A-Z][a-z]+ [A-Z][a-z]+$");
                bool hasMatch = regex.Match(name).Success;
                if (hasMatch)
                {
                    Console.Write(name+" ");
                }
            }
        }
    }
}
