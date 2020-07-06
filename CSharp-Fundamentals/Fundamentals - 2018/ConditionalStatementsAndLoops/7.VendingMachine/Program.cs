using System;

namespace _7.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            double totalMoney = 0;

            while(money != "Start")
            {
               double startingM = double.Parse(money);

               if(startingM == 0.1 || startingM == 0.2 || startingM == 0.5 || startingM ==1 || startingM == 2)
               { 
                    totalMoney += startingM;
               }
                else
                {
                    Console.WriteLine($"Cannot accept {startingM}");
                }
                money = Console.ReadLine();
            }
            string products = Console.ReadLine();

            while(products != "End")
            {
                if (products == "Nuts")
                {
                    if(totalMoney < 2.0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased nuts");
                        totalMoney = totalMoney - 2.0;
                    }
                }
                else if (products == "Water")
                {
                    if (totalMoney < 0.7)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased water");
                        totalMoney = totalMoney - 0.7;
                    }
                }
                else if (products == "Crisps")
                {
                    if (totalMoney < 1.5)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased crisps");
                        totalMoney = totalMoney - 1.5;
                    }
                }
                else if (products == "Soda")
                {
                    if (totalMoney < 0.8)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased soda");
                        totalMoney = totalMoney - 0.8;
                    }
                }
                else if (products == "Coke")
                {
                    if (totalMoney < 1.0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased coke");
                        totalMoney = totalMoney - 1.0;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                products = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}
