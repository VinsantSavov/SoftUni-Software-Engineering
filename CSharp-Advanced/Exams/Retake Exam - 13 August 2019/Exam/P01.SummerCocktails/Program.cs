using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.SummerCocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ingredientsInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] freshnessInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> ingredients = new Queue<int>(ingredientsInfo);
            Stack<int> freshnessLevels = new Stack<int>(freshnessInfo);

            Dictionary<string, int> cocktails = new Dictionary<string, int>();

            while(ingredients.Count > 0 && freshnessLevels.Count > 0)
            {
                int ingredient = ingredients.Peek();
                int fresh = freshnessLevels.Peek();
                int totalFreshness = ingredient * fresh;

                if(ingredient == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }
                //if(fresh == 0)
                //{
                //    freshnessLevels.Pop();
                //    continue;
                //}

                if(totalFreshness == 150)
                {
                    if (!cocktails.ContainsKey("Mimosa"))
                    {
                        cocktails.Add("Mimosa", 0);
                    }
                    cocktails["Mimosa"]++;

                    ingredients.Dequeue();
                    freshnessLevels.Pop();
                }
                else if (totalFreshness == 250)
                {
                    if (!cocktails.ContainsKey("Daiquiri"))
                    {
                        cocktails.Add("Daiquiri", 0);
                    }
                    cocktails["Daiquiri"]++;

                    ingredients.Dequeue();
                    freshnessLevels.Pop();
                }
                else if (totalFreshness == 300)
                {
                    if (!cocktails.ContainsKey("Sunshine"))
                    {
                        cocktails.Add("Sunshine", 0);
                    }
                    cocktails["Sunshine"]++;

                    ingredients.Dequeue();
                    freshnessLevels.Pop();
                }
                else if (totalFreshness == 400)
                {
                    if (!cocktails.ContainsKey("Mojito"))
                    {
                        cocktails.Add("Mojito", 0);
                    }
                    cocktails["Mojito"]++;

                    ingredients.Dequeue();
                    freshnessLevels.Pop();
                }
                else
                {
                    freshnessLevels.Pop();
                    ingredients.Enqueue(ingredients.Dequeue() + 5);
                }
            }

            if(cocktails.Count == 4)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }

            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (var cocktail in cocktails.OrderBy(c=>c.Key))
            {
                Console.WriteLine($"# {cocktail.Key} --> {cocktail.Value}");
            }
        }
    }
}
