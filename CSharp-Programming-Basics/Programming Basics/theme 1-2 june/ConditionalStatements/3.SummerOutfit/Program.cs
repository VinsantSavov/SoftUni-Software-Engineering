using System;

namespace _3.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();

            if(degrees >=10 && degrees <=18 && partOfTheDay == "Morning")
            {
                Console.WriteLine("It's {0} degrees, get your Sweatshirt and Sneakers.",degrees);
            }
            else if (degrees >= 10 && degrees <= 18 && partOfTheDay == "Afternoon")
            {
                Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
            }
            else if (degrees >= 10 && degrees <= 18 && partOfTheDay == "Evening")
            {
                Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
            }
            else if (degrees > 18 && degrees <= 24 && partOfTheDay == "Morning")
            {
                Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.",degrees);
            }
            else if (degrees > 18 && degrees <= 24 && partOfTheDay == "Afternoon")
            {
                Console.WriteLine("It's {0} degrees, get your T-Shirt and Sandals.", degrees);
            }
            else if (degrees > 18 && degrees <= 24 && partOfTheDay == "Evening")
            {
                Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
            }
            else if(degrees >=25 && partOfTheDay == "Morning")
            {
                Console.WriteLine("It's {0} degrees, get your T-Shirt and Sandals.", degrees);
            }
            else if (degrees >= 25 && partOfTheDay == "Afternoon")
            {
                Console.WriteLine("It's {0} degrees, get your Swim Suit and Barefoot.", degrees);
            }
            else if (degrees >= 25 && partOfTheDay == "Evening")
            {
                Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
            }
        }
    }
}
