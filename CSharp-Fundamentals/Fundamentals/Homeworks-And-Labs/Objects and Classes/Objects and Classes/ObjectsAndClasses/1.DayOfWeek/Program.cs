using System;
using System.Globalization;

namespace _1.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime Date = new DateTime();
            Date = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(Date.DayOfWeek);
        }
    }
}
