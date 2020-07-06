using System;

namespace _6.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int numsOne = 1;

            int result = 0;

            while(number != 0)
            {
                int currentNumber = number % 10;
                number /= 10;

                for(int n = 1; n <= currentNumber; n++)
                {
                  numsOne *= n; 
                }
                result += numsOne;
            }
            if(result == numberCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
