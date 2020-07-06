using System;

namespace _3.Calculations
{
    class Program
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                AddNumbers(firstNum, secondNum);
            }
            else if(command == "multiply")
            {
                MultiplyNumbers(firstNum, secondNum);
            }
            else if (command == "subtract")
            {
                SubtractNumbers(firstNum, secondNum);
            }
            else if (command == "divide")
            {
                DivideNumbers(firstNum, secondNum);
            }


        }

        public static void AddNumbers(int first,int second)
        {
            int result = first + second;
            Console.WriteLine(result);
        }
        
        public static void MultiplyNumbers(int first,int second)
        {
            int result = first * second;
            Console.WriteLine(result);
        }

        public static void SubtractNumbers(int first,int second)
        {
            int result = first - second;
            Console.WriteLine(result);
        }

        public static void DivideNumbers(int first,int second)
        {
            int result = first / second;
            Console.WriteLine(result);
        }
    }
}
