using System;

namespace _6.DivideWithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            


            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if(number % 4 == 0)
                {
                    p3++;
                }
            }
            p1 = p1 / n * 100.00;
            p2 = p2 / n * 100.00;
            p3 = p3 / n * 100.00;

            Console.WriteLine("{0:F2}%", p1);
            Console.WriteLine("{0:F2}%", p2);
            Console.WriteLine("{0:F2}%", p3);
        }
    }
}
