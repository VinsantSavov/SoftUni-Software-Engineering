using System;

namespace ChristmasGifts2
{
    class Program
    {
        static void Main(string[] args)
        {
            string age = Console.ReadLine();
            int countUnder = 0;
            int countOver = 0;

            while(age != "Christmas")
            {
                int memberAge = int.Parse(age);

                if(memberAge <= 16)
                {
                    countUnder++;
                }
                else if (memberAge > 16)
                {
                    countOver++;
                }
                age = Console.ReadLine();
            }
            int moneyUnder = countUnder * 5;
            int moneyOver = countOver * 15;

            Console.WriteLine($"Number of adults: {countOver}");
            Console.WriteLine($"Number of kids: {countUnder}");
            Console.WriteLine($"Money for toys: {moneyUnder}");
            Console.WriteLine($"Money for sweaters: {moneyOver}");
        }
    }
}
