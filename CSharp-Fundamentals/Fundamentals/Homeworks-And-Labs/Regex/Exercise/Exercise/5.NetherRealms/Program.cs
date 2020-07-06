using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> demons = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            SortedDictionary<string, int> nameHealth = new SortedDictionary<string, int>();
            SortedDictionary<string, double> nameDamage = new SortedDictionary<string, double>();

            Regex healthRegex = new Regex(@"[^0-9+\-*\/\.]");
            Regex damageRegex = new Regex(@"[0-9+\-\.]+");

            foreach (var demon in demons)
            {
                int health = 0;
                double damage = 0;
                MatchCollection matches = healthRegex.Matches(demon);
                MatchCollection damMatches = damageRegex.Matches(demon);


                foreach (Match item in matches)
                {
                    health += char.Parse(item.ToString());
                }

                foreach (Match match in damMatches)
                {
                    string num = match.ToString();
                    if (num.Contains('-'))
                    {
                        num = num.Remove(0, 1);
                        damage -= double.Parse(num);
                    }
                    else
                    {
                        damage += double.Parse(num);
                    }
                }
                for (int i = 0; i < demon.Length; i++)
                {
                    if (demon[i] == '/')
                    {
                        damage /= 2;
                    }
                    else if(demon[i] == '*')
                    {
                        damage *= 2;
                    }
                }
                
                nameHealth.Add(demon, health);
                nameDamage.Add(demon, damage);

            }

            foreach (var kvp in nameHealth)
            {
                foreach (var item in nameDamage)
                {
                    if (kvp.Key == item.Key)
                    {
                        Console.WriteLine($"{kvp.Key} - {kvp.Value} health, {item.Value:F2} damage");
                    }
                }
            }
        }
    }
}
