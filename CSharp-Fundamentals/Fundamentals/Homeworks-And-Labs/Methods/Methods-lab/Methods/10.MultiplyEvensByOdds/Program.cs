using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);

            int evenSum = GetSumOfEvenDigits(num);
            int oddSum = GetSumOfOddDigits(num);

            Console.WriteLine(MultiplyOddSumAndEvenSum(oddSum,evenSum));
        }

        static public int GetSumOfEvenDigits(int num)
        {
            int copy = num;
            int sum = 0;

            while (copy != 0)
            {
                int digit = copy % 10;
                copy /= 10;
                
                if(digit % 2 == 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }

        static public int GetSumOfOddDigits(int number)
        {
            string num = number.ToString();
            int digit = 0;
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                digit = int.Parse(num[i].ToString());
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }

        static public int MultiplyOddSumAndEvenSum(int oddSum, int evenSum)
        {
            int result = oddSum * evenSum;

            return result;
        }

    }
}
