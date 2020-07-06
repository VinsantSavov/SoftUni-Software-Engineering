using System;

namespace _7.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Start")
                {
                    break;
                }
                double money = double.Parse(input);

                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
                {
                    totalMoney += money; 
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
            }
            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }
                if (input == "Nuts")
                {
                    if (totalMoney >= 2.0)
                    {
                        Console.WriteLine($"Purchased nuts");
                        totalMoney -= 2.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Water")
                {
                    if (totalMoney >= 0.7)
                    {
                        Console.WriteLine($"Purchased water");
                        totalMoney -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Crisps")
                {
                    if (totalMoney >= 1.5)
                    {
                        Console.WriteLine($"Purchased crisps");
                        totalMoney -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Soda")
                {
                    if (totalMoney >= 0.8)
                    {
                        Console.WriteLine($"Purchased soda");
                        totalMoney -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Coke")
                {
                    if (totalMoney >= 1.0)
                    {
                        Console.WriteLine($"Purchased coke");
                        totalMoney -= 1.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}
