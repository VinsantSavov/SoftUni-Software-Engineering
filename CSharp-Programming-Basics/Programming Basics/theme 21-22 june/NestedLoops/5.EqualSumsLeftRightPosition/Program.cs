using System;

namespace _5.EqualSumsLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for(int numbersBetween = firstNumber; numbersBetween <= secondNumber; numbersBetween++)
            {
                string number = numbersBetween.ToString();
                int leftSum = 0;
                int rightSum = 0;
                int num2 = 0;
                for(int i = 4; i >= 0; i--)
                {
                    char symbol = number[i];
                    int num = int.Parse(symbol.ToString());
                    if(i==4 || i == 3)
                    {
                        leftSum += num;
                    }
                    else if(i==1 || i == 0)
                    {
                        rightSum += num;
                    }
                    if(i==2)
                    {
                        num2 = num;
                    }
                    
                }
                if (leftSum == rightSum)
                {
                    Console.Write(number + " ");
                }
                else
                {
                    if (leftSum < rightSum )
                    {
                        leftSum += num2;
                    }
                    else
                    {
                        rightSum += num2;
                    }
                    if (leftSum == rightSum)
                    {
                        Console.Write(number+" ");
                    }
                }
            }
        }
    }
}
