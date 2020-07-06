using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.StoreBoxes
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForBox { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                List<string> tokens = input.Split().ToList();

                int serialNumber = int.Parse(tokens[0]);
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                double itemPrice = double.Parse(tokens[3]);

                double priceForBox = itemQuantity * itemPrice;
             
                Item item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice
                };
                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    ItemQuantity = itemQuantity,
                    PriceForBox = priceForBox
                };

                boxes.Add(box);
            }
            List<Box> orderedBoxes = boxes.OrderByDescending(x => x.PriceForBox).ToList();

            foreach (var box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }
}
