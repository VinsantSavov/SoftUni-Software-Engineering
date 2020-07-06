using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "No Money")
                {
                    break;
                }

                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                if(command == "OutOfStock")
                {
                    string gift = tokens[1];

                    for (int i = 0; i < gifts.Count; i++)
                    {
                        if(gifts[i] == gift)
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if(command == "Required")
                {
                    string gift = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if(index >= 0 && index < gifts.Count)
                    {
                        gifts[index] = gift;
                    }
                }
                else if(command == "JustInCase")
                {
                    string gift = tokens[1];
                    gifts[gifts.Count - 1] = gift;
                }
            }
            foreach (var gift in gifts)
            {
                if(gift != "None")
                {
                    Console.Write(gift + " ");
                }
            }
        }
    }
}
