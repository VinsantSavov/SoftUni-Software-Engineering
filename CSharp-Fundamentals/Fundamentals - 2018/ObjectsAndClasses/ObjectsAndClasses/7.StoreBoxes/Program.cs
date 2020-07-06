using System;
using System.Collections.Generic;

namespace _7.StoreBoxes
{
    class Program
    {
        class Item
        {
            public string Name { get; set; }
            public string Price { get; set; }
        }
        class Box
        {

            public int SerialNumber { get; set; }
            public Item Item { get; set; }
            public int Quantity { get; set; }
            public decimal PriceForBox { get; set; }
        }

        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();
                int serialNum = int.Parse(tokens[0]);
                string itemName = tokens[1];
                int quantity = int.Parse(tokens[2]);
                decimal price = decimal.Parse(tokens[3]);

                decimal priceBox = quantity * price;

                Box box = new Box()
                { 

                    SerialNumber = serialNum,
                    Quantity = quantity,
                    PriceForBox = priceBox
                };
                box.Item = new Item();
                boxes.Add(box);

            }
            foreach (var kvp in boxes)
            {
                Console.WriteLine(kvp.SerialNumber);
                Console.WriteLine($"-- {kvp.Item.Name} - {kvp.Item.Price}: {kvp.Quantity}");
                Console.WriteLine($"-- {kvp.PriceForBox}");
            }
        }
    }
}
