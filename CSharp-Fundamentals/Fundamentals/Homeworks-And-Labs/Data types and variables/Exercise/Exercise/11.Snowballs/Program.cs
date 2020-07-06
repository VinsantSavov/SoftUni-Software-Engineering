using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;
            BigInteger maxValue = 0;

            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                if (time != 0)
                {
                    BigInteger value = BigInteger.Pow((snow / time), quality);

                    if (value > maxValue)
                    {
                        maxValue = value;
                        maxSnow = snow;
                        maxTime = time;
                        maxQuality = quality;
                    }
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
        }
    }
}
