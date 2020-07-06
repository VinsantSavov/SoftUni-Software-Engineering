using System;

namespace _3.OddorEvenPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double OddSum = 0;
            double OddMax = double.MinValue;
            double OddMin = double.MaxValue;

            double EvenSum = 0;
            double EvenMax = double.MinValue;
            double EvenMin = double.MaxValue;

            for(int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum += number;

                    if (number > EvenMax)
                    {
                        EvenMax = number;
                    }
                    if (number < EvenMin)
                    {
                        EvenMin = number;
                    }
                }
                else
                {
                    OddSum += number;

                    if (number > OddMax)
                    {
                        OddMax = number;
                    }
                    if (number < OddMin)
                    {
                        OddMin = number;
                    }
                }
            }
            Console.WriteLine("OddSum={0:F2},", OddSum);
            if (OddMin == 0 && OddMax == 0 || n ==0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMin={0:F2},", OddMin);
                Console.WriteLine("OddMax={0:F2},", OddMax);
                
            }
            Console.WriteLine("EvenSum={0:F2},", EvenSum);
            if (EvenMin == 0 && EvenMax == 0 || EvenMin == double.MaxValue && EvenMax == double.MinValue)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0:F2},", EvenMin);
                Console.WriteLine("EvenMax={0:F2}", EvenMax);
            }
        }
    }
}
