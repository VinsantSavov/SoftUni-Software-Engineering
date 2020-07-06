using System;

namespace _1.DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            for (int i = 0; i < days.Length; i++)
            {
                if (n == i + 1)
                {
                    Console.WriteLine(days[i]);
                }
            }
            if (!(n >= 1 && n <= 7))
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
