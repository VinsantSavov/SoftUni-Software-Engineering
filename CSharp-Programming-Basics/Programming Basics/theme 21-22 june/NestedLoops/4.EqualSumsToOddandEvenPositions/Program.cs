using System;

namespace _4.EqualSumsToOddandEvenPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();


            for(int numsBetween = int.Parse(firstNum); numsBetween <= int.Parse(secondNum); numsBetween++)
            {
                string number = numsBetween.ToString();
                int evenSum = 0;
                int oddSum = 0;
                for(int i = 5; i >= 0; i--)
                { 
                    char currentDigit = number[i];
                    int currentDigitToNum = int.Parse(currentDigit.ToString());

                    if (i % 2 == 0)
                    {
                        evenSum +=currentDigitToNum;
                    }
                    else
                    {
                        oddSum += currentDigitToNum;
                    }
                    
                }
                if (evenSum == oddSum)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
