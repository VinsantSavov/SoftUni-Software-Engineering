using System;

namespace _1.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            SmallestNumber(first, second, third);
        }

        static public void SmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else if (thirdNumber <= firstNumber && thirdNumber <= secondNumber)
            {
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
