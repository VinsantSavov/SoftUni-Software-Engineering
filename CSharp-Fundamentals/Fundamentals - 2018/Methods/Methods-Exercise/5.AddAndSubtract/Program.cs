using System;

namespace _5.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int result = Subtract(first, second, third);
            Console.WriteLine(result);
        }

        public static int Sum(int first,int second)
        {
            int sum = first + second;
            return sum;
        }

        public static int Subtract(int first,int second,int third)
        {
            int sum = Sum(first, second);
            int subtraction = sum - third;
            return subtraction;
        }
    }
}
