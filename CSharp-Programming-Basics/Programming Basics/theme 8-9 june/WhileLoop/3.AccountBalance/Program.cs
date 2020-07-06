using System;

namespace _3.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int paymentCount = int.Parse(Console.ReadLine());
            int count = 0;
            double totalPayment = 0;

            while(count < paymentCount)
            {
                double sum = double.Parse(Console.ReadLine());
                if(sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine("Increase: {0:F2}", sum);
                    totalPayment += sum;
                }
                count++;
            }
            Console.WriteLine("Total: {0:F2}", totalPayment);
        }
    }
}
