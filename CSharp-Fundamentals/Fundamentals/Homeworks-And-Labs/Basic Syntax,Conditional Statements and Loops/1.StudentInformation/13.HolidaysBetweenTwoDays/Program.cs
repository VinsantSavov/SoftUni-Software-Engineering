using System;
using System.Globalization;

namespace _13.HolidaysBetweenTwoDays
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;
            if (startDate > endDate)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (var date = startDate; date <= endDate; date.AddDays(1))
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        holidaysCount++;
                    }
                }
                Console.WriteLine(holidaysCount);
            }
           
        }
    }
}
