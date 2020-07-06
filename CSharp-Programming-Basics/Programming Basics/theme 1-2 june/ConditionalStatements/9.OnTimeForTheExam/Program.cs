using System;

namespace _9.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int differenceMinutes = 0;
            int hoursChange = 0;
            int minutesChange = 0;

            int time = hour * 60 + minutes;
            int arriveTime = arriveHour * 60 + arriveMinutes;

            differenceMinutes = time - arriveTime;
            
            if(differenceMinutes > 0 && differenceMinutes > 30)
            {
                Console.WriteLine("Early");
                hoursChange = differenceMinutes / 60;
                minutesChange = differenceMinutes % 60;

                if(hoursChange > 0)
                {
                    if(minutesChange < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours before the start", hoursChange, minutesChange);
                    }
                    else if (minutesChange > 10)
                    {
                        Console.WriteLine("{0}:{1} hours before the start", hoursChange, minutesChange);
                    }
                }
                else if(hoursChange == 0)
                {
                    if (minutesChange < 10)
                    {
                        Console.WriteLine("{0} minutes before the start",  minutesChange);
                    }
                    else if (minutesChange > 10)
                    {
                        Console.WriteLine("{0} minutes before the start",  minutesChange);
                    }
                }

            }
            else if(differenceMinutes > 0 && differenceMinutes <= 30 || time == arriveTime)
            {
                Console.WriteLine("On time");
                hoursChange = differenceMinutes / 60;
                minutesChange = differenceMinutes % 60;

                if (hoursChange > 0)
                {
                    if (minutesChange < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours before the start", hoursChange, minutesChange);
                    }
                    else if (minutesChange > 10)
                    {
                        Console.WriteLine("{0}:{1} hours before the start", hoursChange, minutesChange);
                    }
                }
                else if (hoursChange == 0)
                {
                    if (minutesChange < 10)
                    {
                        Console.WriteLine("{0} minutes before the start", minutesChange);
                    }
                    else if (minutesChange > 10)
                    {
                        Console.WriteLine("{0} minutes before the start", minutesChange);
                    }
                }
            }
            else if(differenceMinutes < 0)
            {
                Console.WriteLine("Late");
                differenceMinutes = Math.Abs(differenceMinutes);
                hoursChange = differenceMinutes / 60;
                minutesChange = differenceMinutes % 60;

                if (hoursChange > 0)
                {
                    if (minutesChange < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", hoursChange, minutesChange);
                    }
                    else if (minutesChange > 10)
                    {
                        Console.WriteLine("{0}:{1} hours after the start", hoursChange, minutesChange);
                    }
                }
                else if (hoursChange == 0)
                {
                    if (minutesChange < 10)
                    {
                        Console.WriteLine("{0} minutes after the start", minutesChange);
                    }
                    else if (minutesChange > 10)
                    {
                        Console.WriteLine("{0} minutes after the start", minutesChange);
                    }
                }
            }

        }
    }
}
