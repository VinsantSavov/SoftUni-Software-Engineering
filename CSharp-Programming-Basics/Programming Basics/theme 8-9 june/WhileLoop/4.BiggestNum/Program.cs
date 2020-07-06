using System;

namespace _4.BiggestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            int count = 0;
            int maxNum = int.MinValue;

            while(count < numCount)
            {
                int number = int.Parse(Console.ReadLine());
                if(number > maxNum)
                {
                    maxNum = number;
                }
                count++;
            }
            Console.WriteLine(maxNum);
        }
    }
}
