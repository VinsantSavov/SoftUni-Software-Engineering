using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsNum = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger maxValue = 0;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;

            for(int i = 0; i < snowballsNum; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger cv = snow / time;
                snowballValue = BigInteger.Pow(cv, quality);
                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    maxSnow = snow;
                    maxTime = time;
                    maxQuality = quality;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
        }
    }
}
