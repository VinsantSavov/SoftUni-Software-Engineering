using System;

namespace _8.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string assessment = Console.ReadLine();
            double discount;
            double cost = 0;

            if(roomType == "room for one person" && assessment == "positive")
            {
                
                cost = (days - 1) * 18;
                cost = cost + cost * 0.25;
                
            }
            else if (roomType == "room for one person" && assessment == "negative")
            {
                
                cost = (days - 1) * 18;
                cost = cost + cost * 0.1;
                
            }
            else if(roomType == "apartment" && assessment == "positive")
            {
                if (days < 10)
                {
                    cost = (days - 1) * 25;
                    discount = cost * 0.3;
                    cost = cost - discount;
                    cost = cost + cost * 0.25;
                }
                else if (10 <= days && days <= 15)
                {
                    cost = (days - 1) * 25;
                    discount = cost * 0.35;
                    cost = cost - discount;
                    cost = cost + cost * 0.25;
                }
                else if (days > 15)
                {
                    cost = (days - 1) * 25;
                    discount = cost * 0.5;
                    cost = cost - discount;
                    cost = cost + cost * 0.25;
                }
                
            }
            else if (roomType == "apartment" && assessment == "negative")
            {
                if (days < 10)
                {
                    cost = (days - 1) * 25;
                    discount = cost * 0.3;
                    cost = cost - discount;
                    cost = cost - cost * 0.1;
                }
                else if (10 <= days && days <= 15)
                {
                    cost = (days - 1) * 25;
                    discount = cost * 0.35;
                    cost = cost - discount;
                    cost = cost - cost * 0.1;
                }
                else if (days > 15)
                {
                    cost = (days - 1) * 25;
                    discount = cost * 0.5;
                    cost = cost - discount;
                    cost = cost - cost * 0.1;
                }
                
            }
            else if (roomType == "president apartment" && assessment == "positive")
            {
                if (days < 10)
                {
                    cost = (days - 1) * 35;
                    discount = cost * 0.1;
                    cost = cost - discount;
                    cost = cost + cost * 0.25;
                }
                else if (10 <= days && days <= 15)
                {
                    cost = (days - 1) * 35;
                    discount = cost * 0.15;
                    cost = cost - discount;
                    cost = cost + cost * 0.25;
                }
                else if (days > 15)
                {
                    cost = (days - 1) * 35;
                    discount = cost * 0.20;
                    cost = cost - discount;
                    cost = cost + cost * 0.25;
                }
                
            }
            else if (roomType == "president apartment" && assessment == "negative")
            {
                if (days < 10)
                {
                    cost = (days - 1) * 35;
                    discount = cost * 0.1;
                    cost = cost - discount;
                    cost = cost - cost * 0.1;
                }
                else if (10 <= days && days <= 15)
                {
                    cost = (days - 1) * 35;
                    discount = cost * 0.15;
                    cost = cost - discount;
                    cost = cost - cost * 0.1;
                }
                else if (days > 15)
                {
                    cost = (days - 1) * 35;
                    discount = cost * 0.2;
                    cost = cost - discount;
                    cost = cost - cost * 0.1;
                }
                
            }
            Console.WriteLine("{0:F2}", cost);
        }
    }
}
