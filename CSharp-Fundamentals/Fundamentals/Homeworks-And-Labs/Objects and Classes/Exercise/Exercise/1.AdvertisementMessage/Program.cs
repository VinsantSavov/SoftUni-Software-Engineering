using System;

namespace _1.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = new string[6] {"Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };

            string[] events = new string[6]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = new string[8]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva" 
            };

            string[] cities = new string[5]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse" 
            };
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                int phrase = random.Next(0, 6);
                int @event = random.Next(0, 6);
                int author = random.Next(0, 8);
                int city = random.Next(0, 5);

                Console.WriteLine($"{phrases[phrase]} {events[@event]} {authors[author]} - {cities[city]}");
            }

        }
    }
}
