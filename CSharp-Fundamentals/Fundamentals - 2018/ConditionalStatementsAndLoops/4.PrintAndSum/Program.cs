using System;

namespace _4.PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = firstNum; i <= lastNum; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}",sum);
            
        }
    }
}
