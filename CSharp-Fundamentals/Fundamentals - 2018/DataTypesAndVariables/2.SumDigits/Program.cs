using System;

namespace _2.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;

            for(int i = number.Length - 1; i>=0; i--)
            {
                int num = (int)number[i];
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
