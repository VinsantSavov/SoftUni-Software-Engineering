using System;

namespace _5.Time_15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMin = hours * 60 + minutes;
            int totalMinPlus15 = totalMin + 15;

            int currentHours = totalMinPlus15 / 60;
            int currentMins = totalMinPlus15 % 60;

            if(currentHours == 24)
            {
                currentHours -= 24;
            }
            if (currentMins < 10)
            {
                Console.WriteLine("{0}:0{1}", currentHours, currentMins);
            }
            else
            {
                Console.WriteLine("{0}:{1}", currentHours, currentMins);
            }
        }
    }
}
