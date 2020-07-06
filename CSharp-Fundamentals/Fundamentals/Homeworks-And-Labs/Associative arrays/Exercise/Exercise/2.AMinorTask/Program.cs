using System;
using System.Collections.Generic;

namespace _2.AMinorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if(resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources.Add(resource, quantity);
                }
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
