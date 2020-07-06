using System;

namespace _8.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            decimal result = FactorialOne(firstNum) / FactorialTwo(secondNum);
            Console.WriteLine($"{result:F2}");
        }

        public static int FactorialOne(int first)
        {
            int factorial = 1;

            for(int i = 1; i <= first; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static int FactorialTwo(int second)
        {
            int factorial = 1;

            for (int i = 1; i <= second; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
