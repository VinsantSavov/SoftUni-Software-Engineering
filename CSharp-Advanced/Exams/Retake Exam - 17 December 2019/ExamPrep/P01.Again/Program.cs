using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Again
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] materialsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] magicLevelsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> materials = new Stack<int>(materialsInput);
            Queue<int> magicLevels = new Queue<int>(magicLevelsInput);
            Dictionary<string, int> presents = new Dictionary<string, int>();

            while(materials.Count > 0 && magicLevels.Count > 0)
            {
                int material = materials.Peek();
                int magic = magicLevels.Peek();
                int totalMagic = material * magic;

                if(material == 0)
                {
                    materials.Pop();
                    continue;
                }
                if (magic == 0)
                {
                    magicLevels.Dequeue();
                    continue;
                }

                if(totalMagic < 0)
                {
                    int sum = material + magic;
                    materials.Pop();
                    magicLevels.Dequeue();
                    materials.Push(sum);
                    continue;
                }
                
                if(totalMagic == 150)
                {
                    if (!presents.ContainsKey("Doll"))
                    {
                        presents.Add("Doll", 0);
                    }
                    presents["Doll"]++;

                    magicLevels.Dequeue();
                    materials.Pop();
                }
                else if(totalMagic == 250)
                {
                    if (!presents.ContainsKey("Wooden train"))
                    {
                        presents.Add("Wooden train", 0);
                    }
                    presents["Wooden train"]++;

                    materials.Pop();
                    magicLevels.Dequeue();
                }
                else if(totalMagic == 300)
                {
                    if (!presents.ContainsKey("Teddy bear"))
                    {
                        presents.Add("Teddy bear", 0);
                    }
                    presents["Teddy bear"]++;

                    materials.Pop();
                    magicLevels.Dequeue();
                }
                else if(totalMagic == 400)
                {
                    if (!presents.ContainsKey("Bicycle"))
                    {
                        presents.Add("Bicycle", 0);
                    }
                    presents["Bicycle"]++;

                    materials.Pop();
                    magicLevels.Dequeue();
                }
                else
                {
                    magicLevels.Dequeue();
                    materials.Pop();
                    materials.Push(material + 15);
                }
            }

            if (presents.ContainsKey("Doll") && presents.ContainsKey("Wooden train")
                || presents.ContainsKey("Teddy bear") && presents.ContainsKey("Bicycle"))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materials.Any())
            {
                Console.Write("Materials left: ");
                Console.WriteLine(string.Join(", ", materials));
            }
            if (magicLevels.Any())
            {
                Console.Write("Magic left: ");
                Console.WriteLine(string.Join(", ", magicLevels));
            }

            if (presents.Any())
            {
                foreach (var kvp in presents.OrderBy(p => p.Key))
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
