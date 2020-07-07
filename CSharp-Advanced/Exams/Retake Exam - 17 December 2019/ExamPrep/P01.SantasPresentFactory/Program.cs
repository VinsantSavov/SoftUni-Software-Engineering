using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.SantasPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> materials = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> magicValues = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Dictionary<string, int> craftedPresents = new Dictionary<string, int>();
            List<int> magicNeeded = new List<int>
            {
                150,
                250,
                300,
                400
            };

            Stack<int> materialsBoxes = new Stack<int>(materials);
            Queue<int> magicBoxes = new Queue<int>(magicValues);

            while(materialsBoxes.Any() && magicBoxes.Any())
            {
                int material = materialsBoxes.Peek();
                int magic = magicBoxes.Peek();
                int multiplied = material * magic;

                if(material == 0)
                {
                    materialsBoxes.Pop();
                    continue;
                }
                if(magic == 0)
                {
                    magicBoxes.Dequeue();
                    continue;
                }
                else if(multiplied < 0)
                {
                    material = materialsBoxes.Pop();
                    magic = magicBoxes.Dequeue();
                    int sum = material + magic;
                    materialsBoxes.Push(sum);
                }
                else if (!magicNeeded.Contains(multiplied))
                {
                    material = materialsBoxes.Pop();
                    magic = magicBoxes.Dequeue();
                    material += 15;
                    var temp = new List<int>();

                    foreach (var item in materialsBoxes.Reverse())
                    {
                        temp.Add(item);
                    }
                    temp.Add(material);
                    materialsBoxes = new Stack<int>(temp);
                }
                else if(multiplied == 150)
                {
                    material = materialsBoxes.Pop();
                    magic = magicBoxes.Dequeue();
                    if (!craftedPresents.ContainsKey("Doll"))
                    {
                        craftedPresents.Add("Doll", 0);
                    }
                    craftedPresents["Doll"]++;
                }
                else if(multiplied == 250)
                {
                    material = materialsBoxes.Pop();
                    magic = magicBoxes.Dequeue();
                    if (!craftedPresents.ContainsKey("Wooden train"))
                    {
                        craftedPresents.Add("Wooden train", 0);
                    }
                    craftedPresents["Wooden train"]++;
                }
                else if (multiplied == 300)
                {
                    material = materialsBoxes.Pop();
                    magic = magicBoxes.Dequeue();
                    if (!craftedPresents.ContainsKey("Teddy bear"))
                    {
                        craftedPresents.Add("Teddy bear", 0);
                    }
                    craftedPresents["Teddy bear"]++;
                }
                else if (multiplied == 400)
                {
                    material = materialsBoxes.Pop();
                    magic = magicBoxes.Dequeue();
                    if (!craftedPresents.ContainsKey("Bicycle"))
                    {
                        craftedPresents.Add("Bicycle", 0);
                    }
                    craftedPresents["Bicycle"]++;
                }
            }

            if (craftedPresents.ContainsKey("Doll") && craftedPresents.ContainsKey("Wooden train")
                || craftedPresents.ContainsKey("Teddy bear") && craftedPresents.ContainsKey("Bicycle"))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materialsBoxes.Any())
            {
                Console.Write("Materials left: ");
                Console.WriteLine(string.Join(", ", materialsBoxes));
            }
            if (magicBoxes.Any())
            {
                Console.Write("Magic left: ");
                Console.WriteLine(string.Join(", ", magicBoxes));
            }

            foreach (var kvp in craftedPresents.OrderBy(n=>n.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
