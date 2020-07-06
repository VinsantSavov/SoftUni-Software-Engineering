using System;

namespace _10.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidaysNum = int.Parse(Console.ReadLine());
            int timesGoingCamp = int.Parse(Console.ReadLine());

            double playingInSofia = 0;
            double playingVolleyinCamp = 0;
            double playingDuringHolidays = 0;

            double allPlays = 0;

            if(year == "leap")
            {
                playingInSofia = ((48 - timesGoingCamp) * 3.0 / 4);

                playingVolleyinCamp = timesGoingCamp;

                playingDuringHolidays = holidaysNum * 2.0 / 3;

                allPlays = (playingInSofia + playingVolleyinCamp + playingDuringHolidays)*0.15;
                allPlays =Math.Floor(allPlays + playingInSofia + playingVolleyinCamp + playingDuringHolidays);
            }
            else
            {
                playingInSofia = ((48 - timesGoingCamp) * 3.0 / 4);

                playingVolleyinCamp = timesGoingCamp;

                playingDuringHolidays = holidaysNum * 2.0 / 3;

                allPlays =Math.Floor( playingInSofia + playingVolleyinCamp + playingDuringHolidays);
            }

            Console.WriteLine("{0}", allPlays);
        }
    }
}
