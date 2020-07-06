using System;

namespace _6.SumOfPrimeAndNonPrimeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
            int result = 0; ;

            while (number != "stop")
            {
                int trying = 0;
                int nums = int.Parse(number);

                if (nums < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                
                if (nums % 2 == 0)
                {
                    trying = nums / 2;
                    if (trying % 3 == 0 || trying % 5 == 0 || trying % 7 == 0 || trying % 11 == 0 || trying % 17 == 0)
                    {
                        sumNonPrime += nums;
                    }
                }
                else if (nums % 3 == 0)
                {
                    trying = nums / 3;
                    if (trying % 2 == 0 || trying % 5 == 0 || trying % 7 == 0 || trying % 11 == 0 || trying % 17 == 0)
                    {
                        sumNonPrime += nums;
                    }
                }
                else if (nums % 5 == 0)
                {
                    trying = nums / 5;
                    if (trying % 2 == 0 || trying % 3 == 0 || trying % 7 == 0 || trying % 11 == 0 || trying % 17 == 0)
                    {
                        sumNonPrime += nums;
                    }
                }
                else if (nums % 7 == 0)
                {
                    trying = nums / 7;
                    if (trying % 2 == 0 || trying % 5 == 0 || trying % 3 == 0 || trying % 11 == 0 || trying % 17 == 0)
                    {
                        sumNonPrime += nums;
                    }
                }
                else if (nums % 11 == 0)
                {
                    trying = nums / 11;
                    if (trying % 2 == 0 || trying % 5 == 0 || trying % 7 == 0 || trying % 3 == 0 || trying % 17 == 0)
                    {
                        sumNonPrime += nums;
                    }
                }
                else if (nums % 17 == 0)
                {
                    trying = nums / 17;
                    if (trying % 2 == 0 || trying % 5 == 0 || trying % 7 == 0 || trying % 11 == 0 || trying % 3 == 0)
                    {
                        sumNonPrime += nums;
                    }
                }
                else
                {
                    sumPrime += nums;
                }
                number = nums.ToString();
                number = Console.ReadLine();
            }
            Console.WriteLine("Sum of all prime numbers is: {0}",sumPrime);
            Console.WriteLine("Sum of all non prime numbers is: {0}", sumNonPrime);
        }
    }
}
