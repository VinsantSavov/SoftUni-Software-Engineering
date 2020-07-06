using System;
using System.Globalization;

namespace _1.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringDate = Console.ReadLine();

            DateTime date = DateTime.ParseExact(stringDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
