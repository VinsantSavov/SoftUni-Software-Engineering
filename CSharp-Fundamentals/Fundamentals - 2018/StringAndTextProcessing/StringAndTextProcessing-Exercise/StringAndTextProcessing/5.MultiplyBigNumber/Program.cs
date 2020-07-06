using System;
using System.Linq;

namespace _5.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine().TrimStart('0');
            int secondNumber = int.Parse(Console.ReadLine());

            string resultNumber = string.Empty;
            int onMind = 0;

            string reverseFirstNum = string.Join("", num.ToCharArray().Reverse());

            if (num == "0" || secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < reverseFirstNum.Length; i++)
            {
                int firstDigit = int.Parse(reverseFirstNum[i].ToString());

                int result = firstDigit * secondNumber + onMind;
                resultNumber += result % 10;
                onMind = result / 10;

                if (i == reverseFirstNum.Length - 1 && onMind != 0)
                {
                    resultNumber += onMind;
                }
            }

            string finalResult = string.Join("", resultNumber.ToCharArray().Reverse());

            Console.WriteLine(finalResult);
        }
    }
}
