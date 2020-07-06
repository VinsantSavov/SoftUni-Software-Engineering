using System;

namespace _7.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double time1meter = double.Parse(Console.ReadLine());

            double totalTime = meters * time1meter;
            double timesDelay = Math.Floor(meters / 15);
            double resistanceTime = timesDelay * 12.5;
            

            totalTime = totalTime + resistanceTime;

            if (totalTime < record)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", totalTime);
               
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", totalTime - record);
            }
        }
    }
}
