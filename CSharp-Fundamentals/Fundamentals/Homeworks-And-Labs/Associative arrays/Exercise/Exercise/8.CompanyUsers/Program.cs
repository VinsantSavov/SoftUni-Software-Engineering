using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(" -> ").ToArray();
                string company = tokens[0];
                string id = tokens[1];

                if(!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                    companies[company].Add(id);
                }
                else
                {
                    if (!companies[company].Contains(id))
                    {
                        companies[company].Add(id);
                    }
                }
                
            }

            foreach (var company in companies.OrderBy(c=>c.Key))
            {
                Console.WriteLine($"{company.Key}");
                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
