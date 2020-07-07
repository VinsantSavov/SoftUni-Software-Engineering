using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] chemicalLiquids = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] physicalItems = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> liquids = new Queue<int>(chemicalLiquids);
            Stack<int> items = new Stack<int>(physicalItems);

            Dictionary<string, int> advancedMaterials = new Dictionary<string, int>();

            while(liquids.Count > 0 && items.Count > 0)
            {
                int liquid = liquids.Peek();
                int item = items.Peek();
                int sum = liquid + item;

                if(sum == 25)
                {
                    liquids.Dequeue();
                    items.Pop();

                    if (!advancedMaterials.ContainsKey("Glass"))
                    {
                        advancedMaterials.Add("Glass", 0);
                    }
                    advancedMaterials["Glass"]++;
                }
                else if(sum == 50)
                {
                    liquids.Dequeue();
                    items.Pop();

                    if (!advancedMaterials.ContainsKey("Aluminium"))
                    {
                        advancedMaterials.Add("Aluminium", 0);
                    }
                    advancedMaterials["Aluminium"]++;
                }
                else if(sum == 75)
                {
                    liquids.Dequeue();
                    items.Pop();

                    if (!advancedMaterials.ContainsKey("Lithium"))
                    {
                        advancedMaterials.Add("Lithium", 0);
                    }
                    advancedMaterials["Lithium"]++;
                }
                else if(sum == 100)
                {
                    liquids.Dequeue();
                    items.Pop();

                    if (!advancedMaterials.ContainsKey("Carbon fiber"))
                    {
                        advancedMaterials.Add("Carbon fiber", 0);
                    }
                    advancedMaterials["Carbon fiber"]++;
                }
                else
                {
                    liquids.Dequeue();
                    items.Pop();
                    items.Push(item + 3);
                }
            }

            if(advancedMaterials.ContainsKey("Glass") && advancedMaterials.ContainsKey("Aluminium") &&
                advancedMaterials.ContainsKey("Lithium") && advancedMaterials.ContainsKey("Carbon fiber"))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");

                if (!advancedMaterials.ContainsKey("Glass"))
                {
                    advancedMaterials.Add("Glass", 0);
                }
                if (!advancedMaterials.ContainsKey("Lithium"))
                {
                    advancedMaterials.Add("Lithium", 0);
                }
                if (!advancedMaterials.ContainsKey("Aluminium"))
                {
                    advancedMaterials.Add("Aluminium", 0);
                }
                if (!advancedMaterials.ContainsKey("Carbon fiber"))
                {
                    advancedMaterials.Add("Carbon fiber", 0);
                }
            }

            if(liquids.Count > 0)
            {
                Console.Write("Liquids left: ");
                Console.WriteLine(string.Join(", ", liquids));
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if(items.Count > 0)
            {
                Console.Write("Physical items left: ");
                Console.WriteLine(string.Join(", ", items));
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            Console.WriteLine($"Aluminium: {advancedMaterials["Aluminium"]}");
            Console.WriteLine($"Carbon fiber: {advancedMaterials["Carbon fiber"]}");
            Console.WriteLine($"Glass: {advancedMaterials["Glass"]}");
            Console.WriteLine($"Lithium: {advancedMaterials["Lithium"]}");
        }
    }
}
