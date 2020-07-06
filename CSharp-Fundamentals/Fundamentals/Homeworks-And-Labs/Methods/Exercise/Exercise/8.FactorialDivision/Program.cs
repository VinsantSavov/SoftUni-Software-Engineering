using System;

namespace _8.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNum = int.Parse(Console.ReadLine());
            long secondNum = int.Parse(Console.ReadLine());

            double result = CalculatesTheFactorials(firstNum, secondNum);
            Console.WriteLine($"{result:F2}");
        }

        static public double CalculatesTheFactorials(long first, long second)
        {
            long firstFactorial = 1;
            long secondFactorial = 1;

            if (first != 0)
            {
                for (int i = 1; i <= first; i++)
                {
                    firstFactorial *= i;
                }
            }
            if (second != 0)
            {
                for (int j = 1; j <= second; j++)
                {
                    secondFactorial *= j;
                }
            }

            return firstFactorial*1.0 / secondFactorial;
        }
    }
}
