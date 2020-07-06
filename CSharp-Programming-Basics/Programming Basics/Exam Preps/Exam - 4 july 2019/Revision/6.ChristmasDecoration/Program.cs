using System;

namespace _6.ChristmasDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string item = Console.ReadLine();

            while (item != "Stop")
            {
                int moneyItem = 0;
                for(int i = 0; i < item.Length; i++)
                {
                    int money = (int)item[i];
                    moneyItem += money;
                }
                if (moneyItem <= budget)
                {
                    Console.WriteLine("Item successfully purchased!");
                    budget -= moneyItem;
                }
                else if(moneyItem > budget)
                {
                    Console.WriteLine("Not enough money!");
                    break;
                }
                item = Console.ReadLine();
            }
            if(item == "Stop")
            {
                Console.WriteLine("Money left: {0}", budget);
            }

        }
    }
}
