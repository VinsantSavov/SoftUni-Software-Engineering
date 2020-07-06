using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEven = false;

            while (isEven == false)
            {
                int num = int.Parse(Console.ReadLine());
                num = Math.Abs(num);

                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {num}");
                    isEven = true;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
