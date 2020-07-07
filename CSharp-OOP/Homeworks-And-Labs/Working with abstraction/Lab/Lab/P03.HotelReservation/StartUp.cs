using System;

namespace P03.HotelReservation
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double pricePerDay = double.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);
            Season season = Enum.Parse<Season>(input[2]);
            double result = 0;

            if(input.Length == 4)
            {
                Discount discountType = Enum.Parse<Discount>(input[3]);
                result = PriceCalculator.GetTotalPrice(pricePerDay, numberOfDays, season, discountType);
            }
            else
            {

                result = PriceCalculator.GetTotalPrice(pricePerDay, numberOfDays, season);
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
