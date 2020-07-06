using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials.Add("motes", 0);

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            while (true)
            {
                List<string> materials = Console.ReadLine().Split().ToList();
                bool haveToBreak = false;

                for(int i = 0; i < materials.Count; i += 2)
                {
                    int quantity = int.Parse(materials[i]);
                    string material = materials[i + 1].ToLower();

                    if(material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (!keyMaterials.ContainsKey(material))
                        {
                            keyMaterials[material] = quantity;
                        }
                        else
                        {
                            keyMaterials[material] += quantity;
                        }

                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;

                            if(material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            haveToBreak = true;
                            break;
                        }
                        
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = quantity;
                        }
                        else
                        {
                            junkMaterials[material] += quantity;
                        }
                    }
                }
                if (haveToBreak)
                {
                    break;
                }
            }
            foreach (var kvp in keyMaterials.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junkMaterials.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            
        }
    }
}
