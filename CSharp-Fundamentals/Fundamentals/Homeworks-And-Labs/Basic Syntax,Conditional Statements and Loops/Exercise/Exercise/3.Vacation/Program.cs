using System;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;
            double discount = 0;

            if(day == "Friday")
            {
                if(type == "Students")
                {
                    if (num >= 30)
                    {
                        totalPrice = num * 8.45;
                        discount = totalPrice *0.15;
                        totalPrice = totalPrice - discount;
                    }
                    else
                    {
                        totalPrice = num * 8.45;
                    }
                }
                else if(type == "Business")
                {
                    if (num >= 100)
                    {
                        num -= 10;
                        totalPrice = num * 10.90;
                    }
                    else
                    {
                        totalPrice = num * 10.90;
                    }
                }
                else if (type == "Regular")
                {
                    if (num >= 10 && num <= 20)
                    {
                        totalPrice = num * 15;
                        discount = totalPrice * 0.05;
                        totalPrice = totalPrice - discount;
                    }
                    else
                    {
                        totalPrice = num * 15;
                    }
                }
            }
            else if (day == "Saturday")
            {
                if (type == "Students")
                {
                    if (num >= 30)
                    {
                        totalPrice = num * 9.80;
                        discount = totalPrice * 0.15;
                        totalPrice = totalPrice - discount;
                    }
                    else
                    {
                        totalPrice = num * 9.80;
                    }
                }
                else if (type == "Business")
                {
                    if (num >= 100)
                    {
                        num -= 10;
                        totalPrice = num * 15.60;
                    }
                    else
                    {
                        totalPrice = num * 15.60;
                    }
                }
                else if (type == "Regular")
                {
                    if (num >= 10 && num <= 20)
                    {
                        totalPrice = num * 20;
                        discount = totalPrice * 0.05;
                        totalPrice = totalPrice - discount;
                    }
                    else
                    {
                        totalPrice = num * 20;
                    }
                }
            }
            else if (day == "Sunday")
            {
                if (type == "Students")
                {
                    if (num >= 30)
                    {
                        totalPrice = num * 10.46;
                        discount = totalPrice * 0.15;
                        totalPrice = totalPrice - discount;
                    }
                    else
                    {
                        totalPrice = num * 10.46;
                    }
                }
                else if (type == "Business")
                {
                    if (num >= 100)
                    {
                        num -= 10;
                        totalPrice = num * 16;
                    }
                    else
                    {
                        totalPrice = num * 16;
                    }
                }
                else if (type == "Regular")
                {
                    if (num >= 10 && num <= 20)
                    {
                        totalPrice = num * 22.50;
                        discount = totalPrice * 0.05;
                        totalPrice = totalPrice - discount;
                    }
                    else
                    {
                        totalPrice = num * 22.50;
                    }
                }
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
