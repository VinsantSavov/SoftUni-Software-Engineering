using System;
using System.Text.RegularExpressions;

namespace _3.SoftuniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end of shift")
                {
                    break;
                }

                Regex regex = new Regex(@"%(?<customer>[A-Z][a-z]+)%[^|$%.0-9]*<(?<product>\w+)>[^|$%.0-9]*\|(?<quantity>\d+)\|[^|$%.0-9]*(?<price>\d+\.?\d*)\$");
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    Console.WriteLine($"{customer}: {product} - {price*quantity:F2}");
                    totalMoney += price * quantity;
                }
            }

            Console.WriteLine($"Total income: {totalMoney:F2}");
        }
    }
}
