using System;

namespace _5.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());

            int result = Subtract(firstInteger, secondInteger, thirdInteger);

            Console.WriteLine(result);
        }

        static public int Sum(int first, int second)
        {
            return first + second;
        }

        static public int Subtract(int first, int second, int third)
        {
            int sum = Sum(first, second);

            return sum - third;
        }
    }
}
