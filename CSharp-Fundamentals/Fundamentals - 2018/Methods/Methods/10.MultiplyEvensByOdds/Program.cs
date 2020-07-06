using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(Math.Abs(result));
        }

        public static int GetSumOfOddDigits(int num)
        {
            int result = 0;
            int oddSum = 0;

            while (Math.Abs(num) > 0)
            {
                result = Math.Abs(num % 10);
                num /= 10;

                if(result%2 != 0)
                {
                    oddSum += result;
                }
            }
            return oddSum;
        }

        public static int GetSumOfEvenDigits(int num)
        {
            int result = 0;
            int evenSum = 0;

            while (Math.Abs(num) > 0)
            {
                result = Math.Abs(num % 10);
                num /= 10;

                if (result % 2 == 0)
                {
                    evenSum += result;
                }
            }
            return evenSum;
        }

        public static int GetMultipleOfEvenAndOdds(int num)
        {
            int evenSum = GetSumOfEvenDigits(num);
            int oddSum = GetSumOfOddDigits(num);
            int multiple = evenSum * oddSum;
            return multiple;
        }
    }
}
