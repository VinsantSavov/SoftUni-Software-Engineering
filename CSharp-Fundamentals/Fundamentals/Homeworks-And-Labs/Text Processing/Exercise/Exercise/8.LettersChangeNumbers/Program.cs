using System;
using System.Linq;

namespace _8.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pairs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0;

            foreach (var pair in pairs)
            {
                char letterBefore = pair[0];
                char letterAfter = pair[pair.Length - 1];
                double num = double.Parse(pair.Substring(1, pair.Length - 2));
                double result = 0.0;

                if (char.IsLower(letterBefore))
                {
                    result = num * (letterBefore - 96);
                }
                else if (char.IsUpper(letterBefore))
                {
                    result = num*1.0 / (letterBefore - 64);
                }
                if (char.IsLower(letterAfter))
                {
                    result += letterAfter - 96;
                }
                else if (char.IsUpper(letterAfter))
                {
                    result -= letterAfter - 64;
                }

                sum += result;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
