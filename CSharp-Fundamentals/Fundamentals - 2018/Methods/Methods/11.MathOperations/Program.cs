using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char type = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double result = Calculate(firstNumber, type, secondNumber);
            Console.WriteLine(result);
        }

        public static double Calculate(int firstNum,char type,int secondNum)
        {
            double result = 0;

            if(type == '+')
            {
                result = firstNum + secondNum;
            }
            else if(type == '-')
            {
                result = firstNum - secondNum;
            }
            else if(type == '*')
            {
                result = firstNum * secondNum;
            }
            else if(type == '/')
            {
                result = firstNum / secondNum;
            }
            return result;
        }
    }
}
