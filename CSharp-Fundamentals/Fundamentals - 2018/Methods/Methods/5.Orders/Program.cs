using System;

namespace _5.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            TotalOrderPrice(item, quantity);

        }
        public static void TotalOrderPrice(string product,int quantity)
        {
            double price = 0;
            double result = 0;
            if (product == "coffee")
            {
                price = 1.5;
            }
            else if(product == "water")
            {
                price = 1.00;
            }
            else if (product == "coke")
            {
                price = 1.40;
            }
            else if (product == "snacks")
            {
                price = 2.00;
            }
            result = price * quantity;
            Console.WriteLine($"{result:F2}");
        }
    }
}
