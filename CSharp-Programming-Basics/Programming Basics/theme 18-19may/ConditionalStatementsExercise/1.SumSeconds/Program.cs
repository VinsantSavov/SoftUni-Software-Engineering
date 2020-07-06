using System;

namespace _1.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeFirst = int.Parse(Console.ReadLine());
            int timeSecond = int.Parse(Console.ReadLine());
            int timeThird = int.Parse(Console.ReadLine());

            int sum = timeFirst + timeSecond + timeThird;

            double minutes = sum / 60;
            double seconds= sum % 60;

            if (seconds >= 10)
            {
                Console.WriteLine("{0}:{1}", minutes, seconds);
            }
            else
            {
                Console.WriteLine("{0}:0{1}", minutes, seconds);
            }
        }
    }
}
