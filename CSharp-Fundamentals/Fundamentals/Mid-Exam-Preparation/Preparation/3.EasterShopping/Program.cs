using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split().ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                string command = tokens[0];

                if(command == "Include")
                {
                    string shop = tokens[1];
                    shops.Add(shop);
                }
                else if(command == "Visit")
                {
                    if (tokens[1] == "first")
                    {
                        int numShops = int.Parse(tokens[2]);

                        if(numShops <= shops.Count)
                        {
                            for (int j = 0; j < numShops; j++)
                            {
                                shops.RemoveAt(0);
                            }
                        }
                    }
                    else if(tokens[1] == "last")
                    {
                        int numShops = int.Parse(tokens[2]);

                        if (numShops <= shops.Count)
                        {
                            shops.RemoveRange(shops.Count - numShops, numShops);
                        }
                    }
                }
                else if (command == "Prefer")
                {
                    int indexOne = int.Parse(tokens[1]);
                    int indexTwo = int.Parse(tokens[2]);

                    if (indexOne >= 0 && indexOne < shops.Count && indexTwo >= 0 && indexTwo < shops.Count)
                    {
                        string temp = shops[indexOne];
                        shops[indexOne] = shops[indexTwo];
                        shops[indexTwo] = temp;
                    }
                }
                else if (command == "Place")
                {
                    string shop = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if (index >= 0 && index < shops.Count)
                    {
                        shops.Insert(index+1, shop);
                    }
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ",shops));
         }
    }
}
