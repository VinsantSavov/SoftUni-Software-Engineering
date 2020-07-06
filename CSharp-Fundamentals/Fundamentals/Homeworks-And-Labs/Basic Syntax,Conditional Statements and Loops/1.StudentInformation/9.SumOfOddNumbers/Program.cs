using System;

namespace _9.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 1;
            int num = 1;

            while(count <= n)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                    sum += num;
                    count++;
                }
                num++;
            }
            Console.WriteLine($"Sum: {sum}");
          
        }
    }
}
