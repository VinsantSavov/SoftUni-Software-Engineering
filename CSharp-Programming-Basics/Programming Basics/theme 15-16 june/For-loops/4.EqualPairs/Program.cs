using System;

namespace _4.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int previousSum = 0;
            int maxDiff = 0;
        
            for(int i = 0; i < n; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                int currentSum = firstNumber + secondNumber;
                int diff = Math.Abs(currentSum - previousSum);
               
               
                if(diff > maxDiff && i > 0)
                {
                    maxDiff = diff;
                }
                
                previousSum = currentSum;
            }
            if(maxDiff == 0)
            {
                Console.WriteLine("Yes, value={0}", previousSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
