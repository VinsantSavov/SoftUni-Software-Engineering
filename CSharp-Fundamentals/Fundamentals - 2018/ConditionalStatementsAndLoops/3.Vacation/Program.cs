using System;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double money=0;
            double discount = 0;

            if(day == "Friday")
            {
                if(type == "Students")
                {
                    money = people * 8.45;
                    if(people >= 30)
                    {
                        discount = money * 0.15;
                        money = money - discount;
                    }
                }
                else if(type == "Business")
                {
                    money = people * 10.90;
                    if (people >= 100)
                    {
                        int num = people;
                        num = num - 10;
                        money = num * 10.90;
                    }
                }
                else if(type == "Regular")
                {
                    money = people * 15;
                    if (people >= 10 && people <= 20)
                    {
                        discount = money * 0.15;
                        money = money - discount;
                    }
                }
            }
            else if (day == "Saturday")
            {
                if (type == "Students")
                {
                    money = people * 9.80;
                    if (people >= 30)
                    {
                        discount = money * 0.15;
                        money = money - discount;
                    }
                }
                else if (type == "Business")
                {
                    money = people * 15.60;
                    if (people >= 100)
                    {
                        int num = people;
                        num = num - 10;
                        money = num * 15.60;
                    }
                    
                }
                else if (type == "Regular")
                {
                    money = people * 20;
                    if (people >= 10 && people <= 20)
                    {
                        money = money - money * 0.05;
                    }
                }
            }
            else if (day == "Sunday")
            {
                if (type == "Students")
                {
                    money = people * 10.46;
                    if (people >= 30)
                    {
                        money = money - money * 0.15;
                    }
                }
                else if (type == "Business")
                {
                    money = people * 16;
                    if (people >= 100)
                    {
                        int num = people;
                        num = num - 10;
                        money = num * 16;
                    }
                    
                }
                else if (type == "Regular")
                {
                    money = people * 22.50;
                    if (people >= 10 && people <= 20)
                    {
                        money = money - money * 0.05;
                    }
                }
                Console.WriteLine($"Total price: {0:F2}", money);
            }
            Console.WriteLine($"Total price: {0:F2}",money);
        }
    }
}
