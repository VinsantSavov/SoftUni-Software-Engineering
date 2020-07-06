using System;

namespace _6.Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            int sum = 0;

            while(destination != "End")
            {
                int minimalBudget = int.Parse(Console.ReadLine());
                sum = 0;
                while (true)
                {
                    int money = int.Parse(Console.ReadLine());
                    sum += money;
                    if (sum >= minimalBudget)
                    {
                        Console.WriteLine("Going to {0}!", destination);
                        break;
                    }
                }

                destination = Console.ReadLine();
            }

        }
    }
}
