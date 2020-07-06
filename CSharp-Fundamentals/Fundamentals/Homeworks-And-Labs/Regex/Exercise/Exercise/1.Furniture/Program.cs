using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@">>(?<furniture>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)");
            double totalmoney = 0;

            Console.WriteLine("Bought furniture: ");
            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Purchase")
                {
                    break;
                }

                Match match = regex.Match(input);

                if(match.Success)
                {
                    string furniture = match.Groups["furniture"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    Console.WriteLine(furniture);

                    totalmoney += price * quantity;
                }
            }
       
            Console.WriteLine($"Total money spend: {totalmoney:F2}");
        }
    }
}
