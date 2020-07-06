using System;

namespace _6.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int copiedNumber = int.Parse(number);

            int factorial = 1;
            int sum = 0;
            int lastElement = 0;

            for (int i = 0; i < number.Length; i++)
            {
                lastElement = number[i];
            }

            while (copiedNumber != lastElement)
            {
                int fn = copiedNumber % 10;
                copiedNumber /= 10;
                for (int i = 2; i <= fn; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
            }
            if (sum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
