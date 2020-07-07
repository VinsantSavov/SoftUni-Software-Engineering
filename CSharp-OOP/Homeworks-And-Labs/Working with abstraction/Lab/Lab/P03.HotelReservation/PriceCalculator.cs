namespace P03.HotelReservation
{
    public static class PriceCalculator
    {
        public static double GetTotalPrice(double pricePerDay, int numberOfDays,
            Season season, Discount discountType = Discount.None)
        {

            double result = pricePerDay * numberOfDays * (int)season;

            result -= result * (int)discountType / 100;

            return result;
        }
    }
}
