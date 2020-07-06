using System;

namespace _8.CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchNumber = int.Parse(Console.ReadLine());
           

            for(int i = 0; i < batchNumber; i++)
            {
                bool hasEggs = false;
                bool hasFlour = false;
                bool hasSugar = false;
                bool hasAll = false;
                string product = Console.ReadLine();

                while (!(product == "Bake!" && hasAll))
                {
                    if (product == "flour")
                    {
                        hasFlour = true;
                    }
                    else if(product == "eggs")
                    {
                        hasEggs = true;
                    }
                    else if (product == "sugar")
                    {
                        hasSugar = true;
                    }
                    if(hasSugar && hasEggs && hasFlour)
                    {
                        hasAll = true;
                    }
                    if(product == "Bake!")
                    {
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    }
                    product = Console.ReadLine();
                }
                if(hasFlour && hasEggs && hasSugar)
                {
                    Console.WriteLine("Baking batch number {0}...", i + 1);
                }
            }

        }
    }
}
