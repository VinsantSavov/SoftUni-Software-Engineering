using System;

namespace _2.ElementEqualToTheSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNum = int.MinValue;
           

            for(int i = 0; i < n; i++)
            {
                 int number = int.Parse(Console.ReadLine());
                
                if (number > maxNum)
                {
                    maxNum = number;
                }
                
                sum += number;
                
            }
            sum -= maxNum;
            if (maxNum == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sum);
            }
            else if (maxNum != sum)
            {
                int difference = Math.Abs(maxNum - sum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + difference);
            }
        }
    }
}
