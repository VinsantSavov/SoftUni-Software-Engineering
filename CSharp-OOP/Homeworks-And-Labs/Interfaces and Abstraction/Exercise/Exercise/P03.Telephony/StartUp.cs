using System;
using System.Linq;

namespace P03.Telephony.Models
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] sites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            StationaryPhone stationary = new StationaryPhone();
            Smartphone smartphone = new Smartphone();

            foreach (var num in numbers)
            {
                if(num.Length == 7)
                {
                    Console.WriteLine(stationary.Call(num));
                }
                else
                {
                    Console.WriteLine(smartphone.Call(num));
                }
            }

            foreach (var site in sites)
            {
                Console.WriteLine(smartphone.Browse(site));
            }
        }
    }
}
