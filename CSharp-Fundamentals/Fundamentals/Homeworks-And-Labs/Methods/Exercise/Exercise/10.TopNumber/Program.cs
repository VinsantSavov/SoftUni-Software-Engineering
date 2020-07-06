using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintsAllMasterNums(number);
        }

        static public void PrintsAllMasterNums(int num)
        {
            int masterNum = 0;

            for (int i = 1; i <= num; i++)
            {
                int copy = i;
                masterNum = i;
                int sum = 0;
                int oddCount = 0;

                while (copy!=0)
                {
                    int digit = copy % 10;
                    copy /= 10;
                    sum += digit;

                    if (digit % 2 != 0)
                    {
                        oddCount++;
                    }
                }
                if (sum % 8 == 0 && oddCount >= 1)
                {
                    Console.WriteLine(masterNum);
                }
            }
        }
    }
}
