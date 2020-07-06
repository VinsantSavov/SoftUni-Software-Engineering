using System;

namespace _3.footbalSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            double money = 0;

            if (team == "Argentina")
            {
                if(souvenir == "flags")
                {
                    money = num * 3.25;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else if(souvenir == "caps")
                {
                    money = num * 7.20;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else if (souvenir == "posters")
                {
                    money = num * 5.1;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else if (souvenir == "stickers")
                {
                    money = num * 1.25;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team == "Brazil")
            {
                if (souvenir == "flags")
                {
                    money = num * 4.2;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else if (souvenir == "caps")
                {
                    money = num * 8.50;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else if (souvenir == "posters")
                {
                    money = num * 5.35;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else if (souvenir == "stickers")
                {
                    money = num * 1.20;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team == "Croatia")
            {
                if (souvenir == "flags")
                {
                    money = num * 2.75;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else if (souvenir == "caps")
                {
                    money = num * 6.90;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else if (souvenir == "posters")
                {
                    money = num * 4.95;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else if (souvenir == "stickers")
                {
                    money = num * 1.10;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team == "Denmark")
            {
                if (souvenir == "flags")
                {
                    money = num * 3.10;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else if (souvenir == "caps")
                {
                    money = num * 6.50;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else if (souvenir == "posters")
                {
                    money = num * 4.80;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else if (souvenir == "stickers")
                {
                    money = num * 0.90;
                    Console.WriteLine($"Pepi bought {num} {souvenir} of {team} for {money:F2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
            }
        }
    }
}
