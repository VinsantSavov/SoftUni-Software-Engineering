using System;

namespace _5.MinNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;
            int count = 0;

            while(count < numCount)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < minNum)
                {
                    minNum = number;
                }
                count++;
            }
            Console.WriteLine(minNum);
        }
    }
}
