using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double result = MathOperation(firstNum, @operator, secondNum);
            result = Math.Round(result);
            Console.WriteLine($"{result}");
        }

        static public double MathOperation(int firstNumber, char @operator, int secondNumber)
        {
            if(@operator == '/')
            {
                return firstNumber / secondNumber;
            }
            else if(@operator == '*')
            {
                return firstNumber * secondNumber;
            }
            else if(@operator == '+')
            {
                return firstNumber + secondNumber;
            }
            else
            {
                return firstNumber - secondNumber;
            }
        }
    }
}
